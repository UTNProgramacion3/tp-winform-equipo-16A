﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_16A.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlsNuevoArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventanaArticulo = new frmAgregarArticulo();
            ventanaArticulo.ShowDialog();
        }
    }
}
