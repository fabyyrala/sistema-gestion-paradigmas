using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPrision
{
    public class Recluso
    {
        public string Nombre { get; set; }
        public char Sexo { get; set; }
        public string Descripcion { get; set; }

        public int EstaenCelda()//Me dice en que celda esta actualmente el recluso
        {
            foreach (Celda celda in Program.Celdas)// va a buscar en la lista general de celdas la ubicacion del recluso. Program.Celdas es mi conjunto general de Celdas.
            {
                if (celda.TieneRecluso(this)) return celda.Numero;//En cada celda pregunta con this si yo(recluso) estoy en la celda.
                
            }

            return 0;//Si retorna cero es porque no esta en la celda
        }


    }
}
