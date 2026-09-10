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
    public class AlumnoGrado : Alumno
    {
        public AlumnoGrado(string legajo, string nombre, string apellido, string dni, decimal cuota) : base(legajo, nombre, apellido, dni, cuota)
        {

        }
        /// <summary>
        /// Este metodo es una implementacion sobre escrita de un metodo definido por una clase base
        /// </summary>
        /// <returns> devuelve un valor decimal</returns>
        public override decimal ObtenerBeneficio()
        {
            return 0.05M;
        }
    }
}
