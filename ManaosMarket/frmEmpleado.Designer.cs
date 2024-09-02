namespace ManaosMarket
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbListadoEmpleado = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblListadoEmpleado = new System.Windows.Forms.Label();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.cdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombresCompletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtListadoEmpleado = new System.Windows.Forms.TextBox();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellMaterno = new System.Windows.Forms.TextBox();
            this.txtApellPaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellMaterno = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApellPaterno = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarCarnet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbListadoEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.gbEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCerrar.Location = new System.Drawing.Point(984, 583);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 35);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.close_Click);
            // 
            // gbListadoEmpleado
            // 
            this.gbListadoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListadoEmpleado.Controls.Add(this.btnModificar);
            this.gbListadoEmpleado.Controls.Add(this.btnListar);
            this.gbListadoEmpleado.Controls.Add(this.btnNuevo);
            this.gbListadoEmpleado.Controls.Add(this.lblListadoEmpleado);
            this.gbListadoEmpleado.Controls.Add(this.dgvEmpleado);
            this.gbListadoEmpleado.Controls.Add(this.txtListadoEmpleado);
            this.gbListadoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.gbListadoEmpleado.Location = new System.Drawing.Point(466, 58);
            this.gbListadoEmpleado.Name = "gbListadoEmpleado";
            this.gbListadoEmpleado.Size = new System.Drawing.Size(604, 513);
            this.gbListadoEmpleado.TabIndex = 15;
            this.gbListadoEmpleado.TabStop = false;
            this.gbListadoEmpleado.Text = "&Listado &Empleado";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificar.Location = new System.Drawing.Point(110, 472);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 35);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnListar.Location = new System.Drawing.Point(502, 32);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 35);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNuevo.Location = new System.Drawing.Point(18, 472);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 35);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblListadoEmpleado
            // 
            this.lblListadoEmpleado.AutoSize = true;
            this.lblListadoEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblListadoEmpleado.Location = new System.Drawing.Point(13, 36);
            this.lblListadoEmpleado.Name = "lblListadoEmpleado";
            this.lblListadoEmpleado.Size = new System.Drawing.Size(104, 26);
            this.lblListadoEmpleado.TabIndex = 0;
            this.lblListadoEmpleado.Text = "&Empleado";
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdCodigo,
            this.cdNombresCompletos,
            this.cdGenero,
            this.Vigente});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmpleado.GridColor = System.Drawing.Color.Black;
            this.dgvEmpleado.Location = new System.Drawing.Point(18, 78);
            this.dgvEmpleado.MultiSelect = false;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleado.Size = new System.Drawing.Size(570, 388);
            this.dgvEmpleado.TabIndex = 3;
            // 
            // cdCodigo
            // 
            this.cdCodigo.DataPropertyName = "idEmpleado";
            this.cdCodigo.HeaderText = "Codigo";
            this.cdCodigo.Name = "cdCodigo";
            this.cdCodigo.ReadOnly = true;
            // 
            // cdNombresCompletos
            // 
            this.cdNombresCompletos.DataPropertyName = "nombresCompletos";
            this.cdNombresCompletos.HeaderText = "Nombres";
            this.cdNombresCompletos.Name = "cdNombresCompletos";
            this.cdNombresCompletos.ReadOnly = true;
            this.cdNombresCompletos.Width = 220;
            // 
            // cdGenero
            // 
            this.cdGenero.DataPropertyName = "mostrarGenero";
            this.cdGenero.HeaderText = "Genero";
            this.cdGenero.Name = "cdGenero";
            this.cdGenero.ReadOnly = true;
            // 
            // Vigente
            // 
            this.Vigente.DataPropertyName = "vigente";
            this.Vigente.HeaderText = "Vigente";
            this.Vigente.Name = "Vigente";
            this.Vigente.ReadOnly = true;
            // 
            // txtListadoEmpleado
            // 
            this.txtListadoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListadoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtListadoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtListadoEmpleado.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListadoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtListadoEmpleado.Location = new System.Drawing.Point(123, 36);
            this.txtListadoEmpleado.MaxLength = 99999;
            this.txtListadoEmpleado.Multiline = true;
            this.txtListadoEmpleado.Name = "txtListadoEmpleado";
            this.txtListadoEmpleado.Size = new System.Drawing.Size(373, 27);
            this.txtListadoEmpleado.TabIndex = 1;
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.cmbGenero);
            this.gbEmpleado.Controls.Add(this.dtpFechaNacimiento);
            this.gbEmpleado.Controls.Add(this.txtCorreo);
            this.gbEmpleado.Controls.Add(this.txtDireccion);
            this.gbEmpleado.Controls.Add(this.txtTelefono);
            this.gbEmpleado.Controls.Add(this.txtDni);
            this.gbEmpleado.Controls.Add(this.txtApellMaterno);
            this.gbEmpleado.Controls.Add(this.txtApellPaterno);
            this.gbEmpleado.Controls.Add(this.txtNombres);
            this.gbEmpleado.Controls.Add(this.lblTelefono);
            this.gbEmpleado.Controls.Add(this.lblDireccion);
            this.gbEmpleado.Controls.Add(this.lblApellMaterno);
            this.gbEmpleado.Controls.Add(this.lblFechaNac);
            this.gbEmpleado.Controls.Add(this.lblApellPaterno);
            this.gbEmpleado.Controls.Add(this.lblCorreo);
            this.gbEmpleado.Controls.Add(this.lbldni);
            this.gbEmpleado.Controls.Add(this.lblGenero);
            this.gbEmpleado.Controls.Add(this.btnAceptar);
            this.gbEmpleado.Controls.Add(this.btnCancelar);
            this.gbEmpleado.Controls.Add(this.chkVigente);
            this.gbEmpleado.Controls.Add(this.lblNombres);
            this.gbEmpleado.Controls.Add(this.lblCodigoEmpleado);
            this.gbEmpleado.Controls.Add(this.txtcodigo);
            this.gbEmpleado.Enabled = false;
            this.gbEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.gbEmpleado.Location = new System.Drawing.Point(27, 56);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(433, 454);
            this.gbEmpleado.TabIndex = 14;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "&Empleado";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino\t",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(193, 199);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(165, 28);
            this.cmbGenero.TabIndex = 27;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpFechaNacimiento.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(193, 230);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(165, 32);
            this.dtpFechaNacimiento.TabIndex = 26;
            this.dtpFechaNacimiento.Value = new System.DateTime(1999, 1, 10, 0, 0, 0, 0);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtCorreo.Location = new System.Drawing.Point(193, 331);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(218, 27);
            this.txtCorreo.TabIndex = 24;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDireccion.Location = new System.Drawing.Point(193, 298);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(218, 27);
            this.txtDireccion.TabIndex = 23;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtTelefono.Location = new System.Drawing.Point(193, 265);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(218, 27);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDni.Location = new System.Drawing.Point(193, 166);
            this.txtDni.MaxLength = 8;
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(218, 27);
            this.txtDni.TabIndex = 19;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtApellMaterno
            // 
            this.txtApellMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtApellMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellMaterno.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtApellMaterno.Location = new System.Drawing.Point(193, 133);
            this.txtApellMaterno.MaxLength = 50;
            this.txtApellMaterno.Multiline = true;
            this.txtApellMaterno.Name = "txtApellMaterno";
            this.txtApellMaterno.Size = new System.Drawing.Size(218, 27);
            this.txtApellMaterno.TabIndex = 18;
            // 
            // txtApellPaterno
            // 
            this.txtApellPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtApellPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellPaterno.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtApellPaterno.Location = new System.Drawing.Point(193, 100);
            this.txtApellPaterno.MaxLength = 50;
            this.txtApellPaterno.Multiline = true;
            this.txtApellPaterno.Name = "txtApellPaterno";
            this.txtApellPaterno.Size = new System.Drawing.Size(218, 27);
            this.txtApellPaterno.TabIndex = 17;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNombres.Location = new System.Drawing.Point(193, 67);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(218, 27);
            this.txtNombres.TabIndex = 16;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTelefono.Location = new System.Drawing.Point(94, 270);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(93, 26);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "&Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblDireccion.Location = new System.Drawing.Point(88, 303);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 26);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "&Direccion";
            // 
            // lblApellMaterno
            // 
            this.lblApellMaterno.AutoSize = true;
            this.lblApellMaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellMaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblApellMaterno.Location = new System.Drawing.Point(43, 133);
            this.lblApellMaterno.Name = "lblApellMaterno";
            this.lblApellMaterno.Size = new System.Drawing.Size(144, 26);
            this.lblApellMaterno.TabIndex = 12;
            this.lblApellMaterno.Text = "&Apell Materno";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFechaNac.Location = new System.Drawing.Point(8, 238);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(179, 26);
            this.lblFechaNac.TabIndex = 11;
            this.lblFechaNac.Text = "&Fecha Nacimiento";
            // 
            // lblApellPaterno
            // 
            this.lblApellPaterno.AutoSize = true;
            this.lblApellPaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblApellPaterno.Location = new System.Drawing.Point(50, 100);
            this.lblApellPaterno.Name = "lblApellPaterno";
            this.lblApellPaterno.Size = new System.Drawing.Size(137, 26);
            this.lblApellPaterno.TabIndex = 10;
            this.lblApellPaterno.Text = "&Apell Paterno";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCorreo.Location = new System.Drawing.Point(113, 336);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(74, 26);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "&Correo";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbldni.Location = new System.Drawing.Point(138, 166);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(49, 26);
            this.lbldni.TabIndex = 8;
            this.lbldni.Text = "&DNI";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblGenero.Location = new System.Drawing.Point(108, 199);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(79, 26);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "&Genero";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAceptar.Location = new System.Drawing.Point(233, 413);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 35);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCancelar.Location = new System.Drawing.Point(325, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVigente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.chkVigente.Location = new System.Drawing.Point(193, 364);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(102, 30);
            this.chkVigente.TabIndex = 4;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblNombres.Location = new System.Drawing.Point(90, 67);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(97, 26);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "&Nombres";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(109, 34);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(78, 26);
            this.lblCodigoEmpleado.TabIndex = 0;
            this.lblCodigoEmpleado.Text = "&Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(193, 34);
            this.txtcodigo.MaxLength = 6;
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(91, 27);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Text = "EA0001";
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(103, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "&Empleador &Manaos";
            // 
            // btnGenerarCarnet
            // 
            this.btnGenerarCarnet.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarCarnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarCarnet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGenerarCarnet.FlatAppearance.BorderSize = 2;
            this.btnGenerarCarnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnGenerarCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCarnet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCarnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGenerarCarnet.Location = new System.Drawing.Point(27, 516);
            this.btnGenerarCarnet.Name = "btnGenerarCarnet";
            this.btnGenerarCarnet.Size = new System.Drawing.Size(124, 35);
            this.btnGenerarCarnet.TabIndex = 28;
            this.btnGenerarCarnet.Text = "&GenerarCarnet";
            this.btnGenerarCarnet.UseVisualStyleBackColor = false;
            this.btnGenerarCarnet.Click += new System.EventHandler(this.btnGenerarCarnet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1029, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 34);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 17;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(27, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "&Encargatura";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1082, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarCarnet);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListadoEmpleado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.gbListadoEmpleado.ResumeLayout(false);
            this.gbListadoEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbListadoEmpleado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblListadoEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TextBox txtListadoEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label lblApellMaterno;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblApellPaterno;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellMaterno;
        private System.Windows.Forms.TextBox txtApellPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnGenerarCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombresCompletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdGenero;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Vigente;
        private System.Windows.Forms.Button button1;
    }
}