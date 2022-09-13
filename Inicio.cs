using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPrision
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void celdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaCeldas grilla = new GrillaCeldas();
            grilla.Celdas = Program.Celdas;
            grilla.Mostrar();
        }

        private void reclusosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaReclusos grilla = new GrillaReclusos();
            grilla.Reclusos = Program.Reclusos;
            grilla.Mostrar();
        }
    }
}
