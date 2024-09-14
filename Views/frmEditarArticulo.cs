using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;

namespace TPWinForm_16A.Views
{
    public partial class frmEditarArticulo : Form
    {
        protected Articulo _art;
        
        public frmEditarArticulo()
        { }
        public frmEditarArticulo(Articulo art = null)
        {
            InitializeComponent();
            if (art != null)
                _art = art;
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            if(_art != null)
            {
                CargarArticulo(_art);
            }
        }

        private void CargarArticulo(Articulo art)
        {
            txtbCodigoEdt.Text = art.Codigo;
            txtbEaDescripcion.Text = art.Descripcion;
            txtbNombreEdt.Text = art.Nombre;
            txtbEaPrecio.Text = art.Precio.ToString();

        }
    }
}
