using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Managers;
using Domain.Entities;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmEditarImagen : Form
    {
        protected Imagen _imagen;
        protected ImagenManager _imgManager;
        public frmEditarImagen(Imagen imagen)
        {
            _imagen = imagen;
            _imgManager = new ImagenManager();
            InitializeComponent();
        }

        private void frmEditarImagen_Load(object sender, EventArgs e)
        {
            txtbUrl.Text = _imagen.ImagenUrl;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string url = txtbUrl.Text;
            if(!string.IsNullOrEmpty(url))
            {
                _imagen.ImagenUrl = url;
                _imgManager.Update(_imagen);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                MessageBox.Show("Error: no ingreso ninguna Url.");
            }
        }
    }
}
