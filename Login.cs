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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
           
            LblMensaje.ForeColor = Color.Red;
            LblMensaje.Text = "";

            if (TxtUsuario.Text.Equals(""))
            {
                LblMensaje.Text = "Debe Ingresar un Usuario";
               
                return;
            }

            if (TxtContraseña.Text.Equals(""))
            {
                LblMensaje.Text = "Debe Ingresar una Contraseña";
                
                return;
            }

                LblMensaje.Text = "El usuario o clave ingresado es incorrecto";

            switch (TxtUsuario.Text)
            {
                case "Comisario":
                    if(!TxtContraseña.Text.Equals("Com123")) return;
  
                    break;

                case "Oficial":
                    if(!TxtContraseña.Text.Equals("Ofi456"))return;
                    break;
                default:
                    
                    return;
                    
            }

            LblMensaje.ForeColor = Color.Green;
            LblMensaje.Text = "Bienvenido " + TxtUsuario.Text;

             new Inicio().ShowDialog();

            LblMensaje.Text = "";
            TxtContraseña.Text = "";
            
        }
    }
}
