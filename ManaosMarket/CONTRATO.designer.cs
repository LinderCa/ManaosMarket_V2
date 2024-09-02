namespace ManaosMarket
{
    partial class CONTRATO
    {

        private void InitializeComponent()
        {
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.cdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdIdSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdIdHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTipoMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVigencia = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mskHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.gbRegistroContrato = new System.Windows.Forms.GroupBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lbContrato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.gbRegistroContrato.SuspendLayout();
            this.gbListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdCodigo,
            this.cdIdSueldo,
            this.cdIdHorario,
            this.cdDNI,
            this.cdNombres,
            this.cdTelefono,
            this.cdCorreo,
            this.cdFechaInicio,
            this.cdFechaFin,
            this.cdTipo,
            this.cdMonto,
            this.cdTipoMonto,
            this.cdHoraEntrada,
            this.cdHoraSalida,
            this.cdVigencia});
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(29, 111);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.RowHeadersVisible = false;
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(685, 411);
            this.dataGridViewEmpleados.TabIndex = 0;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick_1);
            // 
            // cdCodigo
            // 
            this.cdCodigo.DataPropertyName = "idContrato";
            this.cdCodigo.HeaderText = "Codigo";
            this.cdCodigo.MinimumWidth = 6;
            this.cdCodigo.Name = "cdCodigo";
            this.cdCodigo.ReadOnly = true;
            this.cdCodigo.Width = 80;
            // 
            // cdIdSueldo
            // 
            this.cdIdSueldo.DataPropertyName = "idSueldo";
            this.cdIdSueldo.HeaderText = "IdSueldo";
            this.cdIdSueldo.MinimumWidth = 6;
            this.cdIdSueldo.Name = "cdIdSueldo";
            this.cdIdSueldo.ReadOnly = true;
            this.cdIdSueldo.Visible = false;
            this.cdIdSueldo.Width = 125;
            // 
            // cdIdHorario
            // 
            this.cdIdHorario.DataPropertyName = "codHorario";
            this.cdIdHorario.HeaderText = "idHorario";
            this.cdIdHorario.MinimumWidth = 6;
            this.cdIdHorario.Name = "cdIdHorario";
            this.cdIdHorario.ReadOnly = true;
            this.cdIdHorario.Visible = false;
            this.cdIdHorario.Width = 125;
            // 
            // cdDNI
            // 
            this.cdDNI.DataPropertyName = "EmpleadoDNI";
            this.cdDNI.HeaderText = "DNI";
            this.cdDNI.MinimumWidth = 6;
            this.cdDNI.Name = "cdDNI";
            this.cdDNI.ReadOnly = true;
            this.cdDNI.Visible = false;
            this.cdDNI.Width = 125;
            // 
            // cdNombres
            // 
            this.cdNombres.DataPropertyName = "nombreEmpleado";
            this.cdNombres.HeaderText = "Nombres Completo";
            this.cdNombres.MinimumWidth = 6;
            this.cdNombres.Name = "cdNombres";
            this.cdNombres.ReadOnly = true;
            // 
            // cdTelefono
            // 
            this.cdTelefono.DataPropertyName = "EmpleadoTelefono";
            this.cdTelefono.HeaderText = "Telefono";
            this.cdTelefono.MinimumWidth = 6;
            this.cdTelefono.Name = "cdTelefono";
            this.cdTelefono.ReadOnly = true;
            this.cdTelefono.Visible = false;
            this.cdTelefono.Width = 125;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "EmpleadoCorreo";
            this.cdCorreo.HeaderText = "Correo";
            this.cdCorreo.MinimumWidth = 6;
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            this.cdCorreo.Visible = false;
            this.cdCorreo.Width = 125;
            // 
            // cdFechaInicio
            // 
            this.cdFechaInicio.DataPropertyName = "FechaInicio";
            this.cdFechaInicio.HeaderText = "FechaInicio";
            this.cdFechaInicio.MinimumWidth = 6;
            this.cdFechaInicio.Name = "cdFechaInicio";
            this.cdFechaInicio.ReadOnly = true;
            // 
            // cdFechaFin
            // 
            this.cdFechaFin.DataPropertyName = "FechaFin";
            this.cdFechaFin.HeaderText = "FechaFin";
            this.cdFechaFin.MinimumWidth = 6;
            this.cdFechaFin.Name = "cdFechaFin";
            this.cdFechaFin.ReadOnly = true;
            // 
            // cdTipo
            // 
            this.cdTipo.DataPropertyName = "Tipo";
            this.cdTipo.HeaderText = "Tipo";
            this.cdTipo.MinimumWidth = 6;
            this.cdTipo.Name = "cdTipo";
            this.cdTipo.ReadOnly = true;
            // 
            // cdMonto
            // 
            this.cdMonto.DataPropertyName = "SueldoMonto";
            this.cdMonto.HeaderText = "Sueldo";
            this.cdMonto.MinimumWidth = 6;
            this.cdMonto.Name = "cdMonto";
            this.cdMonto.ReadOnly = true;
            // 
            // cdTipoMonto
            // 
            this.cdTipoMonto.DataPropertyName = "SueldoTipo";
            this.cdTipoMonto.HeaderText = "Tipo Moneda";
            this.cdTipoMonto.MinimumWidth = 6;
            this.cdTipoMonto.Name = "cdTipoMonto";
            this.cdTipoMonto.ReadOnly = true;
            this.cdTipoMonto.Visible = false;
            this.cdTipoMonto.Width = 125;
            // 
            // cdHoraEntrada
            // 
            this.cdHoraEntrada.DataPropertyName = "MostrarHorarioEntrada";
            this.cdHoraEntrada.HeaderText = "Hora Entrada";
            this.cdHoraEntrada.MinimumWidth = 6;
            this.cdHoraEntrada.Name = "cdHoraEntrada";
            this.cdHoraEntrada.ReadOnly = true;
            this.cdHoraEntrada.Visible = false;
            this.cdHoraEntrada.Width = 125;
            // 
            // cdHoraSalida
            // 
            this.cdHoraSalida.DataPropertyName = "MostrarHorarioSalida";
            this.cdHoraSalida.HeaderText = "Hora Salida";
            this.cdHoraSalida.MinimumWidth = 6;
            this.cdHoraSalida.Name = "cdHoraSalida";
            this.cdHoraSalida.ReadOnly = true;
            this.cdHoraSalida.Visible = false;
            this.cdHoraSalida.Width = 125;
            // 
            // cdVigencia
            // 
            this.cdVigencia.DataPropertyName = "Vigencia";
            this.cdVigencia.HeaderText = "Vigencia";
            this.cdVigencia.MinimumWidth = 6;
            this.cdVigencia.Name = "cdVigencia";
            this.cdVigencia.ReadOnly = true;
            this.cdVigencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdVigencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(50, 87);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(165, 26);
            this.lblFechaInicio.TabIndex = 16;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(223, 86);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(7);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(199, 28);
            this.dateTimePickerFechaInicio.TabIndex = 15;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFechaFin.Location = new System.Drawing.Point(105, 129);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(120, 26);
            this.lblFechaFin.TabIndex = 19;
            this.lblFechaFin.Text = "Fecha Fin :";
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(223, 128);
            this.dateTimePickerFechaFin.Margin = new System.Windows.Forms.Padding(7);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(199, 28);
            this.dateTimePickerFechaFin.TabIndex = 18;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblHorario.Location = new System.Drawing.Point(154, 171);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(71, 26);
            this.lblHorario.TabIndex = 23;
            this.lblHorario.Text = "Tipo : ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(184, 353);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 32);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(617, 552);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 32);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(92, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Empleado :";
            // 
            // chkVigencia
            // 
            this.chkVigencia.AutoSize = true;
            this.chkVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVigencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.chkVigencia.Location = new System.Drawing.Point(223, 296);
            this.chkVigencia.Margin = new System.Windows.Forms.Padding(7);
            this.chkVigencia.Name = "chkVigencia";
            this.chkVigencia.Size = new System.Drawing.Size(105, 30);
            this.chkVigencia.TabIndex = 17;
            this.chkVigencia.Text = "Vigente";
            this.chkVigencia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(135, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Monto : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(81, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hora Salida : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(66, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "Hora Entrada : ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1090, 636);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskHoraEntrada
            // 
            this.mskHoraEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.mskHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskHoraEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.mskHoraEntrada.Location = new System.Drawing.Point(223, 238);
            this.mskHoraEntrada.Name = "mskHoraEntrada";
            this.mskHoraEntrada.Size = new System.Drawing.Size(199, 21);
            this.mskHoraEntrada.TabIndex = 37;
            this.mskHoraEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskHoraEntrada_KeyPress);
            // 
            // mskHoraSalida
            // 
            this.mskHoraSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.mskHoraSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskHoraSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.mskHoraSalida.Location = new System.Drawing.Point(223, 265);
            this.mskHoraSalida.Name = "mskHoraSalida";
            this.mskHoraSalida.Size = new System.Drawing.Size(199, 21);
            this.mskHoraSalida.TabIndex = 37;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "P",
            "F"});
            this.cmbTipo.Location = new System.Drawing.Point(223, 169);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(199, 30);
            this.cmbTipo.TabIndex = 38;
            // 
            // nudMonto
            // 
            this.nudMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.nudMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.nudMonto.Location = new System.Drawing.Point(223, 208);
            this.nudMonto.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(199, 24);
            this.nudMonto.TabIndex = 39;
            // 
            // gbRegistroContrato
            // 
            this.gbRegistroContrato.Controls.Add(this.txtEmpleado);
            this.gbRegistroContrato.Controls.Add(this.label1);
            this.gbRegistroContrato.Controls.Add(this.nudMonto);
            this.gbRegistroContrato.Controls.Add(this.dateTimePickerFechaInicio);
            this.gbRegistroContrato.Controls.Add(this.cmbTipo);
            this.gbRegistroContrato.Controls.Add(this.lblFechaInicio);
            this.gbRegistroContrato.Controls.Add(this.mskHoraSalida);
            this.gbRegistroContrato.Controls.Add(this.chkVigencia);
            this.gbRegistroContrato.Controls.Add(this.mskHoraEntrada);
            this.gbRegistroContrato.Controls.Add(this.dateTimePickerFechaFin);
            this.gbRegistroContrato.Controls.Add(this.lblFechaFin);
            this.gbRegistroContrato.Controls.Add(this.label4);
            this.gbRegistroContrato.Controls.Add(this.lblHorario);
            this.gbRegistroContrato.Controls.Add(this.label5);
            this.gbRegistroContrato.Controls.Add(this.btnCancelar);
            this.gbRegistroContrato.Controls.Add(this.btnAgregar);
            this.gbRegistroContrato.Controls.Add(this.label2);
            this.gbRegistroContrato.Enabled = false;
            this.gbRegistroContrato.Location = new System.Drawing.Point(12, 12);
            this.gbRegistroContrato.Name = "gbRegistroContrato";
            this.gbRegistroContrato.Size = new System.Drawing.Size(442, 429);
            this.gbRegistroContrato.TabIndex = 40;
            this.gbRegistroContrato.TabStop = false;
            this.gbRegistroContrato.Text = "Contrato";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(223, 48);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(199, 28);
            this.txtEmpleado.TabIndex = 40;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(300, 353);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 32);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.btnListar);
            this.gbListado.Controls.Add(this.txtBuscar);
            this.gbListado.Controls.Add(this.dataGridViewEmpleados);
            this.gbListado.Controls.Add(this.btnEliminar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.lbContrato);
            this.gbListado.Location = new System.Drawing.Point(474, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(816, 614);
            this.gbListado.TabIndex = 41;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado Contratos";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.BackColor = System.Drawing.Color.Transparent;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListar.FlatAppearance.BorderSize = 2;
            this.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListar.Location = new System.Drawing.Point(632, 43);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(82, 39);
            this.btnListar.TabIndex = 27;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBuscar.Location = new System.Drawing.Point(185, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(373, 21);
            this.txtBuscar.TabIndex = 26;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(28, 553);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 30);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lbContrato
            // 
            this.lbContrato.AutoSize = true;
            this.lbContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbContrato.Location = new System.Drawing.Point(23, 55);
            this.lbContrato.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbContrato.Name = "lbContrato";
            this.lbContrato.Size = new System.Drawing.Size(118, 26);
            this.lbContrato.TabIndex = 23;
            this.lbContrato.Text = "Contratos :";
            // 
            // CONTRATO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1215, 719);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbRegistroContrato);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CONTRATO";
            this.Text = "CONTRATO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.gbRegistroContrato.ResumeLayout(false);
            this.gbRegistroContrato.PerformLayout();
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkVigencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskHoraEntrada;
        private System.Windows.Forms.MaskedTextBox mskHoraSalida;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.GroupBox gbRegistroContrato;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbContrato;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdIdSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdIdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTipoMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdHoraSalida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigencia;
    }
}
