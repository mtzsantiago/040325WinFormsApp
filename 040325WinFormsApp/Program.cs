using System;
using System.Windows.Forms;
using _040325WinFormsApp;

namespace _040325WinFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Establece la configuración para la aplicación de Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa el formulario principal (Form1)
            Application.Run(new Form1());
        }
    }
}
