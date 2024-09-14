using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business.Managers;
using Domain.Entities;
using TPWinForm_equipo_16A.Views;


namespace TPWinForm_16A.Views
{
    public partial class frmPrincipal : Form
    {
        protected List<Articulo> _articulos;
        protected List<Imagen> _imagenes;
        protected ArticuloManager _artManager;
        protected ImagenManager _imgManager;
        protected MarcaManager _marcManager;
        protected CategoriaManager _catManager;

        public frmPrincipal()
        {
            _artManager = new ArticuloManager();
            _imgManager = new ImagenManager();
            _marcManager = new MarcaManager();
            _catManager = new CategoriaManager();
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarArticulos(dgvArticulos);
            pbArticulo.Load(_imagenes[0].ImagenUrl);
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

            // Suscribirse al evento CellFormatting
            //dataGridView.CellFormatting += dgvArticulos_CellFormatting;
        }
        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            // Asegurarse de que el valor de la celda no sea null
            if (e.Value == null)
            {
                return;
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "IdCategoria" && int.TryParse(e.Value.ToString(), out int idCategoria))
            {
                Categoria categoria = _catManager.ObtenerPorId(idCategoria);

                // Verificar que el objeto categoria no sea null
                if (categoria != null)
                {
                    e.Value = !string.IsNullOrEmpty(categoria.Descripcion) ? categoria.Descripcion : "Sin Categoría";
                }
                else
                {
                    e.Value = "Categoría no encontrada";
                }

                e.FormattingApplied = true;
            }
            else if (dataGridView.Columns[e.ColumnIndex].Name == "IdMarca" && int.TryParse(e.Value.ToString(), out int idMarca))
            {
                Marca marca = _marcManager.ObtenerPorId(idMarca);

                // Verificar que el objeto marca no sea null
                if (marca != null)
                {
                    e.Value = !string.IsNullOrEmpty(marca.descripcion) ? marca.descripcion : "Sin Marca";
                }
                else
                {
                    e.Value = "Marca no encontrada";
                }

                e.FormattingApplied = true;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            _imagenes = _imgManager.ObtenerImagenesPorArticulo(art.Id);

            try
            {
                if (_imagenes != null)
                {
                    pbArticulo.Load(_imagenes[0].ImagenUrl);
                }
                else
                {
                    pbArticulo.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
                }

            }
            catch (System.Net.WebException ex)
            {
                pbArticulo.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
            }
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
