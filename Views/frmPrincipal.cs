using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPWinForm_equipo_16A.Views;

namespace TPWinForm_16A.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void tlsNuevoArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventanaArticulo = new frmAgregarArticulo();
            ventanaArticulo.ShowDialog();
        }

        private void tlsBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo ventana = new frmBuscarArticulo();
            ventana.ShowDialog();
        }

        private void tlsbCargarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventanaArticulo = new frmAgregarArticulo();
            ventanaArticulo.ShowDialog();
        }

        private void tlsbEditarArticulo_Click(object sender, EventArgs e)
        {
            frmEditarArticulo ventanaArticulo = new frmEditarArticulo();
            ventanaArticulo.ShowDialog();
        }

        private void tlsbBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo ventanaArticulo = new frmBuscarArticulo();
            ventanaArticulo.ShowDialog();
        }

        private void tlsNuevoMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.ShowDialog();
        }

        private void tlsEditarMarca_Click(object sender, EventArgs e)
        {
            frmEditarMarca ventana = new frmEditarMarca();
            ventana.ShowDialog();
        }
    }
}
