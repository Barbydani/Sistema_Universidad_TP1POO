using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Cuota
    {
        #region Constructores
        
        public Cuota() 
        { 

        }

        /// <summary>
        /// /Permite crear una instancia de la clase cuota, establece los valores de las propiedades y mediante los parametros.
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="pmes"></param>
        /// <param name="aniop"></param>
        /// <param name="pvalor"></param>
        /// <param name="palumno"></param>
        public Cuota(int pid, int pmes, int aniop, decimal pvalor, Alumno palumno)
        {
           this.Alumno = palumno;
            this.Id = pid;
           this.Mes = pmes;
            this.Anio = aniop;
            this.Valor = pvalor;
        }

        public Cuota(Cuota cuota) : this(cuota.Id, cuota.Mes, cuota.Anio, cuota.Valor, cuota.Alumno)
        {

        }

        #endregion

        /// <summary>
        ///Define las propiedades ylas variables permiten acceder y manipular los datos
        /// </summary>
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public decimal Valor { get; set; }
        //al utilizar el signo "?" indica que la prop puede aceptar valores nulos
        public DateTime? Fecha_Pago { get; set; } 
        public Alumno Alumno;

        /// <summary>
        /// Este destructor se encarga de limpiar y liberar los recursos asociados a una instancia de la clase cuando esta destruida
        /// </summary>
        ~Cuota() 
        {
            this.Alumno = null;
            this.Id = 0;
            this.Mes = 0;
            this.Anio = 0;
            this.Valor = 0;
            this.Fecha_Pago = null;
        }
    }
}
