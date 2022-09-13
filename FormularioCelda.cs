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
    public partial class FormularioCelda : Form
    {
        public Celda Celda { get; set; }
        private Recluso Seleccionado { get { return DgvReclusos.CurrentRow?.DataBoundItem as Recluso; } }// Es el recluso que tengo seleccionado de la lista de reclusos.

        /// <summary>
        /// Reclusos de Formulario
        /// </summary>
        /// El conjunto temporal es un ensayo de los movimientos de los reclusos en la celda
        private ISet<Recluso> Temporal;//Vamos a manejar un conjunto temporal para no afectar directamente los reclusos que estan en la celda. Porque en caso de cancelar no queremos que se altere el conjunto de reclusos de la celda.Copia de los reclusos que estan en la celda.
        private bool Ver = false;
        private bool Nuevo = true;
        private bool Acepta = false;


        public FormularioCelda()
        {
            InitializeComponent();
        }

        public bool Mostrar(bool ver = false)// si llamo a mostrar vacio, solo lo llamo para ver no para modificar ni agregar
        {
            Ver = ver;
            Nuevo = (Celda == null);// esto significa que estoy por agregar una nueva celda.
            if (!Nuevo)//En caso de que quiera ver, modificar o borrar una celda. Si es alguno de estos 3 casos muestro los datos de la celda.
            {

                NudNumero.Value = Celda.Numero;
                NudCapacidad.Value = Celda.Capacidad;
                ChkEsMaximaSeguridad.Checked = Celda.EsMaximaSeguridad;
                
                Temporal = Celda.ObtenerReclusos();// ME va a mostrar el conjunto copia que me retonar la celda.
            }
            else
            {
                //Crea un conjunto temporal
                Temporal = new HashSet<Recluso>();
            }
            DgvReclusos.DataSource = Temporal.ToList();
            ShowDialog();
            return Acepta;
        }



        //Agregar reclusos a la celda
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            GrillaReclusos grilla = new GrillaReclusos();
            //temporal sirve para no afectar directamente al conjunto de reclusos de la celda
            //La condicion para que s muestre un recluso en esta grilla de reclusos es que no este en el conjunto temporal ni este en una celda. r tal que no este en el conjunto temporal ni que el recluso este en una celda
            grilla.Reclusos = Program.Reclusos.ToList().FindAll(r => !Temporal.Contains(r) && r.EstaenCelda()==0).ToHashSet();//Find all filtra todos los reclusos que ya estan en la lista temporal, ToList funciona con FInd all, r es una funcionan anonima que recibe una variable r y retorna un booleano(verdadero o falso ) depenmdiendo si se lo quiere incluir en el filtro).Solo voy a poder seleccionar los reclusos que no esten en ninguna celda
            grilla.Mostrar();
            if (grilla.Selecciona) Temporal.Add(grilla.Seleccionado);//Agregamos a la lista temporal un recluso que seleccionamos de la grilla de reclusos
            DgvReclusos.DataSource = Temporal.ToList();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;
            Temporal.Remove(Seleccionado);
            DgvReclusos.DataSource = Temporal.ToList();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if(Ver)//Si es ver no realiza nada ,s olo permite ver 
            {
                Close();
                return;
            }
            Acepta = true;
            int.TryParse(NudCapacidad.Value.ToString(), out int disponibles);
            if(Nuevo)// si es nuevo creamos la celda, ya que maxima seguridad y capacidad solo se pueden modificar cando creamos una celda, esto es para evitar que modifiquemso el contenido de una celda una vez ya creada, por ejemplo si por eror quiero modificar una celda ya creada esto lo evita
            {
                Celda = new Celda(disponibles, ChkEsMaximaSeguridad.Checked);
            }
            else
            {
                
                disponibles = Celda.Capacidad; // Esto indica la capacidad que tengo disponible

            }
            //Primero quitamos los reclusos que se quitaron del  conjunto temporal . Recorremos los reclusos de la celda y los vamos sacando si no estan en temporal
            foreach (Recluso recluso in Celda.ObtenerReclusos())
            {
                //Si existe el recluso en el conjunto temporal, no lo quitamos de la celda
                if (Temporal.Contains(recluso)) continue;
                //Si no existe el recluso en el conjunto temporal , lo quitamos de la celda.
                Celda.QuitarRecluso(recluso);

            }


            //Recorro el temporal para ir agragando los reclusos a la celda
            foreach (Recluso recluso in Temporal)
            {
                //Alcanzo la capacidad disponible en la celda
                if (disponibles <= 0) break;//si alcanzo la capacidad ddisponible de la celda termina


                //Si agrega correctamente al recluso, la capacidad disponible disminuye.
                if (Celda.AgregarRecluso(recluso)) disponibles--;
            }
            //Agregamos al conjunto general todos los reclusos que se agregaron a la celda
            foreach (Recluso recluso in Celda.ObtenerReclusos())
            {
                Program.Reclusos.Add(recluso);

            }
                Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
