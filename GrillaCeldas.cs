using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOPrision
{
    public partial class GrillaCeldas : Form
    {

        public ISet<Celda> Celdas { get; set; } = new HashSet<Celda>();//conjunto de celdas con el que estoy trabajando
        public Celda Seleccionado { get { return DgvLista.CurrentRow?.DataBoundItem as Celda; } }//Retorna el registrto actualmente seleccionado en mi dvg. Current Row represneta la fila que contiene la celda actual(es decir si esta seleccionado algo retonar el objeto de esa fila)
        public Predicate<Celda> Filtro { get; set; } = r => true; // Recibe un parametro y retonar verdadero o falso dependiendo si lo acepto. Recibe la funcion r=> true , ( => indica que es una funcion lambda (o anonima)).Por defecto acepta todos. Predicado es Un funcion que toma un objeto y devuelve un boolean(verdadero o falso)
        public GrillaCeldas()
        {
            InitializeComponent();
            CbxEsMaximaSeguridad.SelectedIndex = 0;//  Muestra Todos
        }

        private void Filtrar()
        {
            DgvLista.DataSource = Celdas.ToList()
                .FindAll(Filtro) //Aplicamos 
                .FindAll(c => {
                    //Aplicamos el filtro de la ventana
                    switch (CbxEsMaximaSeguridad.SelectedIndex)
                    {
                        case 1://Maxima Seguridad
                            if (!c.EsMaximaSeguridad) return false;
                            break;

                        case 2: // Comun
                            if (c.EsMaximaSeguridad) return false;
                            break;
                    }


                    return true;
                });


        }


        public void Mostrar()
        {
            Filtrar();
            ShowDialog();

        }



        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;//Signifca que no hay nada seleeccionado
            FormularioCelda formulario = new FormularioCelda();
            formulario.Celda = Seleccionado;
            formulario.Mostrar(true);//mostramos solo para ver , no va a modificar nada

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormularioCelda formulario = new FormularioCelda();
            if (formulario.Mostrar())
                Celdas.Add(formulario.Celda);

            Filtrar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;//Signifca que no hay nada seleeccionado
            FormularioCelda formulario = new FormularioCelda();
            formulario.Celda = Seleccionado;
            formulario.Mostrar();
            Filtrar();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;//Signifca que no hay nada seleeccionado
            FormularioCelda formulario = new FormularioCelda();
            formulario.Celda = Seleccionado;
            if (formulario.Mostrar()) Celdas.Remove(formulario.Celda);
            Filtrar();
        }

        private void CbxEsMaximaSeguridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
