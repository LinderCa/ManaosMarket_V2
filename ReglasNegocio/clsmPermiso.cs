using Entidades;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class clsmPermiso
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public void agregar(clsPermiso obj)
        {
            // INSERT INTO
            clsConexion con = new clsConexion();
            SqlCommand cmd;
            string sentencia;
            try
            {
                sentencia = "INSERT INTO Permiso VALUES('" + obj.Codigo + "', '" + obj.idEmpleado + "', '" + obj.horaInicio + "', '" + obj.horaFin + "', '" + obj.fechaInicio.ToString("dd-MM-yyyy") + "', '" + obj.fechaFin.ToString("dd-MM-yyyy") + "', " + obj.numeroDias + ", '" + obj.Motivo + "')";

                con.conectar();
                cmd = new SqlCommand(sentencia, con.getConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idPermiso", SqlDbType.VarChar).Value = obj.Codigo;
                cmd.Parameters.Add("@idEmpleado", SqlDbType.VarChar).Value = obj.idEmpleado;
                cmd.Parameters.Add("@horaInicio", SqlDbType.Time).Value = obj.horaInicio;
                cmd.Parameters.Add("@horaFin", SqlDbType.Time).Value = obj.horaFin;
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = obj.fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = obj.fechaFin;
                cmd.Parameters.Add("@numeroDias", SqlDbType.Int).Value = obj.numeroDias;
                cmd.Parameters.Add("@motivo", SqlDbType.VarChar).Value = obj.Motivo;

                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(clsPermiso obj)
        {

            clsConexion con = new clsConexion();
            SqlCommand cmd;
            string sentencia;
            try
            {
                sentencia = "UPDATE Permiso SET idEmpleado = '" + obj.idEmpleado + "', horaInicio = '" + obj.horaInicio + "', horaFin = '" + obj.horaFin + "', fechaInicio = '" + obj.fechaInicio.ToString("yyyy-MM-dd") + "', fechaFin = '" + obj.fechaFin.ToString("yyyy-MM-dd") + "', numeroDias = " + obj.numeroDias + ", Motivo = '" + obj.Motivo + "' WHERE Codigo = '" + obj.Codigo + "'";

                con.conectar();
                cmd = new SqlCommand(sentencia, con.getConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idPermiso", SqlDbType.VarChar).Value = obj.Codigo;
                cmd.Parameters.Add("@idEmpleado", SqlDbType.VarChar).Value = obj.idEmpleado;
                cmd.Parameters.Add("@horaInicio", SqlDbType.Time).Value = obj.horaInicio;
                cmd.Parameters.Add("@horaFin", SqlDbType.Time).Value = obj.horaFin;
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = obj.fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = obj.fechaFin;
                cmd.Parameters.Add("@numeroDias", SqlDbType.Int).Value = obj.numeroDias;
                cmd.Parameters.Add("@motivo", SqlDbType.VarChar).Value = obj.Motivo;

                cmd.ExecuteNonQuery();
                con.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable listado()
        {
            // SELECT
            clsConexion con = new clsConexion();
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            string sentencia;
            try
            {

                sentencia = "SELECT E.idEmpleado, E.nombres, E.apellPaterno, P.horaInicio, P.horaFin, P.fechaInicio, P.fechaFin, P.motivo " +
                            "FROM Empleado E INNER JOIN Permiso P ON E.idEmpleado = P.idEmpleado";


                con.conectar();
                da = new SqlDataAdapter(sentencia, con.getConexion);
                da.Fill(dt);
                con.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable listadoEmpleado()
        {
            // SELECT
            clsConexion con = new clsConexion();
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            string sentencia;
            try
            {

                sentencia = "SELECT idEmpleado, nombres, apellidoPaterno, apellidOMaterno, DNI, genero " +
                             "FROM Empleado;";


                con.conectar();
                da = new SqlDataAdapter(sentencia, con.getConexion);
                da.Fill(dt);
                con.desconectar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public List<clsPermiso> ListarPermisos()
        {
            string query = $@"SELECT P.idPermiso FROM Permiso P";
            List<clsPermiso> permisos = null;
            try
            {
                using (var conexion= new SqlConnection(clsmPermiso.cadenaConexion))
                {
                    using (var comando= new SqlCommand(query, conexion))
                    {
                            conexion.Open();
                        using (var dr= comando.ExecuteReader())
                        {
                            permisos = new List<clsPermiso>();
                            while (dr.Read())
                            {
                                permisos.Add(new clsPermiso()
                                {
                                    Codigo=(dr.GetInt16(dr.GetOrdinal("idPermiso"))).ToString(),
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

            return permisos;
        }
    }
}
