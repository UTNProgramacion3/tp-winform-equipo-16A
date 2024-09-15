using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Managers;
using Domain.Entities;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmListaCategorias : Form
    {
        private CategoriaManager _manager = new CategoriaManager();
        private Categoria _categoria = new Categoria();
        bool _delete = false;

        public frmListaCategorias()
        {
            InitializeComponent();
        }

        public frmListaCategorias(bool delete)
        {
            InitializeComponent();
            _delete = delete;
            btnEditar.Text = "Elimnar";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            
            dgvCategorias.DataSource = _manager.ObtenerTodos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                frmEditarCategoria ventana = new frmEditarCategoria(_categoria);
            
            if(!_delete)
            {
                ventana.ShowDialog();
                _categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            }
            else
            {
                _categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                

                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar la Categoria: " + _categoria.Descripcion + "?","Eliminar Categoria",MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    _manager.Eliminar(_categoria.Id);
                    MessageBox.Show("Categoria eliminada correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha eliminado ninguna Categoria...");
                }

            }


            dgvCategorias.DataSource = _manager.ObtenerTodos();

        }
    }
}
