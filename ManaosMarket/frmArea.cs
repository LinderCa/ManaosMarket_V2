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
    public partial class frmArea : Form
    {
        private clsArea Actual = null;

        public frmArea()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            ActivarComponentes(true);
        }

        private void ActivarComponentes(bool estado)
        {
                this.gbArea.Enabled = estado;
                this.gbListadoArea.Enabled = !estado;
            if (estado==true)
            {
                this.txtListadoAreas.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Declaramos una variable de rnArea
            rnArea rn = null;
            clsArea nuevaArea = null;

            try
            {
                //Se crea un nueva Area
                nuevaArea = CrearArea();
                rn = new rnArea();
                //Verificamos si es un nuevo elemento o es elemento a modificar
                if (this.Actual == null)
                {
                    rn.Registrar(nuevaArea);
                }
                else
                {
                    rn.Actualizar(nuevaArea);
                }
                this.ActivarComponentes(false);
                this.btnListar.PerformClick();
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operacion", this.Text);
            }
        }

        private void limpiarComponentes()
        {
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.chkVigente.Checked = false;
        }

        private clsArea CrearArea()
        {
            clsArea nuevaArea = new clsArea()
            {
                nombre = this.txtNombre.Text,
                descripcion = this.txtDescripcion.Text,
                vigente = this.chkVigente.Checked,
            };
            if(this.Actual != null)
            {
                nuevaArea.idArea = this.Actual.idArea;
            }
            return nuevaArea;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarComponentes(false);
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            //Cargamos en el Combo Box, antes de inicializar el formulario
            //Traemos los datos de la BD 
            rnArea rn = new rnArea();
            try
            {
                List<clsArea> listadoAreas = rn.listado();
                this.dgvAreas.DataSource = null;
                if (listadoAreas.Count > 0)
                {
                    this.dgvAreas.AutoGenerateColumns = false;
                    this.dgvAreas.DataSource = listadoAreas;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo listar las Areas");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            rnArea rn = new rnArea();
            List<clsArea> areas = rn.Listar(this.txtListadoAreas.Text);
            try
            {
                this.dgvAreas.DataSource = null;
                if(areas.Count > 0)
                {
                    this.dgvAreas.AutoGenerateColumns = false;
                    this.dgvAreas.DataSource = areas;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede listar las areas");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dgvAreas.CurrentRow != null)
            {
                this.Actual = (clsArea)this.dgvAreas.CurrentRow.DataBoundItem;
                this.presentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una empresa");
            }

        }

        private void presentarDatos()
        {
            this.txtNombre.Text = this.Actual.nombre;
            this.txtDescripcion.Text = this.Actual.descripcion;
            this.chkVigente.Checked = this.Actual.vigente;
            this.ActivarComponentes(true);
        }
    }
}
