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
        private System.Windows.Forms.ComboBox cmbMarcas;
        public frmAgregarArticulo()
        {
            InitializeComponent();
            _marcaManager = new MarcaManager();
            CargarMarcas();
        }

        private void cmbAgrMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbMarcas.SelectedValue != null)
            //{
            //    int selectedMarcaId = (int)cmbMarcas.SelectedValue;
            //    string selectedMarcaDescripcion = cmbMarcas.Text;

            //    // Aquí puedes hacer algo con la marca seleccionada
            //    MessageBox.Show($"Marca seleccionada: {selectedMarcaDescripcion}, Id: {selectedMarcaId}");
            //}
        }

        private void CargarMarcas()
        {
            List<Marca> marcas = _marcaManager.ObtenerTodos();
            cmbAgrMarca.DataSource = marcas;
            cmbAgrMarca.DisplayMember = "Descripcion";
            cmbAgrMarca.ValueMember = "Id";
        }

        private void btnAgrSalirSinGuardar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
