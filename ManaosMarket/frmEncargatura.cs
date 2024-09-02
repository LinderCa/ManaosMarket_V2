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
    public partial class frmEncargatura : Form
    {
        private clsEncargatura Actual = null;
        private clsEmpleado ActualEmpleado = null;

        public frmEncargatura()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            rnEncargatura rn = null;
            clsEncargatura encargatura = null;
            try
            {

                rn = new rnEncargatura();
                encargatura = CrearEntidad();
                if (this.Actual == null)
                {
                    //Se trata de una nueva encargatura
                    rn.Registrar(encargatura);
                }
                else
                {
                    //Se trata de una encargatura modificada
                }
                this.ActivarComponentes(false);
                this.btnListar.PerformClick();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar el registro de encargatura");
            }
        }

        private clsEncargatura CrearEntidad()
        {
            clsEncargatura encargatura = new clsEncargatura()
            {
                nombre = this.txtEncargatura.Text,
                idEmpleado=this.txtEmpleado.Text,
                idArea = (int)this.cmbArea.SelectedValue
            };
            return encargatura;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarComponentes(true);
            if (this.dgvEmpleado.CurrentRow != null)
            {
                //Se ha seleccionado una fila
                this.ActualEmpleado = (clsEmpleado)this.dgvEmpleado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo seleccionar ningun empleado");
            }
            PresentarDatos();
        }



      




        private void PresentarDatos()
        {
            rnEmpleado rn = new rnEmpleado();
            try
            {
                this.ActualEmpleado = rn.Leer(ActualEmpleado.idEmpleado);

                if (this.ActualEmpleado != null)
                {
                    this.txtEmpleado.Text = this.ActualEmpleado.idEmpleado;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos solicitados");
                }
                this.ActivarComponentes(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los datos solicitados");
            }
        }

        private void ActivarComponentes(bool estado)
        {
            this.gbEncargatura.Enabled = estado;
            this.gbListadoEncargatura.Enabled = !estado;

            if (estado == true)
            {
                this.txtEncargatura.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarComponentes(false);
        }

        private void frmEncargatura_Load(object sender, EventArgs e)
        {
            //Cargamos todos los empleados
            cargarEmpleados();
            //Listar las areas
            this.listarAreas();

            //Listamos los empleados ya registramos con encargatura
           // this.empleadosEncargatura();
        }

        private void cargarEmpleados()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo listar ningun empleados de la BD");
            }
        }


        private void listarAreas()
        {
            rnArea rn = new rnArea();
            List<clsArea> areas = rn.listado();
            try
            {
                this.cmbArea.DataSource = null;
                if (areas != null && areas.Count > 0)
                {
                    this.cmbArea.ValueMember = "idArea";
                    this.cmbArea.DisplayMember = "nombre";
                    this.cmbArea.DataSource = areas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo listas los Empleados");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            rnEmpleado rn = new rnEmpleado();
            List<clsEmpleado> listaEmpleados = rn.ListarEmpleadosFiltro(this.txtEmpleadoFiltro.Text);
            try
            {
                this.dgvEmpleado.DataSource = null;
                if (listaEmpleados.Count > 0)
                {
                    this.dgvEmpleado.AutoGenerateColumns = false;
                    this.dgvEmpleado.DataSource = listaEmpleados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo listar a los empleados");
            }
        }
    }
}
