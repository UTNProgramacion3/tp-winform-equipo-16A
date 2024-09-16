using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Entities;
using Business.Managers;
using Business.Dtos;
using System.Drawing;
using System.IO;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmEditarArticulo : Form
    {
        protected ArticuloDTO _art;
        protected ArticuloManager _artManager;
        protected MarcaManager _marcManager;
        protected CategoriaManager _catManager;
        protected ImagenManager _imgManager;
        protected List<Imagen> _imagenes;
        protected List<Categoria> _categorias;
        protected List<Marca> _marcas;

        public frmEditarArticulo()
        {
            InitializeComponent();
            InitializeManagers();
        }

        public frmEditarArticulo(ArticuloDTO art) : this()
        {
            _art = art ?? throw new ArgumentNullException(nameof(art));
        }

        private void InitializeManagers()
        {
            _marcManager = new MarcaManager();
            _catManager = new CategoriaManager();
            _imgManager = new ImagenManager();
            _artManager = new ArticuloManager();
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            if (_art != null)
            {
                CargarArticulo();
                CargarDropDowns();
                CargarImagenesArticulo();
            }
        }

        private void CargarArticulo()
        {
            txtbCodigoEdt.Text = _art.Articulo.Codigo;
            txtbEaDescripcion.Text = _art.Articulo.Descripcion;
            txtbNombreEdt.Text = _art.Articulo.Nombre;
            txtbEaPrecio.Text = _art.Articulo.Precio.ToString();
        }

        private void CargarDropDowns()
        {
            _categorias = _catManager.ObtenerTodos();
            cmbEaCategoria.DataSource = _categorias;
            cmbEaCategoria.DisplayMember = "Descripcion";
            cmbEaCategoria.ValueMember = "Id";
            cmbEaCategoria.SelectedValue = _art.Categoria.Id;

            _marcas = _marcManager.ObtenerTodos();
            cmbEaMarca.DataSource = _marcas;
            cmbEaMarca.DisplayMember = "Descripcion";
            cmbEaMarca.ValueMember = "Id";
            cmbEaMarca.SelectedValue = _art.Marca.Id;
        }

        private void CrearColumnasEditaryEliminar()
        {
            string rutaIconoEditar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\editar.png");
            string rutaIconoEliminar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\eliminar.png");

            AgregarColumnaImagen(dgvImagenes, "Editar", rutaIconoEditar);
            AgregarColumnaImagen(dgvImagenes, "Eliminar", rutaIconoEliminar);
        }

        private void CargarImagenesArticulo()
        {
            if (_art != null)
            {
                CargarDgvImagenes();
                string imagenUrl = _imagenes != null && _imagenes.Count > 0
                    ? _imagenes[0].ImagenUrl
                    : "https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminada-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg";

                CargarImagen(pcbEaArticulo, imagenUrl);
            }
        }

        private void CargarDgvImagenes(bool isReload = false)
        {
            if (isReload)
            {
                dgvImagenes.DataSource = null;
                dgvImagenes.Columns.Remove("Editar");
                dgvImagenes.Columns.Remove("Eliminar");
            }

            _imagenes = _imgManager.ObtenerImagenesPorArticulo(_art.Articulo.Id);
            dgvImagenes.DataSource = _imagenes.Count > 0 ? _imagenes : null;
            dgvImagenes.Columns["Id"].Visible = false;
            dgvImagenes.Columns["IdArticulo"].Visible = false;
            CrearColumnasEditaryEliminar();
        }

        private void CargarImagen(PictureBox pictureBox, string url)
        {
            try
            {
                pictureBox.Load(url);
            }
            catch (Exception)
            {
                pictureBox.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminada-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
            }
        }

        private void AgregarImagenArticulo(string imagenUrl)
        {
            if (_art != null)
            {
                Imagen nuevaImagen = new Imagen
                {
                    IdArticulo = _art.Articulo.Id,
                    ImagenUrl = imagenUrl
                };

                _imgManager.Crear(nuevaImagen);
                CargarDgvImagenes(true);
            }
        }

        private void btnEaCargarImagen_Click(object sender, EventArgs e)
        {
            string nuevaImagenUrl = txtbNuevaUrl.Text;

            if (!string.IsNullOrEmpty(nuevaImagenUrl))
            {
                AgregarImagenArticulo(nuevaImagenUrl);
                MessageBox.Show("Imagen agregada correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una URL válida.");
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow != null)
            {
                int rowIndex = dgvImagenes.CurrentRow.Index;

                if (rowIndex + 1 <= _imagenes.Count)
                {
                    Imagen imagen = _imagenes[rowIndex];
                    CargarImagen(pcbEaArticulo, imagen.ImagenUrl);
                }
                else
                {
                    CargarImagen(pcbEaArticulo, null);
                }
            }
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
                dataGridView.AllowUserToAddRows = false;
            }
        }

        private void dgvImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;

                if (dataGridView.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int rowIndex = dgvImagenes.CurrentRow.Index;
                    Imagen img = _imagenes[rowIndex];
                    using (frmEditarImagen frm = new frmEditarImagen(img))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            CargarDgvImagenes(true);
                        }
                    }
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int rowIndex = dgvImagenes.CurrentRow.Index;
                    Imagen img = _imagenes[rowIndex];

                    DialogResult res = MessageBox.Show("¿Estás seguro de que quieres eliminar esta imagen?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        _imgManager.Eliminar(img.Id);
                        CargarDgvImagenes(true);
                    }
                }
            }
        }

        private void btnSalirSinGuardarEdt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambiosEdt_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                EditarArticulo();

                if (_artManager.Update(_art))
                {
                    MessageBox.Show("Articulo editado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error inesperado.");
                }
            }
        }

        private void EditarArticulo()
        {
            _art.Articulo.Nombre = txtbNombreEdt.Text;
            _art.Articulo.Codigo = txtbCodigoEdt.Text;
            _art.Articulo.Descripcion = txtbEaDescripcion.Text;
            _art.Articulo.IdCategoria = Convert.ToInt32(cmbEaCategoria.SelectedValue);
            _art.Articulo.IdMarca = Convert.ToInt32(cmbEaMarca.SelectedValue);
            _art.Articulo.Precio = Convert.ToDecimal(txtbEaPrecio.Text);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtbCodigoEdt.Text))
            {
                MessageBox.Show("El campo Código no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbNombreEdt.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }

            if(!decimal.TryParse(txtbEaPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El campo Precio solo acepta numeros.");
                return false;
            }else if(precio <= 0)
            {
                MessageBox.Show("El campo Precio solo acepta numeros mayores a cero.");
                return false;
            }

            return true;
        }
    }
}
