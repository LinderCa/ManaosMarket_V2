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
    public partial class frmEmpleado : Form
    {
        private clsEmpleado Actual = null;
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;
            if (this.gbEmpleado.Visible == true)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            ActivarComponentes(true);
        }

        private void limpiarComponentes()
        {
            this.txtcodigo.Text = "";
            this.txtNombres.Text = "";
            this.txtApellPaterno.Text = "";
            this.txtApellMaterno.Text = "";
            this.txtDni.Text = "";
            //this.cmbGenero.SelectedIndex = 0;
            this.dtpFechaNacimiento.Text = DateTime.Now.ToString("01/01/1999");
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
            this.txtCorreo.Text = "";
            this.chkVigente.Checked = false;
        }

        private void ActivarComponentes(bool estado)
        {
            this.gbEmpleado.Enabled = estado;
            this.gbListadoEmpleado.Enabled = !estado;
            if (estado == true)
            {
                this.txtListadoEmpleado.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarComponentes(false);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancelar la tecla presionada
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clsEmpleado nuevo = null;
            rnEmpleado rn = null;
            try
            {
                nuevo = crearEntidad();
                rn = new rnEmpleado();
                if (this.Actual == null)
                {
                    //Se trata de un empleado nuevo
                    rn.Registrar(nuevo);
                }
                else
                {
                    rn.Actualizar(nuevo);
                }
                this.ActivarComponentes(false);
                this.btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar el registro ", this.Text);
            }
        }

        private clsEmpleado crearEntidad()
        {
            clsEmpleado empleado = new clsEmpleado()
            {
                idEmpleado = this.txtcodigo.Text,
                nombres = this.txtNombres.Text,
                apellPaterno = this.txtApellPaterno.Text,
                apellMaterno = this.txtApellMaterno.Text,
                dni = this.txtDni.Text,
                genero = (this.cmbGenero.Text).Substring(0, 1),
                fechaNacimiento = this.dtpFechaNacimiento.Value, //dd/MM/yyyy 00:00:00
                telefono = this.txtTelefono.Text,
                direccion = this.txtDireccion.Text,
                correo = this.txtCorreo.Text,
                vigente = this.chkVigente.Checked, //Devuelve un objeto true o false
            };
            if (this.Actual != null)
            {
                empleado.idEmpleado = this.Actual.idEmpleado;
            }
            return empleado;

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            rnEmpleado rn = new rnEmpleado();

            try
            {
                List<clsEmpleado> empleados = rn.ListarEmpleados();
                this.dgvEmpleado.DataSource = null;
                if (empleados.Count > 0)
                {
                    this.dgvEmpleado.AutoGenerateColumns = false;
                    this.dgvEmpleado.DataSource = empleados;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("no se pudo listar ningun empleados de la BD");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            rnEmpleado rn = new rnEmpleado();
            List<clsEmpleado> listaEmpleados = rn.ListarEmpleadosFiltro(this.txtListadoEmpleado.Text);
            try
            {
                this.dgvEmpleado.DataSource = null;
                if (listaEmpleados.Count > 0)
                {
                    this.dgvEmpleado.AutoGenerateColumns = false;
                    this.dgvEmpleado.DataSource = listaEmpleados;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("no se pudo listar a los empleados");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dgvEmpleado.CurrentRow != null)
            {
                //Se ha seleccionado una fila
                this.Actual = (clsEmpleado)this.dgvEmpleado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo seleccionar ningun empleado");
            }

        }

        private void PresentarDatos()
        {
            rnEmpleado rn = new rnEmpleado();
            try
            {
                this.Actual = rn.Leer(Actual.idEmpleado);
                
                if (this.Actual != null)
                {
                    MessageBox.Show(this.Actual.genero);
                    this.txtcodigo.Text = this.Actual.idEmpleado;
                    this.txtNombres.Text = this.Actual.nombres;
                    this.txtApellPaterno.Text = this.Actual.apellPaterno;
                    this.txtApellMaterno.Text = this.Actual.apellMaterno;
                    this.txtDni.Text = this.Actual.dni;
                    this.cmbGenero.SelectedIndex = "MF".IndexOf(this.Actual.genero);
                    this.dtpFechaNacimiento.Value = this.Actual.fechaNacimiento;
                    this.txtTelefono.Text = this.Actual.telefono;
                    this.txtDireccion.Text = this.Actual.direccion;
                    this.txtCorreo.Text = this.Actual.correo;
                    this.chkVigente.Checked = this.Actual.vigente;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos solicitados");
                }
                this.ActivarComponentes(true);
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo obtener los datos solicitados");
            }


            
        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {
            frmCarnetEmpleado carnet = new frmCarnetEmpleado();
            carnet.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEncargatura encargatura = new frmEncargatura();
            encargatura.ShowDialog();
        }
    }
}