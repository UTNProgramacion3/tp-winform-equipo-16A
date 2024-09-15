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

        public frmListaCategorias()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            
            dgvCategorias.DataSource = _manager.ObtenerTodos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            _categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            frmEditarCategoria ventana = new frmEditarCategoria(_categoria);
            ventana.ShowDialog();

            dgvCategorias.DataSource = _manager.ObtenerTodos();

        }
    }
}
