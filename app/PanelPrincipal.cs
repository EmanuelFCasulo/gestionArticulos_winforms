using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmPanelPrincipal : Form
    {
        //TODO: VARIABLES frmPanelPrincipal
        private List<Articulo> ListaArticulos;
        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void Panel_Principal_Load(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            ListaArticulos = negocio.Leer();
            dgvListadoPrincipal.DataSource = ListaArticulos;
            dgvListadoPrincipal.Columns["UrlImagen"].Visible = false;
            CargarImg(ListaArticulos[0].UrlImagen);
        }

        private void CargarImg(string path)
        {
            try
            {
                pbxArticuloPanelPrincipal.Load(path);
            }
            catch (Exception)
            {
                pbxArticuloPanelPrincipal.Load("https://www.shutterstock.com/image-vector/no-image-available-vector-illustration-260nw-744886198.jpg");
            }
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListadoPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
