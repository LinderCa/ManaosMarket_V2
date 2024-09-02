namespace ManaosMarket
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnEscalafon = new System.Windows.Forms.Button();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuEscalafon = new System.Windows.Forms.ToolStrip();
            this.tlsmenuEmpleado = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslmenuArea = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsmenuEncargatura = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslmenuTardanza = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tslmenuPermisos = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tslmenuContrato = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tslmenuVacaciones = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsmenuSalir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuEscalafon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnEscalafon);
            this.panel1.Controls.Add(this.btnRegistrarAsistencia);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 900);
            this.panel1.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAyuda.Location = new System.Drawing.Point(0, 432);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(262, 50);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "&Ayuda                                       ";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            this.btnAyuda.Leave += new System.EventHandler(this.btnRegistrarAsistencia_Leave);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(0, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(262, 50);
            this.button8.TabIndex = 3;
            this.button8.Text = "&Planilla              ";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVer.Location = new System.Drawing.Point(0, 376);
            this.btnVer.Name = "btnVer";
            this.btnVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVer.Size = new System.Drawing.Size(262, 50);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "&Ver                                           ";
            this.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            this.btnVer.Leave += new System.EventHandler(this.btnRegistrarAsistencia_Leave);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(0, 329);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(262, 50);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "&Reportes               ";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.Leave += new System.EventHandler(this.btnRegistrarAsistencia_Leave);
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(0, 850);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(262, 50);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "&Configuracion";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.Leave += new System.EventHandler(this.btnRegistrarAsistencia_Leave);
            // 
            // btnEscalafon
            // 
            this.btnEscalafon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscalafon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEscalafon.FlatAppearance.BorderSize = 0;
            this.btnEscalafon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscalafon.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalafon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEscalafon.Image = ((System.Drawing.Image)(resources.GetObject("btnEscalafon.Image")));
            this.btnEscalafon.Location = new System.Drawing.Point(0, 223);
            this.btnEscalafon.Name = "btnEscalafon";
            this.btnEscalafon.Size = new System.Drawing.Size(262, 50);
            this.btnEscalafon.TabIndex = 2;
            this.btnEscalafon.Text = "&Gestion &Escalafon    ";
            this.btnEscalafon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEscalafon.UseVisualStyleBackColor = true;
            this.btnEscalafon.Click += new System.EventHandler(this.btnEscalafon_Click);
            this.btnEscalafon.Leave += new System.EventHandler(this.btnRegistrarAsistencia_Leave);
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRegistrarAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarAsistencia.Image")));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(0, 173);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(262, 50);
            this.btnRegistrarAsistencia.TabIndex = 2;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            this.btnRegistrarAsistencia.Leave += new System.EventHandler(this.btnRegistrarAsistencia_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 173);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(71, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manos Market";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema Recursos Humanos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManaosMarket.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.close);
            this.panel3.Location = new System.Drawing.Point(262, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1238, 32);
            this.panel3.TabIndex = 2;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1194, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 34);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlContenedor.Location = new System.Drawing.Point(262, 58);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1238, 863);
            this.pnlContenedor.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.menuEscalafon);
            this.panel4.Location = new System.Drawing.Point(264, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1236, 29);
            this.panel4.TabIndex = 0;
            // 
            // menuEscalafon
            // 
            this.menuEscalafon.AccessibleName = "";
            this.menuEscalafon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.menuEscalafon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEscalafon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsmenuEmpleado,
            this.toolStripSeparator1,
            this.tslmenuArea,
            this.toolStripSeparator3,
            this.tlsmenuEncargatura,
            this.toolStripSeparator2,
            this.tslmenuTardanza,
            this.toolStripSeparator5,
            this.tslmenuPermisos,
            this.toolStripSeparator6,
            this.tslmenuContrato,
            this.toolStripSeparator7,
            this.tslmenuVacaciones,
            this.toolStripSeparator8,
            this.tlsmenuSalir,
            this.toolStripSeparator4});
            this.menuEscalafon.Location = new System.Drawing.Point(0, 0);
            this.menuEscalafon.Name = "menuEscalafon";
            this.menuEscalafon.Size = new System.Drawing.Size(1236, 30);
            this.menuEscalafon.TabIndex = 14;
            this.menuEscalafon.Text = "toolStrip1";
            this.menuEscalafon.Visible = false;
            // 
            // tlsmenuEmpleado
            // 
            this.tlsmenuEmpleado.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsmenuEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tlsmenuEmpleado.Name = "tlsmenuEmpleado";
            this.tlsmenuEmpleado.Size = new System.Drawing.Size(108, 27);
            this.tlsmenuEmpleado.Text = "&Empleado";
            this.tlsmenuEmpleado.Click += new System.EventHandler(this.tlsmenuEmpleado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tslmenuArea
            // 
            this.tslmenuArea.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.tslmenuArea.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslmenuArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tslmenuArea.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslmenuArea.Name = "tslmenuArea";
            this.tslmenuArea.Size = new System.Drawing.Size(58, 27);
            this.tslmenuArea.Text = "&Area";
            this.tslmenuArea.Click += new System.EventHandler(this.tslmenuArea_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // tlsmenuEncargatura
            // 
            this.tlsmenuEncargatura.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsmenuEncargatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tlsmenuEncargatura.Name = "tlsmenuEncargatura";
            this.tlsmenuEncargatura.Size = new System.Drawing.Size(129, 27);
            this.tlsmenuEncargatura.Text = "&Encargatura";
            this.tlsmenuEncargatura.Click += new System.EventHandler(this.tlsmenuEncargatura_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tslmenuTardanza
            // 
            this.tslmenuTardanza.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslmenuTardanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tslmenuTardanza.Name = "tslmenuTardanza";
            this.tslmenuTardanza.Size = new System.Drawing.Size(104, 27);
            this.tslmenuTardanza.Text = "&Tardanza";
            this.tslmenuTardanza.Click += new System.EventHandler(this.tslmenuTardanza_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // tslmenuPermisos
            // 
            this.tslmenuPermisos.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslmenuPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tslmenuPermisos.Name = "tslmenuPermisos";
            this.tslmenuPermisos.Size = new System.Drawing.Size(101, 27);
            this.tslmenuPermisos.Text = "&Permisos";
            this.tslmenuPermisos.Click += new System.EventHandler(this.tslmenuPermisos_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 30);
            // 
            // tslmenuContrato
            // 
            this.tslmenuContrato.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslmenuContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tslmenuContrato.Name = "tslmenuContrato";
            this.tslmenuContrato.Size = new System.Drawing.Size(95, 27);
            this.tslmenuContrato.Text = "&Contrato";
            this.tslmenuContrato.Click += new System.EventHandler(this.tslmenuContrato_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 30);
            // 
            // tslmenuVacaciones
            // 
            this.tslmenuVacaciones.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslmenuVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tslmenuVacaciones.Name = "tslmenuVacaciones";
            this.tslmenuVacaciones.Size = new System.Drawing.Size(125, 27);
            this.tslmenuVacaciones.Text = "&Vacaciones";
            this.tslmenuVacaciones.Click += new System.EventHandler(this.tslmenuVacaciones_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 30);
            // 
            // tlsmenuSalir
            // 
            this.tlsmenuSalir.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsmenuSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.tlsmenuSalir.Name = "tlsmenuSalir";
            this.tlsmenuSalir.Size = new System.Drawing.Size(74, 27);
            this.tlsmenuSalir.Text = "&SALIR";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuEscalafon.ResumeLayout(false);
            this.menuEscalafon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEscalafon;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip menuEscalafon;
        private System.Windows.Forms.ToolStripLabel tlsmenuEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslmenuArea;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tlsmenuEncargatura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tlsmenuSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tslmenuTardanza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel tslmenuPermisos;
        private System.Windows.Forms.ToolStripLabel tslmenuContrato;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel tslmenuVacaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Button button8;
    }
}

