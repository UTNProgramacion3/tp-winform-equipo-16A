using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Business.Managers;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmEditarArticulo : Form
    {
        protected Articulo _art;
        protected MarcaManager _marcManager;
        protected CategoriaManager _catManager;
        protected ImagenManager _imgManager;
        protected List<Imagen> _imagenes;
        protected List<Categoria> _categorias;
        protected List<Marca> _marcas;

        private int currentIndex = 0;
        
        public frmEditarArticulo()
        { }
        public frmEditarArticulo(Articulo art = null)
        {
            InitializeComponent();
            if (art != null)
                _art = art;

            InitializeManagers();
        }

        private void InitializeManagers()
        {
            _marcManager = new MarcaManager();
            _catManager = new CategoriaManager();
            _imgManager = new ImagenManager();
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            if(_art != null)
            {
                CargarArticulo();
                CargarDropDowns();
                CargarImagenesArticulo();
            }
        }

        private void CargarArticulo()
        {
            txtbCodigoEdt.Text = _art.Codigo;
            txtbEaDescripcion.Text = _art.Descripcion;
            txtbNombreEdt.Text = _art.Nombre;
            txtbEaPrecio.Text = _art.Precio.ToString();

        }

        private void CargarDropDowns()
        {
                _categorias = _catManager.ObtenerTodos();
                cmbEaCategoria.DataSource = _categorias;
                cmbEaCategoria.DisplayMember = "Descripcion";
                cmbEaCategoria.ValueMember = "Id";
                cmbEaCategoria.SelectedValue = _art.IdCategoria > _categorias.Count ? 1 : _art.IdCategoria;


                _marcas = _marcManager.ObtenerTodos();
                cmbEaMarca.DataSource = _marcas;
                cmbEaMarca.DisplayMember = "Descripcion";
                cmbEaMarca.ValueMember = "Id";
                cmbEaMarca.SelectedValue = _art.IdCategoria > _categorias.Count ? 1 : _art.IdCategoria;

        }

        private void CargarImagenesArticulo()
        {
            if (_art != null)
            {
                _imagenes = _imgManager.ObtenerImagenesPorArticulo(_art.Id);
                string imagenUrl = _imagenes != null && _imagenes.Count > 0
                    ? _imagenes[0].ImagenUrl
                    : "https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminada-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg";

                CargarImagen(pcbEaArticulo, imagenUrl);
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

    }
}
