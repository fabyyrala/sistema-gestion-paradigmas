using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPrision
{
   public class Celda
    {
        public int Numero { get { return GetHashCode(); } }//HashCode un identificador univoco del objeto . Por defecto es la direccion de memoria del objeto 
        public int Capacidad { get; private set; } // Solo se asigna cuando creo la celda
        public bool EsMaximaSeguridad { get; private set; } // Solo lo asigna cuando crea la celda
        public Celda(int capacidad, bool esMaximaSeguridad)
        {
            Capacidad = capacidad;
            EsMaximaSeguridad = esMaximaSeguridad;
        }
        /// <summary>
        /// Conjunto de Reclusos Actualmente en la celda.  Iset no permite repetir elementos
        /// </summary>
        private readonly ISet<Recluso> Reclusos = new HashSet<Recluso>();//COnjunto de Reclusos actualmente en la celda // EN el set no se pueden repertir los elementos, si un elemento ya esta no lo agrega.Readonly para que no se puede cambiar la instancia de la variable//Hashset utiliza el hashcode para determinar la igualdad de los elementos
        /// <summary>
        /// Agrega recluso a la celda cargo el conjunto de reclusos.
        /// </summary>
        /// <param name="recluso"</param>
        /// <returns></returns>
        public bool AgregarRecluso(Recluso recluso)
        {
            if (Reclusos.Count == Capacidad) return false;// Si Reclusos.Count == capacida damos falso porque esta llena la capacidad. Count cuenta la cantidad de objetos que tengo en el iset

           return !Reclusos.Add(recluso);//Lo negamos porque devuelve true cuando se pudo agregar el recluso y faklse en caso contrario..Retornamos el valor contrario de ADD. Add del Iset Retorna falso cuando si se pudo agregar
            
  
        }

        /// <summary>
        /// Consulta si el <param name="recluso"/> esta en la celda
        /// </summary>
        /// <param name="recluso">Recluso que se quiere averiguar si esta actualmente en la celda</param>
        /// <returns>True si esta en la celda , false en caso contrario</returns>
        public bool TieneRecluso(Recluso recluso)
        {
            return Reclusos.Contains(recluso);//Contains recorre el conjunto y va comparando los objetos con el recluso que le pasamos por parametro.
        }


        /// <summary>
        /// Quita recluso de celda
        /// </summary>
        /// <param name="recluso">Recluso que se quiere quitar</param>
        /// <returns>True si se pudo quitar el recluso, false en caso contrario</returns>
        public bool QuitarRecluso(Recluso recluso)
        {
           
           return Reclusos.Remove(recluso);
          
        }


        /// <summary>
        /// Obtiene la cantidad de reclusos actualmente en la celda
        /// </summary>
        /// <returns>Cantidad de Reclusos Actualmente en la Celda</returns>
        public int CantidadReclusos()
        {
            return Reclusos.Count;
        }

        /// <summary>
        /// Obtenemos un conjunto de Reclusos actualmente en la celda
        /// </summary>
        /// <returns>Conjunto de reclusos actualmente en la celda</returns>
        public ISet<Recluso> ObtenerReclusos()
        {

            // como tenemos que controlar la capacidad de nuestro conjunto de reclusos, le retornamos un nuevo conjunto de reclusos con una copia de la referencia de los reclusos actualmente en esta celda.Esto evita que se altere mi conjunto de reclusos.
            return new HashSet<Recluso>(Reclusos); //

        }


    }
}
