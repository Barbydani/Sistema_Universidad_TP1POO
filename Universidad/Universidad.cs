using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Universidad
    {   /// <summary>
    /// Define variables de tipo List<T> 
    /// </summary>
        public List<Alumno> alumnos;
        public List<Beca> becas;
        public List<Cuota> cuotas;

        /// <summary>
        /// Constructor que se encarga de inicializar las listas en una nueva instancia de la clase.
        /// </summary>
        public Universidad() 
        { 
            alumnos= new List<Alumno>();
            becas= new List<Beca>();
            cuotas= new List<Cuota>();
        }

        #region Metodos
        /// <summary>
        /// Metodo añade un objeto del tipo alumno a una lista de alumnos existentes
        /// </summary>
        /// <param name="alumno">Se pasa un objeto alumno</param>
        public void AgregarAlumno(Alumno alumnoPa)
        {
            alumnos.Add(alumnoPa);
        }
        /// <summary>
        /// Agrega la beca a la lista de becas Grales y encuentra al alumno correspondiente y agrega la beca a su lista Becas. Esto permite asocias una beca con un alumno y realiza el seguimiento de las becas que tiene cada alumno en la Universidad
        /// </summary>
        /// <param name="becaPa"></param>
        ///
        public void AgregarBeca(Beca becaPa)
        {
            becas.Add(becaPa);
            Alumno alumno = alumnos.Find(x => x.Legajo == becaPa.Beneficiario.Legajo);
            alumno.becas.Add(becaPa);
        }

        /// <summary>
        /// Metodo añade un objeto del tipo cuota a una lista de cuotas existentes
        /// </summary>
        /// <param name="cuotaPa"></param>
        public void AgregarCuota(Cuota cuotaPa)
        {
            cuotas.Add(cuotaPa);
        }

        /// <summary>
        /// Es un metodo que  permite generar y registrar cuotas correspondientes a c/alumno de la universidad
        /// </summary>
        /// <param name="anioPa"></param>
        public void GenerarCuotas(int anioPa)
        {
            //Recorre la lista de alumno
            foreach(Alumno alumno in alumnos)
            {
                //genera cuotas mensuales para c/alum de un año especifico
                for(int mes = 1; mes <= 12; mes++)
                {
                    Cuota cuota = new Cuota();
                    cuota.Id = cuotas.Count + 1;
                    cuota.Anio = anioPa;
                    cuota.Mes = mes;
                    cuota.Valor = alumno.Cuota;
                    cuota.Alumno = alumno;
                    
                    //se busca si el alumno ya tiene una cuota registrada para ese mes y año utilizando metodo find en la lista cuotas
                    Cuota cuotaalumno = alumno.cuotas.Find(x => x.Mes== mes && x.Anio == anioPa);
                    if(cuotaalumno == null)
                    {
                        alumno.cuotas.Add(cuota);
                        cuotas.Add(cuota);
                    }
                }
            }
            MessageBox.Show("La cuota ha sido agregada a la lista");
        }

        /// <summary>
        /// busca una cuota en una lista, registra la fecha de pago actual 
        /// </summary>
        /// <param name="idPa"></param>
        public void PagarCuota(int idPa)
        { //manejo de excepciones con Try-catch
            try
            {
                //utilizo find para buscar la cuota cuyo Id coincida con el valor proporcionado en el parametro.
                Cuota cuota = cuotas.Find(x => x.Id == idPa);

                //verifica si la cuota fue pagada
                if(cuota.Fecha_Pago == null)
                {
                    cuota.Fecha_Pago = DateTime.Now;
                }
                else
                {
                    throw new Exception("La cuota ya ha sido pagada.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Métodos
    }
}
