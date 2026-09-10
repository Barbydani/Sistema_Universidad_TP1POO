using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Beca
    {
        #region Constructores

        public Beca() { }
        /// <summary>
        /// Constructor que permite crear una instancia y establece los valores iniciales de sus propiedades
        /// </summary>
        /// <param name="pcodigo"></param>
        /// <param name="pfecha_otorgamiento"></param>
        /// <param name="pimporte"></param>
        /// <param name="pbeneficiario"></param>
        public Beca(string pcodigo, DateTime pfecha_otorgamiento, decimal pimporte, Alumno pbeneficiario)
        {
            this.Importe = pimporte;
            this.Codigo = pcodigo;
            this.Beneficiario = pbeneficiario;
            this.Fecha_Otorgamiento = pfecha_otorgamiento;
        }

        public Beca(Beca beca) :this(beca.Codigo, beca.Fecha_Otorgamiento, beca.Importe, beca.Beneficiario) 
        {
        
        }
         #endregion


        /// <summary>
        /// Definen las propiedades de la clase Beca
        /// </summary>
        public decimal Importe { get; set; }
        public string Codigo { get; set; }

        public Alumno Beneficiario;// se declara una variable beneficiario del tipo Alumno
        public DateTime Fecha_Otorgamiento { get; set; }

        /// <summary>
        /// Este metodo es una implementacion sobre escrita de un metodo definido por una clase base
        /// </summary>
        /// <returns> devuelve un valor decimal</returns>
        ~Beca() 
        {
            this.Codigo = null;
            this.Importe = 0;
            this.Beneficiario = null;
            this.Fecha_Otorgamiento = new DateTime();
        }
    }
}
