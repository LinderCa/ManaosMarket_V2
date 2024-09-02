using System;
using Entidades;
using ReglasNegocio;
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
   
    public partial class frmPermiso : Form
    {
        String idpermiso;
        Int32 numeroDias;

        public clsEmpleado Actual = null;

        public frmPermiso()
        {
            InitializeComponent();
        }
        private void cargarPermisos()
        {
            clsmPermiso rn= new clsmPermiso();
            List<clsPermiso> permisos = new List<clsPermiso>();
            try
            {
                permisos = rn.ListarPermisos();
                if (permisos.Count > 0)
                {
                    this.dgvPermisos.DataSource = null;
                    this.dgvPermisos.AutoGenerateColumns = false;
                    this.dgvPermisos.DataSource = permisos;
                }
                else
                {
                    MessageBox.Show("No se pudo cargar los permisos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        
        private void frmPermiso_Load(object sender, EventArgs e)
        {
            cargarPermisos();
            btnModificar2.Enabled = false;
            groupfecha.Visible = false;
            grouphora.Visible = false;
            cargarEmpleados();
        }

        private void cargarEmpleados()
        {
            rnEmpleado rn = new rnEmpleado();
            List<clsEmpleado> empleados = rn.ListarEmpleados();
            if (empleados.Count > 0)
            {
                this.dgvEmpleado.DataSource = null;
                this.dgvEmpleado.AutoGenerateColumns = false;
                this.dgvEmpleado.DataSource = empleados;
            }
        }

        private void chbhoras_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbhoras.Checked)
            {
                chbfechas.Checked = false;
                groupfecha.Visible = false;
                grouphora.Visible = true;
            }
        }

        private void chbfechas_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbfechas.Checked)
            {
                chbhoras.Checked = false;
                grouphora.Visible = false;
                groupfecha.Visible = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPermisos.RowCount != 0)
            {
                int fila = dgvPermisos.CurrentCell.RowIndex;
                txtcodigo.Text = dgvPermisos[0, fila].Value.ToString();
                txtHorainicio.Text = dgvPermisos[3, fila].Value.ToString();
                txthorafin.Text = dgvPermisos[4, fila].Value.ToString();
                dtpfechaInicio.Text = dgvPermisos[5, fila].Value.ToString();
                dtpfechaFin.Text = dgvPermisos[6, fila].Value.ToString();
                txtmotivo.Text = dgvPermisos[8, fila].Value.ToString();

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Activamos controles
            this.gbRegistrarPermiso.Enabled = true;
            //Verificamos que se ha seleccionado algo de el data gried view
            if(this.dgvEmpleado.CurrentRow != null)
            {
                this.Actual = (clsEmpleado)this.dgvEmpleado.CurrentRow.DataBoundItem;
                this.txtcodigo.Text = this.Actual.idEmpleado;
            }
            else
            {
                MessageBox.Show("No se pudo seleccionar ningun empleado");
            }
        }

        //private void btnNuevo_Click(object sender, EventArgs e)
        //{
        //    grupoDatos.Enabled = true;
        //    btnNuevo.Enabled = false;
        //    btnGuardar.Enabled = true;
        //}

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    clsAlumno obj;
        //    clsAlumnoAD objAD = new clsAlumnoAD();
        //    try
        //    {
        //        obj = new clsAlumno(txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtApPaterno.Text.Trim(), txtApMaterno.Text.Trim(), tmFechaNac.Value, cmbGenero.SelectedIndex - 1, txtDireccion.Text.Trim(), Convert.ToInt32(cmbEscuela.SelectedValue), cmbEstado.SelectedIndex);
        //        objAD.agregar(obj);
        //        MessageBox.Show("Alumno agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        limpiar();
        //        cargarAlumnos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR: " + ex.Message);
        //    }
        //}

        //private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgvDatos.CurrentRow.Index != -1)
        //    {
        //        txtCodigo.Text = dgvDatos.SelectedRows[0].Cells[0].Value.ToString();
        //        txtNombre.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
        //        txtApPaterno.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
        //        txtApMaterno.Text = dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
        //        tmFechaNac.Value = Convert.ToDateTime(dgvDatos.SelectedRows[0].Cells[4].Value);
        //        cmbGenero.SelectedIndex = Convert.ToBoolean(dgvDatos.SelectedRows[0].Cells[5].Value) ? 2 : 1;
        //        txtDireccion.Text = dgvDatos.SelectedRows[0].Cells[6].Value.ToString();
        //        cmbEstado.SelectedIndex = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[7].Value);
        //        cmbEscuela.SelectedValue = dgvDatos.SelectedRows[0].Cells[8].Value;
        //        txtCodigo.Enabled = false;
        //        btnNuevo.Enabled = false;
        //        btnModificar.Enabled = true;
        //        grupoDatos.Enabled = true;
        //    }
        //}

        //private void limpiar()
        //{
        //    txtCodigo.Text = "";
        //    txtNombre.Text = "";
        //    txtApPaterno.Text = "";
        //    txtApMaterno.Text = "";
        //    tmFechaNac.Text = "";
        //    txtDireccion.Text = "";
        //    btnGuardar.Enabled = false;
        //    btnModificar.Enabled = false;
        //    grupoDatos.Enabled = false;
        //    btnNuevo.Enabled = true;
        //    txtCodigo.Enabled = true;
        //    cmbEstado.SelectedIndex = 0;
        //    cmbGenero.SelectedIndex = 0;
        //    cmbEscuela.SelectedIndex = -1;
        //}

        //private void frmMantenimientoAlumno_Load(object sender, EventArgs e)
        //{
        //    cargarAlumnos();
        //    cargarEscuelas();
        //    cmbEstado.SelectedIndex = 0;
        //    cmbGenero.SelectedIndex = 0;
        //    cmbEscuela.SelectedIndex = -1;
        //}

        //private void btnLimpiar_Click(object sender, EventArgs e)
        //{
        //    limpiar();
        //}

        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    clsAlumno obj;
        //    clsAlumnoAD objAD = new clsAlumnoAD();
        //    try
        //    {
        //        obj = new clsAlumno(txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtApPaterno.Text.Trim(), txtApMaterno.Text.Trim(), tmFechaNac.Value, cmbGenero.SelectedIndex - 1, txtDireccion.Text.Trim(), Convert.ToInt32(cmbEscuela.SelectedValue), cmbEstado.SelectedIndex);
        //        objAD.modificar(obj);
        //        MessageBox.Show("Alumno modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        limpiar();
        //        cargarAlumnos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR: " + ex.Message);
        //    }
        //}

    }
}
