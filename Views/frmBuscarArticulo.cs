using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Dtos;
using Business.Managers;
using Domain.Entities;
using Utils;
using Utils.Interfaces;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmBuscarArticulo : Form
    {

        Mapper<ArticuloDTO> _mapper = new Mapper<ArticuloDTO>();
        ArticuloManager _manager = new ArticuloManager();
        List<ArticuloDTO> _list = new List<ArticuloDTO>();
        public frmBuscarArticulo()
        {
            InitializeComponent();
            _list = _manager.ObtenerTodos();
        }

        private void frmBuscarArticulo_Load(object sender, EventArgs e)
        {
            
            ///Fixea el problema que genera una row adicional
            dgvBaListadoArticulos.AllowUserToAddRows = false;

            dgvBaListadoArticulos.DataSource = _mapper.MapFromDtoToTable(_list);

            ConfigurarColumnas(dgvBaListadoArticulos);

        }
    
        private void ConfigurarColumnas(DataGridView dataGridView)
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

    }

        private void btnBaAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbCodigoBa_TextChanged(object sender, EventArgs e)
        {
            List<ArticuloDTO> listaFiltrada;

            string filter = txtbCodigoBa.Text;

            if (filter != "")
            {
                listaFiltrada = _list.FindAll(item => item.Articulo.Codigo.ToString().ToUpper().Contains(filter.ToUpper()));
            }
            else
            {
                listaFiltrada = _list;
            }

            dgvBaListadoArticulos.AllowUserToAddRows = false;
            dgvBaListadoArticulos.DataSource = _mapper.MapFromDtoToTable(listaFiltrada);
            ConfigurarColumnas(dgvBaListadoArticulos);
        }
    }

}
