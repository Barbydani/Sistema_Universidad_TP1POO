using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    /// <summary>
    /// Es una clase base para otras clases.
    /// Las clases que hereden de alumno  deben  proporcionar implementaciones concretas para los miembros abstractos definidos en la clase base.
    /// </summary>
    public abstract class Alumno
    {
        /// <summary>
        /// Define variables de tipo List<T> 
        /// </summary>
        public List<Beca> becas;
        public List<Cuota> cuotas;

        #region Constructores

        //Constructor simple
        public Alumno() 
        {  
            becas= new List<Beca>();
            cuotas= new List<Cuota>();
        }
        /// <summary>
        /// Permite crear una instacia de la clase alumno y establece los valores
        /// inicializa listas 
        /// </summary>
        /// <param name="plegajo"></param>
        /// <param name="pnombre"></param>
        /// <param name="papellido"></param>
        /// <param name="pdni"></param>
        /// <param name="pcuota"></param>
        public Alumno(string plegajo, string pnombre, string papellido, string pdni, decimal pcuota) 
        {
            this.Nombre = pnombre;
            this.Apellido = papellido;
            this.Dni =pdni;
            this.Legajo = plegajo;
             this.Cuota = pcuota;

            becas = new List<Beca>();
            cuotas = new List<Cuota>();
        }
        /// <summary>
        /// Constructor que se recibe un objeto del tipo Alumno, y se llama a si mismo
        /// </summary>
        /// <param name="alumno"></param>
        public Alumno(Alumno alumno) : this(alumno.Legajo, alumno.Nombre, alumno.Apellido, alumno.Dni, alumno.Cuota)
        {

        }
        #endregion

        /// <summary>
        /// Propiedades
        /// </summary>
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Legajo { get; set; }
        public decimal Cuota { get; set; }

        /// <summary>
        /// Este metodo es una implementacion sobre escrita de un metodo definido por una clase base
        /// </summary>
        /// <returns> devuelve un valor decimal</returns>
        ~Alumno()
        {
            this.Nombre  = null;
            this.Apellido = null;
            this.Dni = null;
            this.Legajo = null;
           
            this.becas = new List<Beca>();
            this.cuotas = new List<Cuota>();
        }

        /// <summary>
        /// Este metodo es una implementacion sobre escrita de un metodo definido por una clase base
        /// </summary>
        /// <returns> devuelve un valor decimal</returns>
        public abstract decimal ObtenerBeneficio();
    }
}
