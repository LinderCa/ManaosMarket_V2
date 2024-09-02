using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ReglasNegocio;
using Entidades;

namespace ManaosMarket
{
    public partial class frmUsuarioAdministrador : Form
    {
        private frmPrincipal principal;
        public frmUsuarioAdministrador(frmPrincipal formuPrincipal)
        {
            InitializeComponent();
            this.principal = formuPrincipal;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            string usuario=this.txtUsuario.Text;
            string clave=this.txtContraseña.Text;
            //Instanciamos 
            rnUsuarioAdministrador rn = new rnUsuarioAdministrador() ;
            clsUsuario user = new clsUsuario();

            user=rn.Leer(usuario,clave);
            if(user.usuario==usuario && user.contraseha == clave)
            {
                this.Close();
                //Mostramos el menuEscalafon
                MessageBox.Show("BIENVENIDO AL SISTEMA" + (user.nombresCompletos).ToUpper());
                this.principal.mostrarMenuEscalafon(true);
            }
            else
            {
                MessageBox.Show("Usuario incorrecto",this.Text);
            }
        }
    }
}
