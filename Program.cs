using Business.Managers;
using System;
using System.Windows.Forms;
using TPWinForm_equipo_16A.Views;

namespace TPWinForm_equipo_16A
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());

        }
    }
}
