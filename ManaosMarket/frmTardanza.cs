using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ManaosMarket
{
    public partial class frmTardanza : Form
    {
        public frmTardanza()
        {
            InitializeComponent();
        }


        private void frmTardanza_Load(object sender, EventArgs e)
        {
            rnTardanzas rn = new rnTardanzas();
            List<clsTardanza> tardanzas = rn.ListarEmpleadosTardanza();
            if (tardanzas.Count > 0)
            {
                this.dgvTardanzas.DataSource = null;
                this.dgvTardanzas.AutoGenerateColumns = false;
                this.dgvTardanzas.DataSource = tardanzas;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //this.ActivarComtroles(true);
        }

        private void ActivarComtroles(bool Estado)
        {
            this.gbTardanza.Enabled = Estado;
            this.gbListadoTardanza.Enabled = Estado;

            if (Estado == true)
            {
                this.txtEmpleado.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ActivarComtroles(true);
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
