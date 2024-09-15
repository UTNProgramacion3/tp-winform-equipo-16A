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
            ConfigurarBotones();
        }

        private void cmbAgrMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAgrMarca.SelectedIndex == -1)
            {
                return;
            }
            var marca = (Marca)cmbAgrMarca.SelectedItem;
            _articulo.Articulo.IdMarca = marca.Id;
        }

        private void cmbAgrCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAgrCategoria.SelectedIndex == -1)
            {
                return;
            }
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
            cmbAgrMarca.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = _categoriaManager.ObtenerTodos();
            cmbAgrCategoria.DataSource = categorias;
            cmbAgrCategoria.DisplayMember = "Descripcion";
            cmbAgrCategoria.ValueMember = "Id";
            cmbAgrCategoria.SelectedIndex = -1;
        }

        private void btnAgrCargarImagen_Click(object sender, EventArgs e)
        {
                try
                {
                if(urlTextBox.Text != "")
                {
                    var request = System.Net.WebRequest.Create(urlTextBox.Text);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pcbAgrArticulo.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una URL.");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen desde la URL: " + ex.Message);
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
            List<string> camposVacios = new List<string>();
            if (string.IsNullOrEmpty(txtbAgrCodigo.Text))
            {
                camposVacios.Add("Código");
            }
            if (string.IsNullOrEmpty(txtbAgrNombre.Text))
            {
                camposVacios.Add("Nombre");
            }
            if (string.IsNullOrEmpty(txtbAgrDescripcion.Text))
            {
                camposVacios.Add("Descripción");
            }
            if (string.IsNullOrEmpty(txtbAgrPrecio.Text))
            {
                camposVacios.Add("Precio");
            }
            if (cmbAgrMarca.SelectedIndex == -1)
            {
                camposVacios.Add("Marca");
            }
            if (cmbAgrCategoria.SelectedIndex == -1)
            {
                camposVacios.Add("Categoría");
            }

            if (camposVacios.Count > 0)
            {
                MessageBox.Show("Los siguientes campos son obligatorios: " + string.Join(", ", camposVacios));
                return false;
            }
            return true;
        }

        private void pcbAgrArticulo_Click(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            btnAgrCargarImagen.Enabled = urlTextBox.Text != "";
        }

        private void ConfigurarBotones()
        {
            btnAgrCargarImagen.Enabled = false;
        }

        private void txtbAgrPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                //Acá evitamos que puedan poner más de un '.'
                e.Handled = true; 
            }
        }
    }
}
