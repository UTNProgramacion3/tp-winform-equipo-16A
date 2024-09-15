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
    public partial class frmEditarCategoria : Form
    {
       
        private Categoria _categoria = new Categoria();
        CategoriaManager _manager = new CategoriaManager();

        public frmEditarCategoria(Categoria cat)
       
        {
            InitializeComponent();
            _categoria = cat;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void editarCategoria()
        {
            

            _categoria.Descripcion = txtbNuevaDescripcion.Text;

            try
            {
                _manager.Update(_categoria);
                MessageBox.Show("Categoria modificada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar categoria");
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            editarCategoria();
            Close();
        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            txtbDescripcionActual.Text = _categoria.Descripcion.ToString();
        }

        private void txtbDescripcionActual_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
