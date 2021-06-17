using Design_Dashboard_Modern;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotelPensionados
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
            if (File.Exists("Estudiante.txt"))
            {
                Application.Run(new MenuHotel());
            }
            else
            {
                MessageBox.Show("No es posible realizar las votaciones porque no existen estudiantes cargados");
                Application.Exit();
            }
            
        }
    }
}
