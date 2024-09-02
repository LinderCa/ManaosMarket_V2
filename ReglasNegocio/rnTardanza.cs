using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class rnTardanzas
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public DataTable ObtenerTardanzas()
        {
            string consulta = "SELECT E.nombres AS NombreEmpleado, T.Fecha, T.horasTardanza, T.Estado, T.Motivo FROM Tardanza T INNER JOIN Empleado E ON T.IdEmpleado = E.IdEmpleado";

            using (SqlConnection connection = new SqlConnection(rnTardanzas.cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    return table;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool ModificarTardanza(int idTardanza, string nombreEmpleado, DateTime fecha, int horas, string estado, string motivo)
        {
            string consulta = "UPDATE Tardanzas SET NombreEmpleado = @NombreEmpleado, Fecha = @Fecha, Horas = @Horas, Estado = @Estado, Motivo = @Motivo WHERE IdTardanza = @IdTardanza;";

            using (SqlConnection connection = new SqlConnection(rnTardanzas.cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.AddWithValue("@NombreEmpleado", nombreEmpleado);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@Horas", horas);
                command.Parameters.AddWithValue("@Estado", estado);
                command.Parameters.AddWithValue("@Motivo", motivo);
                command.Parameters.AddWithValue("@IdTardanza", idTardanza);

                try
                {
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0; // Retorna verdadero si se modificaron filas en la base de datos
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<clsTardanza> ListarEmpleadosTardanza()
        {
            List<clsTardanza> tardanzas = null;

            string query = $@"SELECT idEmpleado,fecha,horasTardanza,estado FROM Tardanza WHERE estado=0";

            try
            {
                using (var conexion= new SqlConnection(rnTardanzas.cadenaConexion))
                {
                    using (var comando=new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        using (var dr= comando.ExecuteReader())
                        {
                            tardanzas = new List<clsTardanza>();
                            while (dr.Read())
                            {
                                tardanzas.Add( new clsTardanza()
                                {
                                    idEmpleado= dr.GetString(dr.GetOrdinal("idEmpleado")),
                                    fecha=dr.GetDateTime(dr.GetOrdinal("fecha")),
                                    horasTardanza=dr.GetInt16(dr.GetOrdinal("horasTardanza")),
                                    estado=dr.GetBoolean(dr.GetOrdinal("estado"))
                                });
                            }
                            dr.Close();
                        }
                        conexion.Close();
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }

            return tardanzas;
        }

        public void Registrar(clsTardanza tardanza)
        {
            string query = $@"INSERT INTO Tardanza(fecha,horasTardanza,estado,idEmpleado) VALUES(GETDATE(),{tardanza.horasTardanza},0,'{tardanza.idEmpleado}');";
            using (var conexion= new SqlConnection(rnTardanzas.cadenaConexion))
            {
                using (var comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}