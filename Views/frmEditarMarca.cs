using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Managers;
using Domain.Entities;

namespace TPWinForm_equipo_16A.Views
{
    public partial class frmEditarMarca : Form
    {
        Marca _marca = new Marca();
        
        public frmEditarMarca(Marca ma)
        {
            InitializeComponent();
            _marca = ma;
        }

        private void frmEditarMarca_Load(object sender, EventArgs e)
        {
            txtbDescripcionAnterior.Text = _marca.descripcion;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaManager manager = new MarcaManager();
            
            //Le asignamos el valor del nuevo nombre de Marca tomado del txtBox
            _marca.descripcion = txtbNuevaDescripcion.Text;

            manager.Update(_marca);
            Close();
        }
    }
}
