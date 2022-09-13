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
    public partial class GrillaReclusos : Form
    {
        public ISet<Recluso> Reclusos { get; set; } = new HashSet<Recluso>();
        public Recluso Seleccionado { get { return DgvLista.CurrentRow?.DataBoundItem as Recluso; } }//Retorna el registrto actualmente seleccionado en mi dvg. Current Row represneta la fila que contiene la celda actual(es decir si esta seleccionado algo retonar el objeto de esa fila)
        public bool Selecciona { get; private set; } = false;

        public Predicate<Recluso> Filtro { get; set; } = r => true; // Recibe un parametro y retonar verdadero o falso dependiendo si lo acepto. Recibe la funcion r=> true , ( => indica que es una funcion lambda (o anonima)).Por defecto acepta todos. Predicado es Un funcion que toma un objeto y devuelve un boolean(verdadero o falso)



        public GrillaReclusos()
        {
            InitializeComponent();
        }

        private void Filtrar()
        {
            DgvLista.DataSource = Reclusos.ToList()
                .FindAll(Filtro) //Aplicamos 
                .FindAll(r =>{
                    //Aplicamos el filtro de la ventana
                    
                    if (!TxtFiltro.Text.Equals(""))
                    {
                        
                        //LO aceptamos solo si el nombre contiene el texto ingresado en el filtro ( ToLower para ignorar mayusculas/minusculas)
                       if (r.Nombre.ToLower().Contains(TxtFiltro.Text.ToLower())) return true;
                       // LO aceptamos si la descripcion contiene el texto ingresado en el filtro(ToLower para ignoarar mayusculas/minusculas)
                        if (r.Descripcion.ToLower().Contains(TxtFiltro.Text.ToLower())) return true;
                        return false;
                    }
                    return true;
                });
            

        }

        public void Mostrar()
        {

            Filtrar();
            ShowDialog();
        }


        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            Selecciona = (Seleccionado !=null);//!=null selecciona solo si esta algo clickeado es decir seleccionado
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormularioRecluso formulario = new FormularioRecluso();//Aca creo el formulario
            if (formulario.Mostrar())
                Reclusos.Add(formulario.Recluso);

            Filtrar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;//Signifca que no hay nada seleeccionado
            FormularioRecluso formulario = new FormularioRecluso();
            formulario.Recluso = Seleccionado;// Le asigna recluso con seleccionado siempre que haya elegido un recluso de la lista
            formulario.Mostrar();

            Filtrar();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;//Signifca que no hay nada seleeccionado
            FormularioRecluso formulario = new FormularioRecluso();
            formulario.Recluso = Seleccionado;
            if (formulario.Mostrar()) Reclusos.Remove(formulario.Recluso);

            Filtrar();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;//Signifca que no hay nada seleeccionado
            FormularioRecluso formulario = new FormularioRecluso();
            formulario.Recluso = Seleccionado;
            formulario.Mostrar(true);
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
