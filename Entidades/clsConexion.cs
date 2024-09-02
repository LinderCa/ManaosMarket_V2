using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsConexion
    {
        private SqlConnection _con;

        public clsConexion()
        {
            string ruta;
            // CONEXION CON USUARIO
            //ruta = "Data Source=LC318\\SQLEXPRESS;Initial Catalog=BD_Academico;user id=sa; password=123";

            // CONEXION SIN USUARIO
        ruta= "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";


            _con = new SqlConnection(ruta);
        }

        public void conectar()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                {
                    _con.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void desconectar()
        {
            try
            {
                if (_con.State != ConnectionState.Closed)
                {
                    _con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlConnection getConexion
        {
            get { return _con; }
        }
    }
}
