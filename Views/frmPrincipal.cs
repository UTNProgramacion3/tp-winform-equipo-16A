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
using Business.Dtos;


namespace TPWinForm_16A.Views
{
    public partial class frmPrincipal : Form
    {
        protected List<ArticuloDTO> _articulos;
        protected List<Imagen> _imagenes;
        protected ArticuloManager _artManager;
        protected ImagenManager _imgManager;
        protected MarcaManager _marcManager;
        protected CategoriaManager _catManager;

        public frmPrincipal()
        {
            InitializeComponent();
            InitializeManagers();
        }

        private void InitializeManagers()
        {
            _artManager = new ArticuloManager();
            _imgManager = new ImagenManager();
            _marcManager = new MarcaManager();
            _catManager = new CategoriaManager();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarArticulos(dgvArticulos);
            CargarImagenArticulo();
        }

        private void tlsNuevoArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmAgregarArticulo>();
        }

        private void tlsBuscarArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmBuscarArticulo>();
        }

        private void tlsbCargarArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmAgregarArticulo>();
        }

        private void tlsbEditarArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmEditarArticulo>();
        }

        private void tlsbBuscarArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmBuscarArticulo>();
        }

        private void tlsNuevoMarca_Click(object sender, EventArgs e)
        {
            OpenForm<frmAgregarMarca>();
        }

        private void tlsEditarMarca_Click(object sender, EventArgs e)
        {
            OpenForm<frmEditarMarca>();
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.ShowDialog();
        }

        private void CargarArticulos(DataGridView dataGridView)
        {
            _articulos = _artManager.ObtenerTodos();
            dataGridView.DataSource = _articulos;

            string rutaIconoEditar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\editar.png");
            string rutaIconoEliminar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\eliminar.png");

            ConfigurarColumnas(dataGridView, rutaIconoEditar, rutaIconoEliminar);
            //dataGridView.CellFormatting += dgvArticulos_CellFormatting;
        }

        private void ConfigurarColumnas(DataGridView dataGridView, string rutaIconoEditar, string rutaIconoEliminar)
        {
            dataGridView.Columns["Id"].Visible = false;
            //dataGridView.Columns["IdMarca"].HeaderText = "Marca";
            //dataGridView.Columns["IdCategoria"].HeaderText = "Categoria";

            AgregarColumnaImagen(dataGridView, "Editar", rutaIconoEditar);
            AgregarColumnaImagen(dataGridView, "Eliminar", rutaIconoEliminar);
        }

        private void AgregarColumnaImagen(DataGridView dataGridView, string nombreColumna, string rutaImagen)
        {
            if (dataGridView.Columns[nombreColumna] == null)
            {
                DataGridViewImageColumn columnaImagen = new DataGridViewImageColumn
                {
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Image = Image.FromFile(rutaImagen),
                    Name = nombreColumna
                };
                dataGridView.Columns.Add(columnaImagen);
            }
        }

        //Esto no es practico para nada, funciona pero imaginate si tienes 1000 articulos, 
        //es una saturacion completa de llamados a la bd
        //voy a correjirlo mañana.
        //private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    DataGridView dataGridView = sender as DataGridView;

        //    if (e.Value == null)
        //        return;

        //    if (dataGridView.Columns[e.ColumnIndex].Name == "IdCategoria" && int.TryParse(e.Value.ToString(), out int idCategoria))
        //    {
        //        e.Value = ObtenerDescripcionCategoria(idCategoria);
        //        e.FormattingApplied = true;
        //    }
        //    else if (dataGridView.Columns[e.ColumnIndex].Name == "IdMarca" && int.TryParse(e.Value.ToString(), out int idMarca))
        //    {
        //        e.Value = ObtenerDescripcionMarca(idMarca);
        //        e.FormattingApplied = true;
        //    }
        //}

        private string ObtenerDescripcionCategoria(int idCategoria)
        {
            Categoria categoria = _catManager.ObtenerPorId(idCategoria);
            return categoria?.Descripcion ?? "Sin Categoría";
        }

        private string ObtenerDescripcionMarca(int idMarca)
        {
            Marca marca = _marcManager.ObtenerPorId(idMarca);
            return marca?.Descripcion ?? "Sin Marca";
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            CargarImagenArticulo();
        }

        private void CargarImagenArticulo()
        {
            ArticuloDTO art = (ArticuloDTO)dgvArticulos.CurrentRow?.DataBoundItem;
            if (art != null)
            {
                _imagenes = _imgManager.ObtenerImagenesPorArticulo(art.Id);
                string imagenUrl = _imagenes != null && _imagenes.Count > 0
                    ? _imagenes[0].ImagenUrl
                    : "https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminada-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg";

                CargarImagen(pbArticulo, imagenUrl);
            }
        }

        private void CargarImagen(PictureBox pictureBox, string url)
        {
            try
            {
                pictureBox.Load(url);
            }
            catch (System.Net.WebException)
            {
                pictureBox.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminada-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
            }
        }

        private int ObtenerIdArticuloSeleccionado()
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                Articulo art = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
                return art.Id;
            }
            return 0;
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;

                if (dataGridView.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Articulo art = (Articulo)dataGridView.Rows[e.RowIndex].DataBoundItem;
                    frmEditarArticulo view = new frmEditarArticulo(art);
                    view.ShowDialog();
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int id = ObtenerIdArticuloSeleccionado();

                    DialogResult res = MessageBox.Show("¿Estás seguro de que quieres eliminar este artículo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        _artManager.Eliminar(id);
                        CargarArticulos(dgvArticulos);
                    }
                }
            }
        }
    }
}
