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
    public partial class frmListado : Form
    {
        NegocioArticulo negocioArticulo;
        List<Articulo> articulos;
        public frmListado()
        {
            InitializeComponent();
        }
        //TODO: frmListado LOAD
        private void frmListado_Load(object sender, EventArgs e)
        {
            try
            {
                negocioArticulo = new NegocioArticulo();
                articulos = negocioArticulo.Leer();
                if(articulos != null ) 
                    dgvLista.DataSource = articulos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //TODO: EVENTO CAMBIO DE TEXTO EN CAJA DE FILTRO
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            if(articulos == null )
                return;
            try
            {
                if (filtro.Length > 2)
                {
                    articulos = articulos.FindAll(itm => itm.nombre.ToUpper().Contains(filtro.ToUpper()) || itm.codigo.ToUpper().Contains(filtro.ToUpper()));
                    dgvLista.DataSource = null;
                    dgvLista.DataSource = articulos;
                }
                else if (filtro.Length == 0)
                {
                    negocioArticulo = new NegocioArticulo();
                    articulos = negocioArticulo.Leer();
                    dgvLista.DataSource = null;
                    dgvLista.DataSource = articulos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
