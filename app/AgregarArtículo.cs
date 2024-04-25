using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app
{
    public partial class frmAgregarArt : Form
    {
        private Articulo articulo = null;
        private NegocioArticulo negocio;
        private OpenFileDialog file = null;
        private string msj = null;
        public frmAgregarArt()
        {
            InitializeComponent();
        }
        public frmAgregarArt(Articulo art)
        {
            this.articulo = art;
            InitializeComponent();
        }

        //TODO: EVENTOS:
        //TODO: LOAD frmAgregarArt
        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            try
            {
                lblModificar.Visible = false;
                lblCarga.Visible = true;
                cboMarca.DataSource = negocio.LeerMarcas();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "marca";
                cboCategoria.DataSource = negocio.LeerCategorias();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "categoria";

                if (articulo != null ) 
                {
                    lblModificar.Visible = true;
                    lblCarga.Visible = false;
                    cargarFormulario(articulo);
                    cboMarca.SelectedIndex = articulo.marca.idMarca - 1;
                    cboCategoria.SelectedIndex = articulo.categoria.idCategoria - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //TODO: BOTON CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TODO: BOTON ACEPTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO: Agregar Articulo
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            int resArt = 0;
            int resImg = 0;
            int resFichero;
            try 
            {
                if(articulo == null)
                    articulo = new Articulo();

                if (!validarInputs(articulo))
                    return;

                articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                if(articulo.id != 0) //SI ES UN ARTICULO 'YA EXISTENTE'
                {
                    resFichero = guardarImgFichero(file); // 0 si guardo, 1 si la ruta ya existe, 2 si solo se guarda una url en la BD
                    if(resFichero != 1)
                    {
                        resArt += negocioArticulo.Modificar(articulo);
                        resImg += negocioArticulo.ModificarImg(articulo.id, articulo.UrlImagen);
                    }
                    else if(resFichero == 1)
                    {
                        MessageBox.Show("La ruta de imagen ya existe");
                        return;
                    }

                }
                else // SI ES UN ARTICULO NUEVO
                {
                    if(!string.IsNullOrEmpty(txtUrl.Text))
                    {
                        resFichero = guardarImgFichero(file); // 0 si guardo, 1 si la ruta ya existe, 2 si solo se guarda una url en la BD
                        if (resFichero != 1)
                        {
                            resArt += negocioArticulo.Agregar(articulo);
                            resImg += negocioArticulo.AgregarImg(articulo.id, articulo.UrlImagen);
                        }
                        else if (resFichero == 1)
                        {
                            MessageBox.Show("La ruta de imagen ya existe");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay que agregar una imagen/ruta de imagen para continuar");
                        return;
                    }
                }

                confirmacion(resArt, resImg);

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        //TODO: Validacion URL
        public bool ValidarUrl(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) &&
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                // La URL es válida
                return true;
            }
            else
            {
                // La URL no es válida
                return false;
            }
        }
        //TODO: METODO Validar Entradas
        private bool validarInputs(Articulo articulo)
        {
            if (string.IsNullOrEmpty(txtCodArt.Text))
            {
                msj = "Se necesita ingresar un Codigo";
                MessageBox.Show(msj);
                return false;
            }
            if ( !txtCodArt.Text.All(x => char.IsLetterOrDigit(x)) )
            {
                msj = "El codigo solo tiene que contener Numeros o Letras";
                MessageBox.Show(msj);
                return false;
            }
            if( string.IsNullOrEmpty(txtNombre.Text) )
            {
                msj = "Se necesita ingresar un Nombre";
                MessageBox.Show(msj);
                return false;
            }
            if( !txtNombre.Text.All( x => (char.IsLetterOrDigit(x) || char.IsWhiteSpace(x)) ))
            {
                msj = "El nombre solo puede contener letras o numeros";
                MessageBox.Show(msj);
                return false;
            }
            if( txtNombre.Text.Length > 50 )
            {
                msj = "El nombre no puede tener mas de 50 letras";
                MessageBox.Show(msj);
                return false;
            }
            if( txtDescrip.Text.Length >= 150)
            {
                msj = "La descripicion no puede tener mas de 150 letras";
                MessageBox.Show(msj);
                return false;
            }
            if(string.IsNullOrEmpty(txtPrecio.Text))
            {
                msj = "El precio esta mal ingresado";
                MessageBox.Show(msj);
                return false;
            }
            if( !txtPrecio.Text.All(x => char.IsNumber(x) || char.IsDigit(x) || char.IsPunctuation(x)) )
            {
                msj = "El precio esta mal ingresado";
                MessageBox.Show(msj);
                return false;
            }
            if (!ValidarUrl(txtUrl.Text))
            {
                MessageBox.Show("URL Inválido, intente nuevamente.");
                return false;
            }

            articulo.nombre = txtNombre.Text;
            articulo.codigo = txtCodArt.Text;
            articulo.descripicion = txtDescrip.Text;
            articulo.UrlImagen = txtUrl.Text;
            articulo.precio = decimal.Parse(txtPrecio.Text);
            return true;
        }
        //TODO: EVENTO IMAGEN EN CARGA DE ARTICULO
        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImg(txtUrl.Text);
        }
        //TODO: METODO CARGAR IMAGEN
        private void cargarImg(string imagen)
        {
            try
            {
                pbxCargaImg.Load(imagen);
            }
            catch
            {
                pbxCargaImg.Load("https://images.wondershare.com/repairit/aticle/2021/07/resolve-images-not-showing-problem-1.jpg");
            }
        }
        //TODO: METODO CARGAR FORMULARIO
        private void cargarFormulario(Articulo articulo) 
        {
            txtCodArt.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescrip.Text = articulo.descripicion;
            txtPrecio.Text = articulo.precio.ToString();
            txtUrl.Text = articulo.UrlImagen;
            cboCategoria.SelectedValue = articulo.categoria.idCategoria;
            cboMarca.SelectedValue = articulo.marca.idMarca;
            
            try
            {
                pbxCargaImg.Load(articulo.UrlImagen);
            }
            catch (Exception)
            {
                cargarImg("https://images.wondershare.com/repairit/aticle/2021/07/resolve-images-not-showing-problem-1.jpg");
                MessageBox.Show("Se requiere reemplazar la imágen");
            }

        }
        //TODO: METODO CARGAR IMG desde fichero
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            try
            {
                file.Filter = "jpg|*.jpg;|png|*.png;|jpeg|*.jpeg;|bmp|*.bmp";
                if(file.ShowDialog() == DialogResult.OK) 
                {
                    cargarImg(file.FileName);
                    txtUrl.Text = file.FileName;
                    //termina de guardar archivo en Boton aceptar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //TODO: METODO GUARDAR FICHERO IMG LOCAL
        private int guardarImgFichero(OpenFileDialog fileDialog)
        {
            if(fileDialog != null) // SI EL USURIO CLIKEO EN CARGAR IMAGEN EN EL FORM
            {
                string path = ConfigurationManager.AppSettings["image-folder"] + fileDialog.SafeFileName;
                try
                {
                    if(!File.Exists(path))
                    {
                        File.Copy(fileDialog.FileName, path);
                        return 0;
                    }
                    else
                    { 
                        return 1;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                { 
                    fileDialog.Dispose(); // creo que no hace falta usarlo, ya que File funciona como una clase estatica mepa
                }
            }
            else
            {
                return 2;
            }
        }
        //TODO: METODO MOSTRAR RESULTADOS DE CARGA
        private void confirmacion(int resart, int resimg)
        {
            if (resart > 0 && resimg > 0)
            {
                MessageBox.Show("Articulo Guardado/Modificado");
                Close();
            }
            else if (resimg == 0)
            {
                MessageBox.Show("Articulo guardado/modificado sin Imagen");
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la carga de datos");
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }//Fin
}
