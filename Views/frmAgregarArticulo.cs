using Business.Managers;
using Domain.Entities;
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

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmAgregarArticulo : Form
    {
        private readonly MarcaManager _marcaManager;
        private readonly CategoriaManager _categoriaManager;
        private System.Windows.Forms.ComboBox cmbMarcas;
        public frmAgregarArticulo()
        {
            InitializeComponent();
            _marcaManager = new MarcaManager();
            _categoriaManager = new CategoriaManager();
            CargarMarcas();
            CargarCategorias();

        }

        private void cmbAgrMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnAgrSalirSinGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbAgrCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarMarcas()
        {
            List<Marca> marcas = _marcaManager.ObtenerTodos();
            cmbAgrMarca.DataSource = marcas;
            cmbAgrMarca.DisplayMember = "Descripcion";
            cmbAgrMarca.ValueMember = "Id";
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = _categoriaManager.ObtenerTodos();
            cmbAgrCategoria.DataSource = categorias;
            cmbAgrCategoria.DisplayMember = "Descripcion";
            cmbAgrCategoria.ValueMember = "Id";
        }
    }
}
