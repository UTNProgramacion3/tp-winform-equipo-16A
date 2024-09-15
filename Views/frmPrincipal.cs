using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business.Managers;
using TPWinForm_equipo_16A.Views;
using Business.Dtos;
using Utils.Interfaces;
using Utils;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmPrincipal : Form
    {
        protected List<ArticuloDTO> _articulos;
        protected List<Imagen> _imagenes;
        protected ArticuloManager _artManager;
        protected ImagenManager _imgManager;
        protected MarcaManager _marcManager;
        protected CategoriaManager _catManager;
        protected IMapper<ArticuloDTO> _mapper;
        protected int indexActual = 0;
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
            _mapper = new Mapper<ArticuloDTO>();
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
            OpenForm<frmListaMarcas>();
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.ShowDialog();
        }

        private void CargarArticulos(DataGridView dataGridView, bool isReload = false)
        {
            if(isReload)
            {
                dataGridView.DataSource = null;
                dgvArticulos.Columns.Remove("Editar");
                dgvArticulos.Columns.Remove("Eliminar");

            }
            _articulos = _artManager.ObtenerTodos();
            dataGridView.DataSource = _mapper.MapFromDtoToTable(_articulos); // Cambiado a DataTable

            string rutaIconoEditar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\editar.png");
            string rutaIconoEliminar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\eliminar.png");

            ConfigurarColumnas(dataGridView, rutaIconoEditar, rutaIconoEliminar);
        }

        private void ConfigurarColumnas(DataGridView dataGridView, string rutaIconoEditar, string rutaIconoEliminar)
        {
            for (int i = dataGridView.Columns.Count - 1; i >= 0; i--)
            {
                DataGridViewColumn column = dataGridView.Columns[i];
                if (column.Name.ToLower().Contains("_id"))
                {
                    dataGridView.Columns.RemoveAt(i);
                }
            }

            if (dataGridView.Columns.Contains("Marca_Descripcion"))
            {
                dataGridView.Columns["Marca_Descripcion"].HeaderText = "Marca";
            }

            if (dataGridView.Columns.Contains("Categoria_Descripcion"))
            {
                dataGridView.Columns["Categoria_Descripcion"].HeaderText = "Categoría";
            }

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
            if (dgvArticulos.CurrentRow != null)
            {
                int rowIndex = dgvArticulos.CurrentRow.Index;
                ArticuloDTO art = _articulos[rowIndex];

                if (art != null)
                {
                    _imagenes = _imgManager.ObtenerImagenesPorArticulo(art.Articulo.Id);
                    string imagenUrl = _imagenes != null && _imagenes.Count > 0
                        ? _imagenes[0].ImagenUrl
                        : "https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminada-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg";

                    CargarImagen(pbArticulo, imagenUrl);
                }
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
                int rowIndex = dgvArticulos.CurrentRow.Index;
                ArticuloDTO art = _articulos[rowIndex];
                return art.Articulo.Id;
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
                    int rowIndex = dgvArticulos.CurrentRow.Index;
                    ArticuloDTO art = _articulos[rowIndex];
                    using (frmEditarArticulo view = new frmEditarArticulo(art))
                    {
                        DialogResult result = view.ShowDialog();

                        if(result == DialogResult.OK)
                        {
                           CargarArticulos(dgvArticulos, true);

                        }
                    }
                        
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int id = ObtenerIdArticuloSeleccionado();

                    DialogResult res = MessageBox.Show("¿Estás seguro de que quieres eliminar este artículo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        _artManager.Eliminar(id);
                        CargarArticulos(dgvArticulos, true);
                    }
                }
            }
        }

        private void btnBackImg_Click(object sender, EventArgs e)
        {
            if (indexActual > 0 && _imagenes != null)
            {
                indexActual--;
                CargarImagen(pbArticulo, _imagenes[indexActual].ImagenUrl);
            }
        }
        private void btnNextImg_Click(object sender, EventArgs e)
        {
            if (indexActual < _imagenes.Count - 1 && _imagenes != null)
            {
                indexActual++;
                CargarImagen(pbArticulo, _imagenes[indexActual].ImagenUrl);
            }
        }

        private void tlsEliminarMarca_Click(object sender, EventArgs e)
        {
            Marca _marca = new Marca();

            frmListaMarcas listado = new frmListaMarcas(_marca);

            listado.ShowDialog();

        }

        private void tlsNuevoCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventana = new frmAgregarCategoria();

            ventana.ShowDialog();
        }

        private void tlsEditarCategoria_Click(object sender, EventArgs e)
        {
            frmListaCategorias ventana = new frmListaCategorias();

            ventana.ShowDialog();
        }
    }
}
