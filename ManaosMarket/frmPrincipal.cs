using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;

namespace ManaosMarket
{
    public partial class frmPrincipal : Form
    {
        [DllImport("Gdi32.dll",EntryPoint="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightReact,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipese
            );
        public frmPrincipal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnRegistrarAsistencia.Height;
            pnlNav.Top = btnRegistrarAsistencia.Top;
            pnlNav.Left = btnRegistrarAsistencia.Left;
            btnRegistrarAsistencia.BackColor = Color.FromArgb(46, 51, 73);
        }

        public void mostrarMenuEscalafon(bool estado)
        {
            menuEscalafon.Visible = estado;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //
        }

        //Funcion
        private void abrirFrmAsistencia(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Anchor = AnchorStyles.None;
            fh.Location = new Point((pnlContenedor.Width - fh.Width) / 2, (pnlContenedor.Height - fh.Height) / 2);
            //fh.StartPosition = FormStartPosition.CenterParent;
            //fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }
        private void abrirVenatanaCompleta(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRegistrarAsistencia.Height;
            pnlNav.Top = btnRegistrarAsistencia.Top;
            pnlNav.Left = btnRegistrarAsistencia.Left;
            btnRegistrarAsistencia.BackColor = Color.FromArgb(46, 51, 73);

            //Abrimos la ventana de asistencia
            abrirFrmAsistencia(new frmAsistencia());
        }

        private void btnEscalafon_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEscalafon.Height;
            pnlNav.Top = btnEscalafon.Top;
            pnlNav.Left = btnEscalafon.Left;
            btnEscalafon.BackColor = Color.FromArgb(46, 51, 73);

            //Abrir ventana
            abrirFrmAsistencia(new frmUsuarioAdministrador(this));
        }

  

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReportes.Height;
            pnlNav.Top = btnReportes.Top;
            pnlNav.Left = btnReportes.Left;
            btnReportes.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConfig.Height;
            pnlNav.Top = btnConfig.Top;
            pnlNav.Left = btnConfig.Left;
            btnConfig.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnVer.Height;
            pnlNav.Top = btnVer.Top;
            pnlNav.Left = btnVer.Left;
            btnVer.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAyuda.Height;
            pnlNav.Top = btnAyuda.Top;
            pnlNav.Left = btnAyuda.Left;
            btnAyuda.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRegistrarAsistencia_Leave(object sender, EventArgs e)
        {
            ((Button)(sender)).BackColor = Color.FromArgb(24, 30, 54);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;
            if (this.pnlContenedor.Controls.Count > 0)
            {
                respuesta = MessageBox.Show("Una ventana se encuentra abierta\n" + "Estas seguro de salir?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tslmenuArea_Click(object sender, EventArgs e)
        {
            abrirFrmAsistencia(new frmArea());
        }

        private void tlsmenuEmpleado_Click(object sender, EventArgs e)
        {
            abrirFrmAsistencia(new frmEmpleado());
        }

        private void tlsmenuEncargatura_Click(object sender, EventArgs e)
        {
            abrirFrmAsistencia(new frmEncargatura());
        }

        private void tslmenuContrato_Click(object sender, EventArgs e)
        {
            abrirFrmAsistencia(new CONTRATO());
        }

        private void tslmenuTardanza_Click(object sender, EventArgs e)
        {
                abrirFrmAsistencia(new frmTardanza());
        }

        private void tslmenuPermisos_Click(object sender, EventArgs e)
        {
            abrirFrmAsistencia(new frmPermiso());
        }

        private void tslmenuVacaciones_Click(object sender, EventArgs e)
        {
            abrirFrmAsistencia(new FrmPlanilla());
        }

    }
}
