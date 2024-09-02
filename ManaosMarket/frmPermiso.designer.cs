
namespace ManaosMarket
{
    partial class frmPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermiso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupfecha = new System.Windows.Forms.GroupBox();
            this.dtpfechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfechaInicio = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbListadoArea = new System.Windows.Forms.GroupBox();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblAreasListado = new System.Windows.Forms.Label();
            this.txtBEmpleado2 = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarEmpleado = new System.Windows.Forms.Button();
            this.gbRegistrarPermiso = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grouphora = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorainicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorafin = new System.Windows.Forms.TextBox();
            this.chbfechas = new System.Windows.Forms.CheckBox();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.chbhoras = new System.Windows.Forms.CheckBox();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.cdidEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.cdidPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupfecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbListadoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbRegistrarPermiso.SuspendLayout();
            this.grouphora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // groupfecha
            // 
            this.groupfecha.Controls.Add(this.dtpfechaFin);
            this.groupfecha.Controls.Add(this.label4);
            this.groupfecha.Controls.Add(this.label6);
            this.groupfecha.Controls.Add(this.dtpfechaInicio);
            this.groupfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.groupfecha.Location = new System.Drawing.Point(11, 40);
            this.groupfecha.Name = "groupfecha";
            this.groupfecha.Size = new System.Drawing.Size(188, 99);
            this.groupfecha.TabIndex = 2;
            this.groupfecha.TabStop = false;
            this.groupfecha.Text = "fecha";
            // 
            // dtpfechaFin
            // 
            this.dtpfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaFin.Location = new System.Drawing.Point(77, 55);
            this.dtpfechaFin.Name = "dtpfechaFin";
            this.dtpfechaFin.Size = new System.Drawing.Size(97, 20);
            this.dtpfechaFin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "fecha ini";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "fecha fin";
            // 
            // dtpfechaInicio
            // 
            this.dtpfechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaInicio.Location = new System.Drawing.Point(77, 28);
            this.dtpfechaInicio.Name = "dtpfechaInicio";
            this.dtpfechaInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpfechaInicio.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(92, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "&Justificar &Permisos";
            // 
            // gbListadoArea
            // 
            this.gbListadoArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListadoArea.Controls.Add(this.dgvPermisos);
            this.gbListadoArea.Controls.Add(this.btnListar);
            this.gbListadoArea.Controls.Add(this.lblAreasListado);
            this.gbListadoArea.Controls.Add(this.txtBEmpleado2);
            this.gbListadoArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.gbListadoArea.Location = new System.Drawing.Point(484, 69);
            this.gbListadoArea.Name = "gbListadoArea";
            this.gbListadoArea.Size = new System.Drawing.Size(529, 517);
            this.gbListadoArea.TabIndex = 2;
            this.gbListadoArea.TabStop = false;
            this.gbListadoArea.Text = "Listado Permisos";
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdidPermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(20, 81);
            this.dgvPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.RowHeadersWidth = 51;
            this.dgvPermisos.RowTemplate.Height = 24;
            this.dgvPermisos.Size = new System.Drawing.Size(487, 374);
            this.dgvPermisos.TabIndex = 2;
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
            this.btnListar.Location = new System.Drawing.Point(326, 28);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 35);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // lblAreasListado
            // 
            this.lblAreasListado.AutoSize = true;
            this.lblAreasListado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreasListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblAreasListado.Location = new System.Drawing.Point(15, 35);
            this.lblAreasListado.Name = "lblAreasListado";
            this.lblAreasListado.Size = new System.Drawing.Size(109, 26);
            this.lblAreasListado.TabIndex = 3;
            this.lblAreasListado.Text = "Empleado:";
            // 
            // txtBEmpleado2
            // 
            this.txtBEmpleado2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBEmpleado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBEmpleado2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBEmpleado2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBEmpleado2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBEmpleado2.Location = new System.Drawing.Point(138, 31);
            this.txtBEmpleado2.MaxLength = 6;
            this.txtBEmpleado2.Multiline = true;
            this.txtBEmpleado2.Name = "txtBEmpleado2";
            this.txtBEmpleado2.Size = new System.Drawing.Size(182, 27);
            this.txtBEmpleado2.TabIndex = 4;
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
            this.btnNuevo.Location = new System.Drawing.Point(347, 244);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarEmpleado);
            this.groupBox1.Controls.Add(this.gbRegistrarPermiso);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.dgvEmpleado);
            this.groupBox1.Controls.Add(this.txtBEmpleado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.groupBox1.Location = new System.Drawing.Point(19, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 565);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestionar Permiso";
            // 
            // btnListarEmpleado
            // 
            this.btnListarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnListarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListarEmpleado.FlatAppearance.BorderSize = 2;
            this.btnListarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnListarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnListarEmpleado.Location = new System.Drawing.Point(347, 31);
            this.btnListarEmpleado.Name = "btnListarEmpleado";
            this.btnListarEmpleado.Size = new System.Drawing.Size(86, 35);
            this.btnListarEmpleado.TabIndex = 6;
            this.btnListarEmpleado.Text = "&Listar";
            this.btnListarEmpleado.UseVisualStyleBackColor = false;
            // 
            // gbRegistrarPermiso
            // 
            this.gbRegistrarPermiso.Controls.Add(this.txtcodigo);
            this.gbRegistrarPermiso.Controls.Add(this.label7);
            this.gbRegistrarPermiso.Controls.Add(this.groupfecha);
            this.gbRegistrarPermiso.Controls.Add(this.btnCancelar);
            this.gbRegistrarPermiso.Controls.Add(this.btnAceptar);
            this.gbRegistrarPermiso.Controls.Add(this.txtmotivo);
            this.gbRegistrarPermiso.Controls.Add(this.label3);
            this.gbRegistrarPermiso.Controls.Add(this.grouphora);
            this.gbRegistrarPermiso.Controls.Add(this.chbfechas);
            this.gbRegistrarPermiso.Controls.Add(this.btnModificar2);
            this.gbRegistrarPermiso.Controls.Add(this.chbhoras);
            this.gbRegistrarPermiso.Controls.Add(this.btnAgragar);
            this.gbRegistrarPermiso.Enabled = false;
            this.gbRegistrarPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.gbRegistrarPermiso.Location = new System.Drawing.Point(30, 303);
            this.gbRegistrarPermiso.Name = "gbRegistrarPermiso";
            this.gbRegistrarPermiso.Size = new System.Drawing.Size(404, 256);
            this.gbRegistrarPermiso.TabIndex = 3;
            this.gbRegistrarPermiso.TabStop = false;
            this.gbRegistrarPermiso.Text = "Registrar Permiso";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtcodigo.Location = new System.Drawing.Point(308, 17);
            this.txtcodigo.MaxLength = 100;
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(86, 26);
            this.txtcodigo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(235, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Codigo:";
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
            this.btnCancelar.Location = new System.Drawing.Point(308, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(216, 206);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 35);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // txtmotivo
            // 
            this.txtmotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtmotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmotivo.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtmotivo.Location = new System.Drawing.Point(11, 165);
            this.txtmotivo.MaxLength = 150;
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(188, 76);
            this.txtmotivo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Motivo:";
            // 
            // grouphora
            // 
            this.grouphora.Controls.Add(this.label2);
            this.grouphora.Controls.Add(this.txtHorainicio);
            this.grouphora.Controls.Add(this.label1);
            this.grouphora.Controls.Add(this.txthorafin);
            this.grouphora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.grouphora.Location = new System.Drawing.Point(11, 40);
            this.grouphora.Name = "grouphora";
            this.grouphora.Size = new System.Drawing.Size(188, 88);
            this.grouphora.TabIndex = 33;
            this.grouphora.TabStop = false;
            this.grouphora.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hora ini:";
            // 
            // txtHorainicio
            // 
            this.txtHorainicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtHorainicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorainicio.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorainicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtHorainicio.Location = new System.Drawing.Point(79, 21);
            this.txtHorainicio.MaxLength = 6;
            this.txtHorainicio.Multiline = true;
            this.txtHorainicio.Name = "txtHorainicio";
            this.txtHorainicio.Size = new System.Drawing.Size(94, 25);
            this.txtHorainicio.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hora fin.:";
            // 
            // txthorafin
            // 
            this.txthorafin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txthorafin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthorafin.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorafin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txthorafin.Location = new System.Drawing.Point(79, 50);
            this.txthorafin.MaxLength = 6;
            this.txthorafin.Multiline = true;
            this.txthorafin.Name = "txthorafin";
            this.txthorafin.Size = new System.Drawing.Size(94, 25);
            this.txthorafin.TabIndex = 30;
            // 
            // chbfechas
            // 
            this.chbfechas.AutoSize = true;
            this.chbfechas.Location = new System.Drawing.Point(88, 17);
            this.chbfechas.Margin = new System.Windows.Forms.Padding(2);
            this.chbfechas.Name = "chbfechas";
            this.chbfechas.Size = new System.Drawing.Size(74, 17);
            this.chbfechas.TabIndex = 1;
            this.chbfechas.Text = "por fecha:";
            this.chbfechas.UseVisualStyleBackColor = true;
            this.chbfechas.CheckedChanged += new System.EventHandler(this.chbfechas_CheckedChanged);
            // 
            // btnModificar2
            // 
            this.btnModificar2.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificar2.FlatAppearance.BorderSize = 2;
            this.btnModificar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnModificar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificar2.Location = new System.Drawing.Point(308, 165);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(86, 35);
            this.btnModificar2.TabIndex = 11;
            this.btnModificar2.Text = "&Modificar";
            this.btnModificar2.UseVisualStyleBackColor = false;
            // 
            // chbhoras
            // 
            this.chbhoras.AutoSize = true;
            this.chbhoras.Location = new System.Drawing.Point(11, 17);
            this.chbhoras.Margin = new System.Windows.Forms.Padding(2);
            this.chbhoras.Name = "chbhoras";
            this.chbhoras.Size = new System.Drawing.Size(68, 17);
            this.chbhoras.TabIndex = 0;
            this.chbhoras.Text = "por hora:";
            this.chbhoras.UseVisualStyleBackColor = true;
            this.chbhoras.CheckedChanged += new System.EventHandler(this.chbhoras_CheckedChanged);
            // 
            // btnAgragar
            // 
            this.btnAgragar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgragar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgragar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAgragar.FlatAppearance.BorderSize = 2;
            this.btnAgragar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btnAgragar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAgragar.Location = new System.Drawing.Point(216, 165);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(86, 35);
            this.btnAgragar.TabIndex = 10;
            this.btnAgragar.Text = "&Agregar";
            this.btnAgragar.UseVisualStyleBackColor = false;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdidEmpleado,
            this.cdNombres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleado.Location = new System.Drawing.Point(29, 80);
            this.dgvEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleado.MultiSelect = false;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleado.Size = new System.Drawing.Size(404, 159);
            this.dgvEmpleado.TabIndex = 2;
            // 
            // cdidEmpleado
            // 
            this.cdidEmpleado.DataPropertyName = "idEmpleado";
            this.cdidEmpleado.HeaderText = "idEmpleado";
            this.cdidEmpleado.Name = "cdidEmpleado";
            this.cdidEmpleado.ReadOnly = true;
            // 
            // cdNombres
            // 
            this.cdNombres.DataPropertyName = "nombres";
            this.cdNombres.HeaderText = "nombres";
            this.cdNombres.Name = "cdNombres";
            this.cdNombres.ReadOnly = true;
            this.cdNombres.Width = 150;
            // 
            // txtBEmpleado
            // 
            this.txtBEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBEmpleado.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBEmpleado.Location = new System.Drawing.Point(136, 34);
            this.txtBEmpleado.MaxLength = 100;
            this.txtBEmpleado.Multiline = true;
            this.txtBEmpleado.Name = "txtBEmpleado";
            this.txtBEmpleado.Size = new System.Drawing.Size(172, 27);
            this.txtBEmpleado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(25, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empleado:";
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(972, 29);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 34);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 39;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // cdidPermiso
            // 
            this.cdidPermiso.DataPropertyName = "Codigo";
            this.cdidPermiso.HeaderText = "id";
            this.cdidPermiso.Name = "cdidPermiso";
            this.cdidPermiso.ReadOnly = true;
            // 
            // frmPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1046, 643);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbListadoArea);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermiso";
            this.Text = "frmPermiso";
            this.Load += new System.EventHandler(this.frmPermiso_Load);
            this.groupfecha.ResumeLayout(false);
            this.groupfecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbListadoArea.ResumeLayout(false);
            this.gbListadoArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRegistrarPermiso.ResumeLayout(false);
            this.gbRegistrarPermiso.PerformLayout();
            this.grouphora.ResumeLayout(false);
            this.grouphora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupfecha;
        private System.Windows.Forms.DateTimePicker dtpfechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfechaInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbListadoArea;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblAreasListado;
        private System.Windows.Forms.TextBox txtBEmpleado2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbRegistrarPermiso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grouphora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorainicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthorafin;
        private System.Windows.Forms.CheckBox chbfechas;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.CheckBox chbhoras;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TextBox txtBEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button btnListarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdidEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdidPermiso;
    }
}