using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPrision
{
    static class Program
    {

        public static ISet<Celda> Celdas = new HashSet<Celda>();
        public static ISet<Recluso> Reclusos = new HashSet<Recluso>();//Conjunto Global de Reclusos
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
