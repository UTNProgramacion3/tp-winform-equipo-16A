using Business.Managers;
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

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmEditarMarca : Form
    {
        public frmEditarMarca()
        {
            InitializeComponent();
        }

        private void frmEditarMarca_Load(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();

            dgvMarcas.DataSource = marcaManager.ObtenerTodos();

            try
            {   
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se editar las marcas");
                throw ex;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Marca marca;

            marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;  

            frmAgregarMarca ventana = new frmAgregarMarca(marca);


            ventana.ShowDialog();
        }
    }
}
