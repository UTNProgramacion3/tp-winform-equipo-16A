using Business.Dtos;
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
        private readonly ArticuloManager _articuloManager;
        private ArticuloDTO _articulo;

        public frmAgregarArticulo()
        {
            InitializeComponent();

            _articulo = new ArticuloDTO()
            {
                Articulo = new Articulo(),
                Marca = new Marca(),
                Categoria = new Categoria()
            };
            _articuloManager = new ArticuloManager();
            _marcaManager = new MarcaManager();
            _categoriaManager = new CategoriaManager();
            CargarMarcas();
            CargarCategorias();
        }

        private void cmbAgrMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var marca = (Marca)cmbAgrMarca.SelectedItem;
            _articulo.Articulo.IdMarca = marca.Id;
        }

        private void cmbAgrCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoria = (Categoria)cmbAgrCategoria.SelectedItem;
            _articulo.Articulo.IdCategoria = categoria.Id;
        }

        private void btnAgrSalirSinGuardar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnAgrCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = dialog.FileName;
                pcbAgrArticulo.Image = Image.FromFile(rutaImagen);
            }
        }

        private void txtbAgrCodigo_TextChanged(object sender, EventArgs e)
        {
            var codigo = txtbAgrCodigo.Text;
            _articulo.Articulo.Codigo = codigo;
        }

        private void txtbAgrPrecio_TextChanged(object sender, EventArgs e)
        {
            _articulo.Articulo.Precio = Convert.ToDecimal(txtbAgrPrecio.Text);
        }

        private void txtbAgrDescripcion_TextChanged(object sender, EventArgs e)
        {
            var descripcion = txtbAgrDescripcion.Text;
            _articulo.Articulo.Descripcion = descripcion;
        }

        private void txtbAgrNombre_TextChanged(object sender, EventArgs e)
        {
            var nombre = txtbAgrNombre.Text;
            _articulo.Articulo.Nombre = nombre;
        }
        private void btnAgrCargarArticulo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                _articuloManager.Crear(_articulo);
                MessageBox.Show("Artículo agregado correctamente.");
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtbAgrCodigo.Text))
            {
                MessageBox.Show("El campo Código es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtbAgrNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtbAgrDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtbAgrPrecio.Text))
            {
                MessageBox.Show("El campo Precio es obligatorio.");
                return false;
            }
            if (cmbAgrMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Marca.");
                return false;
            }
            if (cmbAgrCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Categoría.");
                return false;
            }
            return true;
        }


    }
}
