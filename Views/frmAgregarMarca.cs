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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();
            Marca obj = new Marca();

            obj.Descripcion = txtbDescripcion.Text;

            marcaManager.Crear(obj);
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {

        }
    }
    
}
