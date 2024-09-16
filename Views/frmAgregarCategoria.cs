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
using DataAccess;
using Domain.Entities;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria();
            CategoriaManager manager = new CategoriaManager();

            nueva.Descripcion = txtbDescripcion.Text;

            var res = manager.Crear(nueva);

            var mensaje = res.Id != 0 == true ? MessageBox.Show("Categoria agregada correctamente") : MessageBox.Show("Error al agregar categoria");

            txtbDescripcion.Clear();
            txtbDescripcion.Focus();
        }
    }
}
