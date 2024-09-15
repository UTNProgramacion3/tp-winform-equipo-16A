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
            _marcaManager = new MarcaManager();
            _categoriaManager = new CategoriaManager();
            CargarMarcas();
            CargarCategorias();

            _articulo = new ArticuloDTO()
            {
                Articulo = new Articulo(),
                Marca = new Marca(),
                Categoria = new Categoria()
            };

        }

        private void cmbAgrMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbAgrCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnAgrCargarArticulo_Click(object sender, EventArgs e)
        {

            //Me queda añadir validación del form y
            //completar ArticuloDto directamente en _variable
            if (true)
            {
                _articulo.Articulo.Codigo = txtAgrCodigo.Text;
                _articulo.Articulo.Nombre = txtAgrNombre.Text;
                _articulo.Articulo.Descripcion = txtAgrDescripcion.Text;
                _articulo.Articulo.Precio = Convert.ToDecimal(txtAgrPrecio.Text);
                _articulo.Marca.Id= (int)cmbAgrMarca.SelectedValue;
                _articulo.Categoria.Id= (int)cmbAgrCategoria.SelectedValue;

                _articuloManager.Crear(_articulo);
                MessageBox.Show("Artículo agregado correctamente.");
                this.Close();
            }
        }

        private void txtbAgrCodigo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
