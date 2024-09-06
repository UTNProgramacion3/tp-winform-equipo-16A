using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace TPWinForm_16A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (DBManager servicio = new DBManager())
            {
                try
                {
                    servicio.OpenConnection();

                    DataTable tabla = servicio.ExecuteQuery("Select Nombre From ARTICULOS where Id = 1");

                    var row = tabla.Rows[0];

                    label.Text = row["Nombre"].ToString();

                }catch(Exception ex)
                {
                    throw;
                }
                finally
                {
                    servicio.CloseConnection();
                }


            }
        }
    }
}
