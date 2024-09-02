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
    public partial class CONTRATO : Form
    {
        List<Contrato> contratos = new List<Contrato>();
        private Contrato contra;
        private Sueldo sueldo;
        private Horario horario;


        public CONTRATO()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RNContrato rn = new RNContrato();

            contra = new Contrato()
            {
                FechaInicio = this.dateTimePickerFechaInicio.Value,
                Vigencia = this.chkVigencia.Checked,
                FechaFin = this.dateTimePickerFechaFin.Value,
                Tipo = this.cmbTipo.SelectedItem.ToString(),
                Empleado = new clsEmpleado
                {
                    idEmpleado = this.txtEmpleado.Text,
                }
            };

            // Verificar si el empleado ya tiene contrato
            if (rn.VerificarEmpleadoContratoExistente(txtEmpleado.Text))
            {
                MessageBox.Show("El empleado ya tiene un contrato registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sueldo = new Sueldo()
            {
                monto = Convert.ToDouble(this.nudMonto.Value),
            };

            horario = new Horario()
            {
                horaEntrada = TimeSpan.Parse(this.mskHoraEntrada.Text),
                horaSalida = TimeSpan.Parse(this.mskHoraSalida.Text),
            };

            rn.RegistrarAmbos(contra, sueldo, horario);

            Form1_Load(sender, e);
            this.gbRegistroContrato.Enabled = false;
            this.gbListado.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RNContrato rn = new RNContrato();
            DialogResult respuesta;
            if (this.dataGridViewEmpleados.CurrentRow != null)
            {
                respuesta = MessageBox.Show("¿Está seguro que desea eliminar este Contrato?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (respuesta == DialogResult.Yes)
                {
                    var eliminar = (Contrato)this.dataGridViewEmpleados.CurrentRow.DataBoundItem;
                    rn.EliminarContrato(eliminar);
                    Form1_Load(sender,e);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listarContratos();//DATAGRIDVIEW
        }

        private void listarContratos()
        {
            RNContrato rn = new RNContrato();

            try
            {
                contratos = rn.listarTodo();
                this.dataGridViewEmpleados.DataSource = null;
                if (contratos.Count > 0)
                {
                    this.dataGridViewEmpleados.AutoGenerateColumns = false;
                    this.dataGridViewEmpleados.DataSource = contratos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al Cargar los contratos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este método puede dejarse vacío si no se utiliza para ninguna acción específica
        }

        private void dataGridViewEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mskHoraEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.gbRegistroContrato.Enabled = true;
            this.gbListado.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.gbRegistroContrato.Enabled = false;
            this.gbListado.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            RNContrato rnC = new RNContrato();
            List<Contrato> listadobusqueda = new List<Contrato>();
            List<Contrato> listadoGeneral = new List<Contrato>();

            try
            {
                listadobusqueda = rnC.buscarContratos(this.txtBuscar.Text);
                listadoGeneral = rnC.listarTodo();
                if (listadobusqueda.Count > 0 && listadobusqueda != null)
                {
                    this.dataGridViewEmpleados.DataSource = listadobusqueda;
                }
                else
                {
                    this.dataGridViewEmpleados.DataSource = listadoGeneral;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR en el listado de busqueda");
            }
        }
    }
}
