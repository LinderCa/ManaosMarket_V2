using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class rnAsistencia
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public void Registrar(clsAsistencia asistencia)
        {
            string query = $@"INSERT INTO Asistencia(estado,fecha,horaLlegada,idEmpleado)
                            VALUES(1,GETDATE(),'{asistencia.horaLlegada}','{asistencia.idEmpleado}')";
            try
            {
                using (var conexion=new SqlConnection(rnAsistencia.cadenaConexion))
                {
                    using (var comandos= new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        comandos.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
