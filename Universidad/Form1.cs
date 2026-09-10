using System.Text.RegularExpressions;
using System.Windows.Forms.Design;
using Universidad;

namespace Universidad
{
    public partial class Form1 : Form
    {
        //declaro una variable del tipo universidad
        Universidad universidad;

        public Form1()
        {
            //este metodo prepara la interfaz grafica y establece  config.iniciales
            InitializeComponent();
            //creo una nueva instancia de la clase
            universidad = new Universidad();
        }
        /// <summary>
        /// Se declara una lista de objetos, se agregan los elementos y se establece un valor inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ItemComboBox> items = new List<ItemComboBox>();
            items.Add(new ItemComboBox { Texto = "Alum.Ingresante", Value = "1" });
            items.Add(new ItemComboBox { Texto = "Alum.Grado", Value = "2" });
            items.Add(new ItemComboBox { Texto = "Alum.Posgrado", Value = "3" });

            txAnioCuotas.Text = " ";

            #region Formato de Grilla

            //En cada Grilla no se puede seleccionar mas de una grilla 
            dataGridViewAlumno.MultiSelect = false;
            dataGridViewAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewBeca.MultiSelect = false;
            dataGridViewBeca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewAlumnoBeca.MultiSelect = false;
            dataGridViewAlumnoBeca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCuotas.MultiSelect = false;
            dataGridViewCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            #endregion
        }
        /// <summary>
        /// Metodo para limpiar campos de entrada de datos
        /// relacionados con el alumno en el formulario
        /// </summary>
        private void ClearAlumno()
        {
            txNombre.Text = "";
            txApellido.Text = "";
            txDni.Text = "";
            txLegajo.Text = "";
            txCuotaAlumno.Text = "";

        }

        /// <summary>
        /// Metodo para limpiar campos de entrada de datos
        /// relacionados con el alumno en el formulario
        /// </summary>
        private void ClearBeca()
        {
            txCodigo.Text = "";
            txImporte.Text = "";
        }

        /// <summary>
        /// recorre la lista y muestra los resultados en la DGV
        /// </summary>
        private void MostarBecas()
        {
            //Limpia las filas para asegurar que las filas anteriores eliminen su contenido
            dataGridViewBeca.Rows.Clear();

            //iteracion sobre cada obj tipo beca
            foreach (Beca beca in universidad.becas)
            {
                //Se clona una fila del control DataGridView para crear una nueva fila en la que se mostrarán los datos de la beca actual.
                DataGridViewRow row = (DataGridViewRow)dataGridViewBeca.Rows[0].Clone();
                //se asigna los valores  a cada celda
                row.Cells[0].Value = beca.Codigo;
                row.Cells[1].Value = beca.Fecha_Otorgamiento;
                row.Cells[2].Value = beca.Importe;
                dataGridViewBeca.Rows.Add(row);
            }
        }

        /// <summary>
        /// recorre la lista y muestra los resultados en la DGV
        /// </summary>
        private void MostrarAlumnos()
        {
            //Limpia las filas para asegurar que las filas anteriores eliminen su contenido
            dataGridViewAlumno.Rows.Clear();
            //iteracion sobre cada obj tipo alumno
            foreach (Alumno alumno in universidad.alumnos)
            {
                //Se clona una fila del control DataGridView para crear una nueva fila en la que se mostrarán los datos de la alumno actual.
                DataGridViewRow row = (DataGridViewRow)dataGridViewAlumno.Rows[0].Clone();
                //se asigna los valores  a cada celda
                row.Cells[0].Value = alumno.Legajo;
                row.Cells[1].Value = alumno.Nombre;
                row.Cells[2].Value = alumno.Apellido;
                row.Cells[3].Value = alumno.Dni;
                //Ingrese la columna de Cuotas porque cuando ingresaba el monto en la siguiente grilla..
                //(para probar)algunas veces no recordaba el monto que habia colocado. 
                row.Cells[4].Value = alumno.Cuota;
                dataGridViewAlumno.Rows.Add(row);
            }
        }

        /// <summary>
        /// recorre la lista y muestra los resultados en la DGV
        /// </summary>
        private void MostrarBecasAlumno(Alumno alumno)
        {
            //Limpia las filas para asegurar que las filas anteriores eliminen su contenido
            dataGridViewAlumnoBeca.Rows.Clear();
            //iteracion sobre cada obj tipo alumno.becas
            foreach (Beca beca in alumno.becas)
            {
                //Se clona una fila del control DataGridView para crear una nueva fila en la que se mostrarán los datos de la alumno actual.
                DataGridViewRow row = (DataGridViewRow)dataGridViewAlumnoBeca.Rows[0].Clone();
                row.Cells[0].Value = beca.Codigo;
                row.Cells[1].Value = beca.Fecha_Otorgamiento;
                row.Cells[2].Value = beca.Importe;
                dataGridViewAlumnoBeca.Rows.Add(row);
            }
        }

        /// <summary>
        /// Este metodo perimite mostrar las cuotas del alumno junto con informacion adicional.
        /// </summary>
        /// <param name="alumno"></param>
        private void MostrarCuotasAlumno(Alumno alumno)
        {
            //Limpia las filas para asegurar que las filas anteriores eliminen su contenido
            dataGridViewCuotas.Rows.Clear();

            foreach (Cuota cuota in alumno.cuotas)
            {
                // Se clona una fila del control DataGridView para crear una nueva fila en la que se mostrarán los datos de la cuota actual.
                DataGridViewRow row = (DataGridViewRow)dataGridViewCuotas.Rows[0].Clone();

                //se asignan los valores a las celdas
                row.Cells[0].Value = cuota.Id;
                row.Cells[1].Value = cuota.Mes.ToString() + "/" + cuota.Anio.ToString();

                //Si la fecha de pago es nula, se asigna una cadena vacía; de lo contrario, se asigna la representación de cadena de la fecha de pago.
                row.Cells[2].Value = cuota.Fecha_Pago == null ? "" : cuota.Fecha_Pago.ToString();
                row.Cells[3].Value = cuota.Valor;

                decimal importebeca = 0;
                foreach (Beca beca in alumno.becas)
                {
                    importebeca += beca.Importe;
                }
                row.Cells[4].Value = importebeca;

                //:Se calcula el importe del beneficio para la cuota actual multiplicando el valor de la cuota por el beneficio obtenido del método.
                decimal importebeneficio = cuota.Valor * alumno.ObtenerBeneficio();

                row.Cells[5].Value = importebeneficio;

                row.Cells[6].Value = cuota.Valor - importebeca - importebeneficio;

                dataGridViewCuotas.Rows.Add(row);
            }
        }

        /// <summary>
        /// Este Evento se encarga de realizar el pafo de la cuota seleccionada, y actualiza información
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPagarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                //se verifica si al menos seleccione una fila
                if (dataGridViewCuotas.SelectedRows.Count >= 1)
                {
                    //Se extrae el valor del ID de la cuota de la celda en la columna 0 de la fila seleccionada
                    DataGridViewRow cuotaRow = dataGridViewCuotas.SelectedRows[0];

                    universidad.PagarCuota(Convert.ToInt32(cuotaRow.Cells[0].Value));
                    DataGridViewRow alumnoRow = dataGridViewAlumno.SelectedRows[0];
                    //busca el objeto alumno utilizando el valor del legajo de la fila 
                    Alumno alumno = universidad.alumnos.Find(x => x.Legajo == alumnoRow.Cells[0].Value);

                    MostrarBecasAlumno(alumno);
                    MostrarCuotasAlumno(alumno);
                }
                else
                {
                    throw new Exception("No se ha seleccionado ninguna cuota.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Este evento permite cargar los datos de un alumno seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btModificarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                //Se verifica si se ha seleccionado al menos una fila 
                if (dataGridViewAlumno.SelectedRows.Count > 0)
                {

                    DataGridViewRow alumnoRow = dataGridViewAlumno.SelectedRows[0];
                    Alumno alumno = universidad.alumnos.Find(x => x.Legajo == alumnoRow.Cells[0].Value);
                    txNombre.Text = alumno.Nombre;
                    txApellido.Text = alumno.Apellido;
                    txDni.Text = alumno.Dni;
                    txLegajo.Text = alumno.Legajo;
                    txCuotaAlumno.Text = alumno.Cuota.ToString();

                    if (alumno.GetType() == typeof(AlumnoIngresante))
                    {
                        rdiobAlmIngresante.Checked = Convert.ToBoolean("1"); ;

                    }
                    else
                    {
                        if (alumno.GetType() == typeof(AlumnoGrado))
                        {
                            rdiobAlumGrado.Checked = Convert.ToBoolean("2");

                        }
                        else
                        {
                            rdiobAlumPostGrado.Checked = Convert.ToBoolean("3");

                        }
                    }

                }
                else
                {
                    throw new Exception("Falta seleccionar un alumno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Permite generar cuotas para todos los alumnos en funcion del año ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearCuotas_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(txAnioCuotas.Text);
            universidad.GenerarCuotas(año);

        }

        /// <summary>
        /// Este evento permite cargar los datos del alumno en funcion a los valores ingresados en los controles de interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = txLegajo.Text;
                //Se verifica si ya existe un alumno en la universidad con el mismo legajo utilizando el método Find() en la lista  Si se encuentra un alumno con el mismo legajo, se lanza una excepción indicando que el legajo ya existe.
                Alumno alumnoRepetido = universidad.alumnos.Find(x => x.Legajo == legajo);
                if (alumnoRepetido != null)
                {
                    throw new Exception("El legajo ya existe.");
                }


                string nombre = txNombre.Text;
                string apellido = txApellido.Text;
                string dni = txDni.Text;
                decimal cuota = Convert.ToDecimal(txCuotaAlumno.Text);
                int tipo;
                Alumno alumno;

                //Se obtiene el tipo de alumno seleccionado a través de los controles RadioButton 
                if (rdiobAlmIngresante.Checked)
                { tipo = 1; }
                else if (rdiobAlumGrado.Checked)
                { tipo = 2; }
                else { tipo = 3; }

                switch (tipo)
                {
                    case 1:
                        alumno = new AlumnoIngresante(legajo, nombre, apellido, dni, cuota);
                        break;
                    case 2:
                        alumno = new AlumnoGrado(legajo, nombre, apellido, dni, cuota);
                        break;
                    default:
                        alumno = new AlumnoPostGrado(legajo, nombre, apellido, dni, cuota);
                        break;
                }

                universidad.AgregarAlumno(alumno);
                MostrarAlumnos();
                ClearAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Permite eliminar un alumno y tambien todas las cuotas y becas asociadas a ese alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            { //Se verifica si se ha seleccionado alguna fila
                if (dataGridViewAlumno.SelectedRows.Count > 0)
                {
                    DataGridViewRow alumnoRow = dataGridViewAlumno.SelectedRows[0];
                    Alumno alumno = universidad.alumnos.Find(x => x.Legajo == alumnoRow.Cells[0].Value);
                    alumno.cuotas.Clear();

                    //Dentro del bucle, se accede a cada beca utilizando la variable beca. Luego, se remueve esa beca de la lista utilizando el método Remove. Esto implica eliminar la beca de la lista, es decir, ya no estará disponible en la lista de becas de la universidad.
                    foreach (Beca beca in universidad.becas.FindAll(x => x.Beneficiario.Legajo == alumno.Legajo))
                    {
                        universidad.becas.Remove(beca);
                    }

                    //sucede lo mismo que en el bucle anterior
                    foreach (Cuota cuota in universidad.cuotas.FindAll(x => x.Alumno.Legajo == alumno.Legajo))
                    {
                        universidad.cuotas.Remove(cuota);
                    }
                    universidad.alumnos.Remove(alumno);
                    MostrarAlumnos();
                    MostarBecas();
                    dataGridViewCuotas.Rows.Clear();
                    dataGridViewAlumnoBeca.Rows.Clear();

                }
                else
                {
                    throw new Exception("Debe seleccionar un alumno.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Este evento agrega becas a un alumno, valida codigos, y si tiene un maximo de becas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptarBecas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAlumno.SelectedRows.Count == 0)
                {
                    throw new Exception(" No se ha seleccionado un Alumno. \n Seleccione una fila completa");
                }
                else
                {

                    DataGridViewRow alumnoRow = dataGridViewAlumno.SelectedRows[0];
                    Alumno alumno = universidad.alumnos.Find(x => x.Legajo == alumnoRow.Cells[0].Value);

                    //Se verifica si el alumno ya tiene dos becas asignadas. Si es así, se lanza una excepción indicando que el alumno ya tiene el máximo permitido de becas.

                    if (alumno.becas.Count > 1)
                    {
                        throw new Exception("El alumno ya tiene dos becas asignadas.");
                    }
                    //Se valida el código de la beca ingresado. Se verifica que no esté vacío y que cumpla con el patrón especificado: dos dígitos seguidos de dos letras (mayúsculas o minúsculas). Si el código no cumple con el patrón, se lanza una excepción indicando que el código no es válido.

                    string codigo = txCodigo.Text;
                    if (codigo == "")
                    {
                        throw new Exception("Código Vacio.");
                    }

                    string patron = @"^\d{2}[A-Za-z]{2}$";
                    bool codigovalido = Regex.IsMatch(codigo, patron);
                    if (!codigovalido)
                    {
                        throw new Exception("El codigo no es valido.");
                    }

                    Beca becarepetida = universidad.becas.Find(x => x.Codigo == codigo);
                    if (becarepetida != null)
                    {
                        throw new Exception("Existe una beca con el mismo codigo. \n Cambie de codigo");
                    }



                    decimal importetotal = 0;
                    foreach (Beca becas in alumno.becas)
                    {
                        importetotal += becas.Importe;
                    }
                    importetotal = importetotal + Convert.ToDecimal(txImporte.Text);
                    if (importetotal > alumno.Cuota)
                    {
                        throw new Exception("Las becas no pueden superar el 100% de la cuota.");
                    }

                    Beca beca = new Beca(codigo, DateTime.Now, Convert.ToDecimal(txImporte.Text), alumno);
                    universidad.AgregarBeca(beca);
                    MostarBecas();
                    ClearBeca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Este fragmento de codigo permite sincronizar la visualización de las becas y cuotas con el alumno seleccionado en el DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAlumno_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (dataGridViewAlumno.SelectedRows.Count > 0)
                {
                    //busca al alumno correspondiente en la lista de alumnos de la universidad utilizando el valor del legajo en la celda de la fila seleccionada

                    DataGridViewRow alumnoRow = dataGridViewAlumno.SelectedRows[0];
                    Alumno alumno = universidad.alumnos.Find(x => x.Legajo == alumnoRow.Cells[0].Value);
                    if (alumno == null)
                    {
                        throw new Exception("No se selecciono un alumno.");
                    }
                    MostrarBecasAlumno(alumno);
                    MostrarCuotasAlumno(alumno);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Esta clase se utiliza para representar un elemento de un ComboBox con dos propiedades
        /// </summary>
        public class ItemComboBox
        {
            public string Texto { get; set; }
            public string Value { get; set; }
        }
        private void dataGridViewAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //presione por error
        }
    }
}
