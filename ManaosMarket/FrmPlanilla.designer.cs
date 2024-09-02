namespace ManaosMarket
{
    partial class FrmPlanilla
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
            this.GbPlanilla = new System.Windows.Forms.GroupBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvPlanilla = new System.Windows.Forms.DataGridView();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbPlanilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // GbPlanilla
            // 
            this.GbPlanilla.BackColor = System.Drawing.Color.Silver;
            this.GbPlanilla.Controls.Add(this.Btn_Modificar);
            this.GbPlanilla.Controls.Add(this.BtnEliminar);
            this.GbPlanilla.Controls.Add(this.BtnAgregar);
            this.GbPlanilla.Controls.Add(this.DgvPlanilla);
            this.GbPlanilla.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GbPlanilla.Location = new System.Drawing.Point(9, 124);
            this.GbPlanilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbPlanilla.Name = "GbPlanilla";
            this.GbPlanilla.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbPlanilla.Size = new System.Drawing.Size(747, 244);
            this.GbPlanilla.TabIndex = 0;
            this.GbPlanilla.TabStop = false;
            this.GbPlanilla.Text = "Planilla";
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Modificar.Location = new System.Drawing.Point(648, 139);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(76, 32);
            this.Btn_Modificar.TabIndex = 4;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnEliminar.Location = new System.Drawing.Point(648, 80);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(76, 36);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAgregar.Location = new System.Drawing.Point(648, 34);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(76, 28);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // DgvPlanilla
            // 
            this.DgvPlanilla.AllowUserToAddRows = false;
            this.DgvPlanilla.AllowUserToDeleteRows = false;
            this.DgvPlanilla.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlanilla.Location = new System.Drawing.Point(28, 34);
            this.DgvPlanilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvPlanilla.Name = "DgvPlanilla";
            this.DgvPlanilla.ReadOnly = true;
            this.DgvPlanilla.RowHeadersWidth = 51;
            this.DgvPlanilla.RowTemplate.Height = 24;
            this.DgvPlanilla.Size = new System.Drawing.Size(592, 175);
            this.DgvPlanilla.TabIndex = 0;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Location = new System.Drawing.Point(9, 45);
            this.Lbl_Empleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Empleado.TabIndex = 1;
            this.Lbl_Empleado.Text = "Empleado";
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Location = new System.Drawing.Point(66, 45);
            this.TxtEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.Size = new System.Drawing.Size(220, 20);
            this.TxtEmpleado.TabIndex = 2;
            // 
            // BtnListar
            // 
            this.BtnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnListar.Location = new System.Drawing.Point(308, 45);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(76, 28);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnGuardar.Location = new System.Drawing.Point(37, 372);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(76, 28);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "&Reporte";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(765, 424);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.TxtEmpleado);
            this.Controls.Add(this.Lbl_Empleado);
            this.Controls.Add(this.GbPlanilla);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPlanilla";
            this.Text = "Planilla";
            this.Load += new System.EventHandler(this.FrmPlanilla_Load);
            this.GbPlanilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbPlanilla;
        private System.Windows.Forms.DataGridView DgvPlanilla;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}

