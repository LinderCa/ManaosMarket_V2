using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class rnEncargatura
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public List<clsEncargatura> ListarEncargaturas()
        {
            List<clsEncargatura> encargaturas = null;
            string query = $@"SELECT N.idEncargatura, CONCAT(E.nombres, ' ',E.apellPaterno, ' ',E.apellMaterno) AS 'nombreEmpleado',A.nombre AS 'nombreArea',N.nombre as 'nombreEncargatura' 
                            FROM Encargatura N
                            JOIN Empleado E
                            ON N.idEmpleado=E.idEmpleado
                            JOIN Area A 
                            ON A.idArea=N.idArea";

            try
            {
                using (var conexion = new SqlConnection(rnEncargatura.cadenaConexion))
                {
                    using (var comandos = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        using (var dr = comandos.ExecuteReader())
                        {
                            encargaturas = new List<clsEncargatura>();
                            while (dr.Read())
                            {
                                encargaturas.Add(new clsEncargatura()
                                {
                                    idEncargatura = dr.GetInt16(dr.GetOrdinal("idEncargatura")),
                                    nombreEmpleado = dr.GetString(dr.GetOrdinal("nombreEmpleado")),
                                    nombreArea = dr.GetString(dr.GetOrdinal("nombreArea")),
                                    nombre = dr.GetString(dr.GetOrdinal("nombreEncargatura")),
                                });
                            }
                            dr.Close();
                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return encargaturas;
        }

        public void Registrar(clsEncargatura encargatura)
        {
            string query = $@"INSERT INTO Encargatura VALUES('{encargatura.nombre}',{(encargatura.vigencia==true ? 1 : 0)},
                            '{encargatura.idEmpleado}',{encargatura.idArea});";
            try
            {
                using (var conexion=new SqlConnection(rnEncargatura.cadenaConexion))
                {
                    using (var comando=new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
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
