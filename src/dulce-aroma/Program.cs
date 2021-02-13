using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dulce_aroma
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Para cerrar el proceso contaremos los forms abiertos y validaremos.
            LoginForm main = new LoginForm();
            //NewConsultForm main = new NewConsultForm();
            main.FormClosed += MainForm_Closed;
            main.Show(); // Inicio del form principal manualmente.
            Application.Run(); // Quitamos el arranque del form al iniciar proyecto.
        }
        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
