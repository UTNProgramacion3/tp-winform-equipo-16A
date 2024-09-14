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
    public partial class frmListaMarcas : Form
    {

        Marca _marca;
        public frmListaMarcas()
        {
            InitializeComponent();
        }

        public frmListaMarcas(Marca m)
        {
            InitializeComponent();
            btnEditar.Text = "Eliminar";

            _marca = m;
        }

        private void frmListaMarcas_Load(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();

            dgvMarcas.DataSource = marcaManager.ObtenerTodos();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (_marca == null)
            {
                Marca marca;

                MarcaManager manager = new MarcaManager();


                marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                dgvMarcas.ClearSelection();


                frmEditarMarca ventanaEditar = new frmEditarMarca(marca);
                ventanaEditar.ShowDialog();

                //Actualizamos la lista de marcas
                dgvMarcas.DataSource = manager.ObtenerTodos();
            }
            else

            {
                
                MarcaManager manager = new MarcaManager();
                Marca marcaSelccionada;


                marcaSelccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                DialogResult resultado = MessageBox.Show("Estas seguro que deseas eliminar la Marca: " + marcaSelccionada.Descripcion, "Eliminar Marca", MessageBoxButtons.YesNo);

                if(resultado == DialogResult.Yes)
                {

                    manager.Eliminar(marcaSelccionada.Id);
                    MessageBox.Show("Marca eliminada correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha eliminado ninguna Marca");
                }
                
                //Actualizamos la lista de marcas
                dgvMarcas.DataSource = manager.ObtenerTodos();

            }
            

        }


    }
}
