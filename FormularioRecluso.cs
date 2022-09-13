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
    public partial class FormularioRecluso : Form
    {
        public Recluso Recluso { get; set; } = new Recluso();
        private bool Ver = true;
        private bool Acepta = false;

        public FormularioRecluso()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Esta funcion muestra el formulario y retorna true cuando se confirman los cambios.
        /// </summary>
        /// <returns>True cuando se confirman los cambios, false en caso de descarte</returns>
        public bool Mostrar( bool ver = false)
        {
            Ver = ver;
            TxtNombre.Text = Recluso.Nombre;
            TxtDescripcion.Text = Recluso.Descripcion;
            CbxSexo.SelectedIndex = 0;
            if (Recluso.Sexo == 'F') CbxSexo.SelectedIndex = 1;
            NudEstaEnCelda.Value = Recluso.EstaenCelda();
            ShowDialog();
            return Acepta;

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if(Ver)
            {
                Close();
                return;
            }


            Recluso.Nombre = TxtNombre.Text;
            Recluso.Descripcion = TxtDescripcion.Text;
            if (CbxSexo.SelectedIndex == 1) Recluso.Sexo = 'F';
            else Recluso.Sexo = 'M';
            Acepta = true;
            Close();
        }
    }
}
