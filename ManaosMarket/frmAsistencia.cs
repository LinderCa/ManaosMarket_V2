using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaosMarket
{
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            //  
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                rnAsistencia rn = null;
                clsAsistencia asistencia = CrearAsistencia();

                rn = new rnAsistencia();
                rn.Registrar(asistencia);
                evaluarAsistencia(asistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar el registro ", this.Text);
            }


            //REgistramos la asistencia del empleado
        }

        private void evaluarAsistencia(clsAsistencia asistencia)
        {
            rnTardanzas rn = new rnTardanzas();
            //Evaluacion si corresponde una tardanza
            if(asistencia.horaLlegada > TimeSpan.Parse("08:00:00"))
            {
                //Registramos una tardanza al empleado
                clsTardanza tardanza = new clsTardanza()
                {
                    horasTardanza = (int)asistencia.horaLlegada.Hours - 8,
                    estado=false,
                    idEmpleado=asistencia.idEmpleado
                };
                rn.Registrar(tardanza);
            }
        }

        private clsAsistencia CrearAsistencia()
        {
            clsAsistencia asistencia = new clsAsistencia()
            {
                estado = true,
                //fecha = DateTime.Now.ToString("yyyy/MM/dd"),
                horaLlegada = TimeSpan.Parse(this.txtHoraPrueba.Text),
                idEmpleado = this.txtCodigo.Text,
            };
            return asistencia;
        }
    }
}
