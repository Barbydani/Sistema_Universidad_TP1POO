using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    /// <summary>
    /// Esta subclase deriva de la clase alumno
    /// hereda todas las propiedades, metodos.
    /// </summary>
    public class AlumnoPostGrado : Alumno
    {
        public AlumnoPostGrado(string legajoPa, string nombrePa, string apellidoPa, string dniPa, decimal cuotaPa) : base(legajoPa, nombrePa, apellidoPa, dniPa, cuotaPa)
        {

        }
        /// <summary>
        /// Este metodo es una implementacion sobre escrita de un metodo definido por una clase base
        /// </summary>
        /// <returns> devuelve un valor decimal</returns>
        public override decimal ObtenerBeneficio()
        {
            
            return 0.01M;
        }
    }
}
