namespace ManaosMarket
{
    partial class frmTardanza
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTardanza));
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbListadoTardanza = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbEmpleadoListado = new System.Windows.Forms.Label();
            this.dgvTardanzas = new System.Windows.Forms.DataGridView();
            this.txtListadoTardanzas = new System.Windows.Forms.TextBox();
            this.gbTardanza = new System.Windows.Forms.GroupBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoTardanza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTardanzas)).BeginInit();
            this.gbTardanza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(95, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "&Tardanzas &Manaos";
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
            this.btnCerrar.Location = new System.Drawing.Point(850, 568);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // gbListadoTardanza
            // 
            this.gbListadoTardanza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListadoTardanza.Controls.Add(this.btnModificar);
            this.gbListadoTardanza.Controls.Add(this.btnListar);
            this.gbListadoTardanza.Controls.Add(this.lbEmpleadoListado);
            this.gbListadoTardanza.Controls.Add(this.dgvTardanzas);
            this.gbListadoTardanza.Controls.Add(this.txtListadoTardanzas);
            this.gbListadoTardanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.gbListadoTardanza.Location = new System.Drawing.Point(455, 91);
            this.gbListadoTardanza.Name = "gbListadoTardanza";
            this.gbListadoTardanza.Size = new System.Drawing.Size(481, 469);
            this.gbListadoTardanza.TabIndex = 2;
            this.gbListadoTardanza.TabStop = false;
            this.gbListadoTardanza.Text = "Listado Tardanzas";
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
            this.btnModificar.Location = new System.Drawing.Point(25, 420);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 35);
            this.btnModificar.TabIndex = 4;
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
            this.btnListar.Location = new System.Drawing.Point(382, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 35);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbEmpleadoListado
            // 
            this.lbEmpleadoListado.AutoSize = true;
            this.lbEmpleadoListado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleadoListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbEmpleadoListado.Location = new System.Drawing.Point(13, 36);
            this.lbEmpleadoListado.Name = "lbEmpleadoListado";
            this.lbEmpleadoListado.Size = new System.Drawing.Size(109, 26);
            this.lbEmpleadoListado.TabIndex = 0;
            this.lbEmpleadoListado.Text = "Empleado:";
            // 
            // dgvTardanzas
            // 
            this.dgvTardanzas.AllowUserToAddRows = false;
            this.dgvTardanzas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTardanzas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTardanzas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTardanzas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dgvTardanzas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTardanzas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTardanzas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTardanzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTardanzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTardanzas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdEmpleado,
            this.cdFecha,
            this.cdHoras,
            this.cdEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTardanzas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTardanzas.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvTardanzas.Location = new System.Drawing.Point(25, 72);
            this.dgvTardanzas.Name = "dgvTardanzas";
            this.dgvTardanzas.ReadOnly = true;
            this.dgvTardanzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTardanzas.Size = new System.Drawing.Size(443, 342);
            this.dgvTardanzas.TabIndex = 3;
            // 
            // txtListadoTardanzas
            // 
            this.txtListadoTardanzas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListadoTardanzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtListadoTardanzas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtListadoTardanzas.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListadoTardanzas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtListadoTardanzas.Location = new System.Drawing.Point(128, 36);
            this.txtListadoTardanzas.MaxLength = 6;
            this.txtListadoTardanzas.Multiline = true;
            this.txtListadoTardanzas.Name = "txtListadoTardanzas";
            this.txtListadoTardanzas.Size = new System.Drawing.Size(248, 27);
            this.txtListadoTardanzas.TabIndex = 1;
            // 
            // gbTardanza
            // 
            this.gbTardanza.Controls.Add(this.txtEmpleado);
            this.gbTardanza.Controls.Add(this.cmbEstado);
            this.gbTardanza.Controls.Add(this.txtHoras);
            this.gbTardanza.Controls.Add(this.btnAceptar);
            this.gbTardanza.Controls.Add(this.btnCancelar);
            this.gbTardanza.Controls.Add(this.lbMotivo);
            this.gbTardanza.Controls.Add(this.lbEmpleado);
            this.gbTardanza.Controls.Add(this.txtMotivo);
            this.gbTardanza.Controls.Add(this.lbEstado);
            this.gbTardanza.Controls.Add(this.dtFecha);
            this.gbTardanza.Controls.Add(this.lbFecha);
            this.gbTardanza.Controls.Add(this.lbHoras);
            this.gbTardanza.Enabled = false;
            this.gbTardanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.gbTardanza.Location = new System.Drawing.Point(18, 91);
            this.gbTardanza.Name = "gbTardanza";
            this.gbTardanza.Size = new System.Drawing.Size(420, 469);
            this.gbTardanza.TabIndex = 1;
            this.gbTardanza.TabStop = false;
            this.gbTardanza.Text = "Gestionar Tardanzas";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleado.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmpleado.Location = new System.Drawing.Point(167, 31);
            this.txtEmpleado.MaxLength = 6;
            this.txtEmpleado.Multiline = true;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(215, 27);
            this.txtEmpleado.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Justificable",
            "No justificable"});
            this.cmbEstado.Location = new System.Drawing.Point(167, 156);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(215, 31);
            this.cmbEstado.TabIndex = 7;
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoras.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtHoras.Location = new System.Drawing.Point(167, 112);
            this.txtHoras.MaxLength = 6;
            this.txtHoras.Multiline = true;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(96, 27);
            this.txtHoras.TabIndex = 5;
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
            this.btnAceptar.Location = new System.Drawing.Point(202, 414);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 35);
            this.btnAceptar.TabIndex = 10;
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
            this.btnCancelar.Location = new System.Drawing.Point(294, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.lbMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbMotivo.Location = new System.Drawing.Point(79, 206);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(82, 26);
            this.lbMotivo.TabIndex = 8;
            this.lbMotivo.Text = "Motivo:";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.lbEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbEmpleado.Location = new System.Drawing.Point(52, 31);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(109, 26);
            this.lbEmpleado.TabIndex = 0;
            this.lbEmpleado.Text = "Empleado:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivo.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtMotivo.Location = new System.Drawing.Point(165, 206);
            this.txtMotivo.MaxLength = 200;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(220, 202);
            this.txtMotivo.TabIndex = 9;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.lbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbEstado.Location = new System.Drawing.Point(82, 161);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(79, 26);
            this.lbEstado.TabIndex = 6;
            this.lbEstado.Text = "Estado:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(167, 78);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(215, 20);
            this.dtFecha.TabIndex = 3;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.lbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbFecha.Location = new System.Drawing.Point(90, 72);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(71, 26);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.lbHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbHoras.Location = new System.Drawing.Point(90, 113);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(71, 26);
            this.lbHoras.TabIndex = 4;
            this.lbHoras.Text = "Horas:";
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(895, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 34);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 32;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cdEmpleado
            // 
            this.cdEmpleado.DataPropertyName = "idEmpleado";
            this.cdEmpleado.HeaderText = "Empleado";
            this.cdEmpleado.Name = "cdEmpleado";
            this.cdEmpleado.ReadOnly = true;
            // 
            // cdFecha
            // 
            this.cdFecha.DataPropertyName = "fecha";
            this.cdFecha.HeaderText = "Fecha";
            this.cdFecha.Name = "cdFecha";
            this.cdFecha.ReadOnly = true;
            // 
            // cdHoras
            // 
            this.cdHoras.DataPropertyName = "horasTardanza";
            this.cdHoras.HeaderText = "Horas";
            this.cdHoras.Name = "cdHoras";
            this.cdHoras.ReadOnly = true;
            // 
            // cdEstado
            // 
            this.cdEstado.DataPropertyName = "estado";
            this.cdEstado.HeaderText = "Estado";
            this.cdEstado.Name = "cdEstado";
            this.cdEstado.ReadOnly = true;
            // 
            // frmTardanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(955, 615);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbListadoTardanza);
            this.Controls.Add(this.gbTardanza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTardanza";
            this.Text = "TARDANZAS";
            this.Load += new System.EventHandler(this.frmTardanza_Load);
            this.gbListadoTardanza.ResumeLayout(false);
            this.gbListadoTardanza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTardanzas)).EndInit();
            this.gbTardanza.ResumeLayout(false);
            this.gbTardanza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbListadoTardanza;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lbEmpleadoListado;
        private System.Windows.Forms.DataGridView dgvTardanzas;
        private System.Windows.Forms.TextBox txtListadoTardanzas;
        private System.Windows.Forms.GroupBox gbTardanza;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdEstado;
    }
}