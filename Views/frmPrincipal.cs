using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business.Managers;
using Domain.Entities;

namespace TPWinForm_16A.Views
{
    public partial class frmPrincipal : Form
    {
        protected List<Articulo> _articulos;
        protected ArticuloManager _artManager;
        protected ImagenManager _imgManager;

        public frmPrincipal()
        {
            _artManager = new ArticuloManager();
            _imgManager = new ImagenManager();
            _articulos = new List<Articulo>();
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarArticulos(dgvArticulos);
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

        private void CargarArticulos(DataGridView dataGridView)
        {
            _articulos = _artManager.ObtenerTodos();
            dataGridView.DataSource = _articulos;
            string rutaIconoEditar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\editar.png");
            string rutaIconoEliminar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\eliminar.png");

            dataGridView.Columns["Id"].Visible = false;


            if (dataGridView.Columns["Editar"] == null)
            {
                DataGridViewImageColumn editarCol = new DataGridViewImageColumn();
                editarCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                editarCol.Image = Image.FromFile(rutaIconoEditar);
                editarCol.Name = "Editar";
                dataGridView.Columns.Add(editarCol);
            }

            if (dataGridView.Columns["Eliminar"] == null)
            {
                DataGridViewImageColumn eliminarCol = new DataGridViewImageColumn();
                eliminarCol.Image = Image.FromFile(rutaIconoEliminar);
                eliminarCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                eliminarCol.Name = "Eliminar";
                dataGridView.Columns.Add(eliminarCol);
            }
        }

    }
}
