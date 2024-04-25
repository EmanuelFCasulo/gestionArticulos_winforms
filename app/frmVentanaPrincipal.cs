using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmVentanaPrincipal : Form
    {
        //TODO: VARIABLES frmVentanaPrincipal
        NegocioArticulo negocio;
        private List<Articulo> ListaArticulos;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        //TODO: LOAD frmVentanaPrincipal
        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            ListaArticulos = negocio.Leer();
            ListaArticulos = filtrarDuplicado();
            CargarTabla(ListaArticulos);

            //Carga de filtros
            cboFiltroMarca.DataSource = negocio.LeerMarcas();
            cboFiltroMarca.ValueMember = "IdMarca";
            cboFiltroMarca.DisplayMember = "marca";
            cboFiltroCategoria.DataSource = negocio.LeerCategorias();
            cboFiltroCategoria.ValueMember = "IdCategoria";
            cboFiltroCategoria.DisplayMember = "categoria";

            cboFiltroCriterio.Items.Add("Solo categoría");
            cboFiltroCriterio.Items.Add("Solo marca");
            cboFiltroCriterio.Items.Add("Ambos");
            cboFiltroCriterio.SelectedIndex = 2;

        }
        //TODO:ocultar columnas de la grilla
        private void ocultarColumnas()
        {
            dgvPanel.Columns["UrlImagen"].Visible = false;
            dgvPanel.Columns["id"].Visible = false;
        }

        //TODO: EVENTOS de frmVentanaPrincipal
        //TODO: BOTON ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            ListaArticulos = negocio.Leer();
            ListaArticulos = filtrarDuplicado();
            CargarTabla(ListaArticulos);
        }
        //TODO: BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArt frmAgregarArt = new frmAgregarArt();
            frmAgregarArt.ShowDialog();
        }
        //TODO: SELECCION EN GRID
        private void dgvPanel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPanel.CurrentRow != null)//valido que el index no sea nulo para que no tire error al actualizar la grilla
            {
                Articulo seleccionado = (Articulo)dgvPanel.CurrentRow.DataBoundItem;
                CargarImg(seleccionado.UrlImagen);
            }
        }
        //TODO: BOTON EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)dgvPanel.CurrentRow.DataBoundItem;
                frmAgregarArt frmAgregarArt = new frmAgregarArt(art);
                frmAgregarArt.ShowDialog();   
            }
            catch
            {
                MessageBox.Show("Tienes que selecionar un articulo");
            }
        }
        //TODO: BOTON ELEMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvPanel.CurrentRow.DataBoundItem;
                DialogResult r = MessageBox.Show("Desea eliminar el artículo?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    if (negocio.Eliminar(seleccionado.id) > 0)
                        MessageBox.Show("Artículo eliminado exitosamente!");
                    ListaArticulos = negocio.Leer();
                    ListaArticulos = filtrarDuplicado();
                    CargarTabla(ListaArticulos);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //TODO: FILTROS avanzados
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            List<Articulo> listaFiltrada = new List<Articulo>();

            foreach (var articulo in ListaArticulos)
            { 
                if(cboFiltroCriterio.Text == "Solo categoria")
                {
                    //valida que el contenido del combo marca sea igual o similar
                    listaFiltrada = ListaArticulos.FindAll(x => (x.categoria.categoria.Contains(cboFiltroCategoria.Text)));
                }
                else if(cboFiltroCriterio.Text == "Solo marca")
                {
                    //valida que el contenido del combo marca sea igual o similar
                    listaFiltrada = ListaArticulos.FindAll(x => (x.marca.marca.Contains(cboFiltroMarca.Text)));
                }
                else
                {
                    //valida que el contenido de los dos combos sean iguales
                    listaFiltrada = ListaArticulos.FindAll(x => (x.categoria.categoria.Contains(cboFiltroCategoria.Text)
                                    && x.marca.marca.Contains(cboFiltroMarca.Text)));
                }
                
            }
            dgvPanel.DataSource = null;
            dgvPanel.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        //TODO: filtrar rapido a medida que se escribe
        private void tbFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbFiltroNombre.Text;

            //Si tiene datos aplica el filtro, sino muestra todos los artículos
            if (filtro.Length > 2)
            {
                //el constains valida por silabas o letras las palabras sin tener que poner la palabra exacta.
                listaFiltrada = ListaArticulos.FindAll(
                    x => (x.nombre.ToUpperInvariant().Contains(filtro.ToUpperInvariant()) ||
                    x.codigo.ToUpperInvariant().Contains(filtro.ToUpperInvariant())));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }
            CargarTabla(listaFiltrada);
        }

        //TODO: METODOS frmVentanaPrincipal
        //TODO: Cargar Imagen
        private void CargarImg(string path)
        {
            try
            {
                pbxArticuloLoad.Load(path);
            }
            catch (Exception)
            {
                pbxArticuloLoad.Load("https://www.shutterstock.com/image-vector/no-image-available-vector-illustration-260nw-744886198.jpg");
            }
        }
        //TODO: Cargar Tabla
        private void CargarTabla(List<Articulo> listaFiltrada)
        {
            if(listaFiltrada.Count > 0) 
            {
                dgvPanel.DataSource = null;
                dgvPanel.DataSource = listaFiltrada;
                string urlimg = ((Articulo)dgvPanel.CurrentRow.DataBoundItem).UrlImagen;
                CargarImg(urlimg);
                ocultarColumnas();
            }
        }
        //TODO: Filtrar articulos duplicados
        private List<Articulo> filtrarDuplicado()
        {
            try
            {
                List<Articulo> ls = new List<Articulo>(ListaArticulos);
                for (int i = 0; i < ls.Count; i++)
                {
                    if(i > 0)
                    {
                        if (ls[i].id == ls[i - 1].id)
                            ls.Remove(ls[i]);
                    }
                }
                return ls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cboFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//Fin
}
