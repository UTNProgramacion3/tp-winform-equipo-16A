using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_16A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tlsAgregarArt_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventana = new frmAgregarArticulo();

            ventana.ShowDialog();
        }
    }
}
