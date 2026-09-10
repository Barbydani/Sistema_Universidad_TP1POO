namespace Universidad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            txLegajo = new TextBox();
            txNombre = new TextBox();
            txApellido = new TextBox();
            txDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewAlumno = new DataGridView();
            Legajo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            valorCuota = new DataGridViewTextBoxColumn();
            txCodigo = new TextBox();
            label5 = new Label();
            txImporte = new TextBox();
            label6 = new Label();
            dataGridViewBeca = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txAnioCuotas = new TextBox();
            dataGridViewAlumnoBeca = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            dataGridViewCuotas = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            FechaPago = new DataGridViewTextBoxColumn();
            ImporteCuota = new DataGridViewTextBoxColumn();
            ImporteBeca = new DataGridViewTextBoxColumn();
            Beneficio = new DataGridViewTextBoxColumn();
            NetoaPagar = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btPagarCuota = new Button();
            txCuotaAlumno = new TextBox();
            btModificarAlumno = new Button();
            btnCrearCuotas = new Button();
            label9 = new Label();
            label8 = new Label();
            rdiobAlmIngresante = new RadioButton();
            rdiobAlumGrado = new RadioButton();
            rdiobAlumPostGrado = new RadioButton();
            gboxOpciones = new GroupBox();
            btnCargarDatos = new Button();
            btnEliminar = new Button();
            btnAceptarBecas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnoBeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).BeginInit();
            gboxOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // txLegajo
            // 
            txLegajo.Location = new Point(101, 32);
            txLegajo.Margin = new Padding(3, 2, 3, 2);
            txLegajo.Name = "txLegajo";
            txLegajo.Size = new Size(110, 23);
            txLegajo.TabIndex = 0;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(282, 32);
            txNombre.Margin = new Padding(3, 2, 3, 2);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(110, 23);
            txNombre.TabIndex = 1;
            // 
            // txApellido
            // 
            txApellido.Location = new Point(282, 59);
            txApellido.Margin = new Padding(3, 2, 3, 2);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(110, 23);
            txApellido.TabIndex = 2;
            // 
            // txDni
            // 
            txDni.Location = new Point(282, 86);
            txDni.Margin = new Padding(3, 2, 3, 2);
            txDni.Name = "txDni";
            txDni.Size = new Size(110, 23);
            txDni.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 4;
            label1.Text = "Legajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(225, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(225, 67);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(225, 94);
            label4.Name = "label4";
            label4.Size = new Size(27, 17);
            label4.TabIndex = 7;
            label4.Text = "Dni";
            // 
            // dataGridViewAlumno
            // 
            dataGridViewAlumno.AllowUserToDeleteRows = false;
            dataGridViewAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAlumno.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridViewAlumno.BorderStyle = BorderStyle.None;
            dataGridViewAlumno.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAlumno.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlumno.ColumnHeadersHeight = 30;
            dataGridViewAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAlumno.Columns.AddRange(new DataGridViewColumn[] { Legajo, Nombre, Apellido, Dni, valorCuota });
            dataGridViewAlumno.EnableHeadersVisualStyles = false;
            dataGridViewAlumno.GridColor = Color.SteelBlue;
            dataGridViewAlumno.Location = new Point(612, 22);
            dataGridViewAlumno.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAlumno.Name = "dataGridViewAlumno";
            dataGridViewAlumno.ReadOnly = true;
            dataGridViewAlumno.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAlumno.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAlumno.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewAlumno.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAlumno.RowTemplate.Height = 29;
            dataGridViewAlumno.Size = new Size(486, 153);
            dataGridViewAlumno.TabIndex = 9;
            dataGridViewAlumno.CellContentClick += dataGridViewAlumno_CellContentClick;
            dataGridViewAlumno.RowStateChanged += dataGridViewAlumno_RowStateChanged;
            // 
            // Legajo
            // 
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 6;
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            Legajo.Width = 76;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 85;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 85;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Width = 53;
            // 
            // valorCuota
            // 
            valorCuota.HeaderText = "Valor de Cuota";
            valorCuota.Name = "valorCuota";
            valorCuota.ReadOnly = true;
            valorCuota.Width = 133;
            // 
            // txCodigo
            // 
            txCodigo.Location = new Point(522, 236);
            txCodigo.Margin = new Padding(3, 2, 3, 2);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(110, 23);
            txCodigo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(467, 239);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 11;
            label5.Text = "Codigo";
            // 
            // txImporte
            // 
            txImporte.Location = new Point(522, 266);
            txImporte.Margin = new Padding(3, 2, 3, 2);
            txImporte.Name = "txImporte";
            txImporte.Size = new Size(110, 23);
            txImporte.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(464, 274);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 13;
            label6.Text = "Importe";
            // 
            // dataGridViewBeca
            // 
            dataGridViewBeca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBeca.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridViewBeca.BorderStyle = BorderStyle.None;
            dataGridViewBeca.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBeca.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBeca.ColumnHeadersHeight = 30;
            dataGridViewBeca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBeca.Columns.AddRange(new DataGridViewColumn[] { Codigo, Fecha, Importe });
            dataGridViewBeca.EnableHeadersVisualStyles = false;
            dataGridViewBeca.GridColor = Color.SteelBlue;
            dataGridViewBeca.Location = new Point(101, 236);
            dataGridViewBeca.Margin = new Padding(3, 2, 3, 2);
            dataGridViewBeca.Name = "dataGridViewBeca";
            dataGridViewBeca.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewBeca.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBeca.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewBeca.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBeca.RowTemplate.Height = 29;
            dataGridViewBeca.Size = new Size(357, 137);
            dataGridViewBeca.TabIndex = 15;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 82;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 71;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 6;
            Importe.Name = "Importe";
            Importe.Width = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(512, 61);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 18;
            label7.Text = "Ingrese el Año";
            // 
            // txAnioCuotas
            // 
            txAnioCuotas.Location = new Point(522, 86);
            txAnioCuotas.Margin = new Padding(3, 2, 3, 2);
            txAnioCuotas.Name = "txAnioCuotas";
            txAnioCuotas.Size = new Size(72, 23);
            txAnioCuotas.TabIndex = 17;
            // 
            // dataGridViewAlumnoBeca
            // 
            dataGridViewAlumnoBeca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAlumnoBeca.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridViewAlumnoBeca.BorderStyle = BorderStyle.None;
            dataGridViewAlumnoBeca.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAlumnoBeca.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewAlumnoBeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewAlumnoBeca.ColumnHeadersHeight = 30;
            dataGridViewAlumnoBeca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAlumnoBeca.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewAlumnoBeca.EnableHeadersVisualStyles = false;
            dataGridViewAlumnoBeca.GridColor = Color.SteelBlue;
            dataGridViewAlumnoBeca.Location = new Point(662, 219);
            dataGridViewAlumnoBeca.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAlumnoBeca.Name = "dataGridViewAlumnoBeca";
            dataGridViewAlumnoBeca.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewAlumnoBeca.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewAlumnoBeca.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewAlumnoBeca.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewAlumnoBeca.RowTemplate.Height = 29;
            dataGridViewAlumnoBeca.Size = new Size(380, 141);
            dataGridViewAlumnoBeca.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Importe";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 83;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // dataGridViewCuotas
            // 
            dataGridViewCuotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCuotas.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridViewCuotas.BorderStyle = BorderStyle.None;
            dataGridViewCuotas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCuotas.ColumnHeadersHeight = 30;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCuotas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, FechaPago, ImporteCuota, ImporteBeca, Beneficio, NetoaPagar });
            dataGridViewCuotas.EnableHeadersVisualStyles = false;
            dataGridViewCuotas.GridColor = Color.SteelBlue;
            dataGridViewCuotas.Location = new Point(30, 399);
            dataGridViewCuotas.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCuotas.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCuotas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCuotas.RowTemplate.Height = 29;
            dataGridViewCuotas.Size = new Size(735, 141);
            dataGridViewCuotas.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 75F;
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 44;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Mes/Año";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 88;
            // 
            // FechaPago
            // 
            FechaPago.HeaderText = "FechaPago";
            FechaPago.MinimumWidth = 6;
            FechaPago.Name = "FechaPago";
            FechaPago.Width = 106;
            // 
            // ImporteCuota
            // 
            ImporteCuota.HeaderText = "ImporteCuota";
            ImporteCuota.MinimumWidth = 6;
            ImporteCuota.Name = "ImporteCuota";
            ImporteCuota.Width = 125;
            // 
            // ImporteBeca
            // 
            ImporteBeca.HeaderText = "ImporteBeca";
            ImporteBeca.MinimumWidth = 6;
            ImporteBeca.Name = "ImporteBeca";
            ImporteBeca.Width = 115;
            // 
            // Beneficio
            // 
            Beneficio.HeaderText = "Beneficio";
            Beneficio.MinimumWidth = 6;
            Beneficio.Name = "Beneficio";
            Beneficio.Width = 90;
            // 
            // NetoaPagar
            // 
            NetoaPagar.HeaderText = "NetoAPagar";
            NetoaPagar.MinimumWidth = 6;
            NetoaPagar.Name = "NetoaPagar";
            NetoaPagar.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Id";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // btPagarCuota
            // 
            btPagarCuota.BackColor = Color.FromArgb(20, 121, 78);
            btPagarCuota.FlatAppearance.BorderSize = 0;
            btPagarCuota.FlatStyle = FlatStyle.Flat;
            btPagarCuota.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btPagarCuota.ForeColor = Color.White;
            btPagarCuota.Location = new Point(908, 442);
            btPagarCuota.Name = "btPagarCuota";
            btPagarCuota.Size = new Size(75, 48);
            btPagarCuota.TabIndex = 20;
            btPagarCuota.Text = "Pagar Cuota";
            btPagarCuota.UseVisualStyleBackColor = false;
            btPagarCuota.Click += btPagarCuota_Click;
            // 
            // txCuotaAlumno
            // 
            txCuotaAlumno.Location = new Point(282, 114);
            txCuotaAlumno.Name = "txCuotaAlumno";
            txCuotaAlumno.Size = new Size(109, 23);
            txCuotaAlumno.TabIndex = 22;
            // 
            // btModificarAlumno
            // 
            btModificarAlumno.BackColor = Color.FromArgb(20, 121, 78);
            btModificarAlumno.FlatAppearance.BorderSize = 0;
            btModificarAlumno.FlatStyle = FlatStyle.Flat;
            btModificarAlumno.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btModificarAlumno.ForeColor = Color.White;
            btModificarAlumno.Location = new Point(383, 153);
            btModificarAlumno.Margin = new Padding(3, 2, 3, 2);
            btModificarAlumno.Name = "btModificarAlumno";
            btModificarAlumno.Size = new Size(75, 60);
            btModificarAlumno.TabIndex = 23;
            btModificarAlumno.Text = "Modificar Alumno";
            btModificarAlumno.UseVisualStyleBackColor = false;
            btModificarAlumno.Click += btModificarAlumno_Click;
            // 
            // btnCrearCuotas
            // 
            btnCrearCuotas.BackColor = Color.FromArgb(20, 121, 78);
            btnCrearCuotas.FlatAppearance.BorderSize = 0;
            btnCrearCuotas.FlatStyle = FlatStyle.Flat;
            btnCrearCuotas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearCuotas.ForeColor = Color.White;
            btnCrearCuotas.Location = new Point(522, 119);
            btnCrearCuotas.Name = "btnCrearCuotas";
            btnCrearCuotas.Size = new Size(68, 57);
            btnCrearCuotas.TabIndex = 28;
            btnCrearCuotas.Text = "Crear Cuotas";
            btnCrearCuotas.UseVisualStyleBackColor = false;
            btnCrearCuotas.Click += btnCrearCuotas_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(885, 399);
            label9.Name = "label9";
            label9.Size = new Size(157, 17);
            label9.TabIndex = 29;
            label9.Text = "Selecione el N° de cuota";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(201, 116);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 30;
            label8.Text = "Valor Cuota";
            // 
            // rdiobAlmIngresante
            // 
            rdiobAlmIngresante.AutoSize = true;
            rdiobAlmIngresante.Checked = true;
            rdiobAlmIngresante.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdiobAlmIngresante.ForeColor = Color.White;
            rdiobAlmIngresante.Location = new Point(23, 25);
            rdiobAlmIngresante.Name = "rdiobAlmIngresante";
            rdiobAlmIngresante.Size = new Size(125, 20);
            rdiobAlmIngresante.TabIndex = 32;
            rdiobAlmIngresante.TabStop = true;
            rdiobAlmIngresante.Text = "Alumno Ingresante";
            rdiobAlmIngresante.UseVisualStyleBackColor = true;
            // 
            // rdiobAlumGrado
            // 
            rdiobAlumGrado.AutoSize = true;
            rdiobAlumGrado.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdiobAlumGrado.ForeColor = Color.White;
            rdiobAlumGrado.Location = new Point(23, 48);
            rdiobAlumGrado.Name = "rdiobAlumGrado";
            rdiobAlumGrado.Size = new Size(104, 20);
            rdiobAlumGrado.TabIndex = 33;
            rdiobAlumGrado.Text = "Alumno Grado";
            rdiobAlumGrado.UseVisualStyleBackColor = true;
            // 
            // rdiobAlumPostGrado
            // 
            rdiobAlumPostGrado.AutoSize = true;
            rdiobAlumPostGrado.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdiobAlumPostGrado.ForeColor = Color.White;
            rdiobAlumPostGrado.Location = new Point(23, 73);
            rdiobAlumPostGrado.Name = "rdiobAlumPostGrado";
            rdiobAlumPostGrado.Size = new Size(126, 20);
            rdiobAlumPostGrado.TabIndex = 34;
            rdiobAlumPostGrado.Text = "Alumno PostGrado";
            rdiobAlumPostGrado.UseVisualStyleBackColor = true;
            // 
            // gboxOpciones
            // 
            gboxOpciones.Controls.Add(rdiobAlmIngresante);
            gboxOpciones.Controls.Add(rdiobAlumPostGrado);
            gboxOpciones.Controls.Add(rdiobAlumGrado);
            gboxOpciones.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            gboxOpciones.ForeColor = Color.White;
            gboxOpciones.Location = new Point(22, 71);
            gboxOpciones.Name = "gboxOpciones";
            gboxOpciones.Size = new Size(173, 105);
            gboxOpciones.TabIndex = 35;
            gboxOpciones.TabStop = false;
            gboxOpciones.Text = "Opciones";
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.BackColor = Color.FromArgb(20, 121, 78);
            btnCargarDatos.FlatAppearance.BorderSize = 0;
            btnCargarDatos.FlatStyle = FlatStyle.Flat;
            btnCargarDatos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarDatos.ForeColor = Color.White;
            btnCargarDatos.Location = new Point(215, 153);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(79, 60);
            btnCargarDatos.TabIndex = 36;
            btnCargarDatos.Text = "Cargar Datos";
            btnCargarDatos.UseVisualStyleBackColor = false;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(20, 121, 78);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(300, 153);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 60);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAceptarBecas
            // 
            btnAceptarBecas.BackColor = Color.FromArgb(20, 121, 78);
            btnAceptarBecas.FlatAppearance.BorderSize = 0;
            btnAceptarBecas.FlatStyle = FlatStyle.Flat;
            btnAceptarBecas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptarBecas.ForeColor = Color.White;
            btnAceptarBecas.Location = new Point(531, 313);
            btnAceptarBecas.Name = "btnAceptarBecas";
            btnAceptarBecas.Size = new Size(73, 36);
            btnAceptarBecas.TabIndex = 38;
            btnAceptarBecas.Text = "Aceptar";
            btnAceptarBecas.UseVisualStyleBackColor = false;
            btnAceptarBecas.Click += btnAceptarBecas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 56, 81);
            ClientSize = new Size(1115, 551);
            Controls.Add(btnAceptarBecas);
            Controls.Add(btnEliminar);
            Controls.Add(btnCargarDatos);
            Controls.Add(gboxOpciones);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnCrearCuotas);
            Controls.Add(label7);
            Controls.Add(txAnioCuotas);
            Controls.Add(btModificarAlumno);
            Controls.Add(txCuotaAlumno);
            Controls.Add(btPagarCuota);
            Controls.Add(dataGridViewCuotas);
            Controls.Add(dataGridViewAlumnoBeca);
            Controls.Add(dataGridViewBeca);
            Controls.Add(label6);
            Controls.Add(txImporte);
            Controls.Add(label5);
            Controls.Add(txCodigo);
            Controls.Add(dataGridViewAlumno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txDni);
            Controls.Add(txApellido);
            Controls.Add(txNombre);
            Controls.Add(txLegajo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "UNIVERSIDAD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnoBeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).EndInit();
            gboxOpciones.ResumeLayout(false);
            gboxOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txLegajo;
        private TextBox txNombre;
        private TextBox txApellido;
        private TextBox txDni;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewAlumno;
        private TextBox txCodigo;
        private Label label5;
        private TextBox txImporte;
        private Label label6;
        private DataGridView dataGridViewBeca;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Importe;
        private TextBox txAnioCuotas;
        private Label label7;
        private DataGridView dataGridViewAlumnoBeca;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Id;
        private DataGridView dataGridViewCuotas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btPagarCuota;
        private TextBox txCuotaAlumno;
        private Button btModificarAlumno;
        private Button btnCrearCuotas;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn FechaPago;
        private DataGridViewTextBoxColumn ImporteCuota;
        private DataGridViewTextBoxColumn ImporteBeca;
        private DataGridViewTextBoxColumn Beneficio;
        private DataGridViewTextBoxColumn NetoaPagar;
        private DataGridViewTextBoxColumn valorCuota;
        private Label label9;
        private Label label8;
        private RadioButton rdiobAlmIngresante;
        private RadioButton rdiobAlumGrado;
        private RadioButton rdiobAlumPostGrado;
        private GroupBox gboxOpciones;
        private Button btnCargarDatos;
        private Button btnEliminar;
        private Button btnAceptarBecas;
    }
}