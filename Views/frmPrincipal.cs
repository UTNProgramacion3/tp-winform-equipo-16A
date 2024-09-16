using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business.Managers;
using Business.Dtos;
using Utils.Interfaces;
using Utils;
using System.Diagnostics;
using System.Globalization;

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
            CargarFiltroAvanzado();
        }

        private void CargarFiltroAvanzado()
        {
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        private void tlsNuevoArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmAgregarArticulo>();
        }

        private void tlsBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo ventana = new frmBuscarArticulo();
            ventana.ShowDialog();
        }

        private void tlsbCargarArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmAgregarArticulo>();
        }

        private void tlsbEditarArticulo_Click(object sender, EventArgs e)
        {
            OpenForm<frmEditarArticulo>();
        }

        private void tlsNuevoMarca_Click(object sender, EventArgs e)
        {
            OpenForm<frmAgregarMarca>();
        }

        private void tlsEditarMarca_Click(object sender, EventArgs e)
        {
            OpenForm<frmListaMarcas>();
        }

        private void OpenForm<T>(T entity = null) where T : Form, new()
        {
            T form = new T();
            form.ShowDialog();
        }

        private void CargarArticulos(DataGridView dataGridView, bool isFilter = false)
        {
            dataGridView.DataSource = null;
            RemoverColumnasEditaryEliminar();

            if (!isFilter)
            {
                _articulos = _artManager.ObtenerTodos();
            }
            dataGridView.DataSource = _mapper.MapFromDtoToTable(_articulos); // Cambiado a DataTable

            string rutaIconoEditar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\editar.png");
            string rutaIconoEliminar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Icons\eliminar.png");

            ConfigurarColumnas(dataGridView, rutaIconoEditar, rutaIconoEliminar);
        }

        private void RemoverColumnasEditaryEliminar()
        {
            if (dgvArticulos.Columns["Editar"] != null && dgvArticulos.Columns["Eliminar"] != null)
            {
                dgvArticulos.Columns.Remove("Editar");
                dgvArticulos.Columns.Remove("Eliminar");
            }
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

            if (dataGridView.Columns.Contains("Articulo_Codigo"))
            {
                dataGridView.Columns["Articulo_Codigo"].HeaderText = "Codigo";
            }

            if (dataGridView.Columns.Contains("Articulo_Nombre"))
            {
                dataGridView.Columns["Articulo_Nombre"].HeaderText = "Nombre";
            }

            if (dataGridView.Columns.Contains("Articulo_Descripcion"))
            {
                dataGridView.Columns["Articulo_Descripcion"].HeaderText = "Descripcion";
            }

            if (dataGridView.Columns.Contains("Articulo_Precio"))
            {
                dataGridView.Columns["Articulo_Precio"].HeaderText = "Precio";
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
                dataGridView.AllowUserToAddRows = false;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                CargarImagenArticulo();
            }
        }

        private void CargarImagenArticulo()
        {
            try
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
            catch (System.ArgumentOutOfRangeException)
            {
                CargarImagen(pbArticulo, _imagenes[0].ImagenUrl);
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

                        if (result == DialogResult.OK)
                        {
                            CargarArticulos(dgvArticulos);

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
                        CargarArticulos(dgvArticulos);
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

            OpenForm<frmAgregarCategoria>();
        }

        private void tlsEditarCategoria_Click(object sender, EventArgs e)
        {

            OpenForm<frmListaCategorias>();
        }

        private void tlsEliminarCategoria_Click(object sender, EventArgs e)
        {
            bool delete = true;

            frmListaCategorias ventana = new frmListaCategorias(delete);

            ventana.ShowDialog();
        }

        private void tlsLeeme_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/UTNProgramacion3/tp-winform-equipo-16A";

            try
            {

                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas con el readme: " + ex.Message.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opc = cboCampo.SelectedItem.ToString();

            if (opc == "Precio")
            {
                cboCondicion.Items.Clear();
                cboCondicion.Items.Add("Mayor a");
                cboCondicion.Items.Add("Menor a");
                cboCondicion.Items.Add("Igual a");

            }
            else
            {
                cboCondicion.Items.Clear();
                cboCondicion.Items.Add("Empieza con");
                cboCondicion.Items.Add("Termina por");
                cboCondicion.Items.Add("Igual a");

            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCampo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un campo para filtrar.");
                    return;
                }

                if (cboCondicion.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una condición.");
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string condicion = cboCondicion.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                bool eliminados = cbEliminados.Checked;

                if (campo == "Precio")
                {
                    if (string.IsNullOrEmpty(filtro))
                    {
                        CargarArticulos(dgvArticulos);
                        return;
                    }

                    // Usar CultureInfo para permitir formatos decimales según la cultura
                    if (!EsDecimal(filtro))
                    {
                        MessageBox.Show("El filtro para el campo 'Precio' debe ser un número decimal válido.");
                        CargarArticulos(dgvArticulos);
                        return;
                    }

                    // Intentar convertir el filtro a decimal
                    filtro = ConvertirDecimal(filtro);
                }

                _articulos = _artManager.Filtrar(campo, condicion, filtro, eliminados);
                CargarArticulos(dgvArticulos, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private bool EsDecimal(string valor)
        {
            return decimal.TryParse(valor, NumberStyles.Number, CultureInfo.InvariantCulture, out _);
        }

        private string ConvertirDecimal(string valor)
        {
            if (decimal.TryParse(valor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal resultado))
            {
                return resultado.ToString(CultureInfo.InvariantCulture);
            }
            return valor; 
        }
    }
}
