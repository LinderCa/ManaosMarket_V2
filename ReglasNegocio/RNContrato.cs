using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class RNContrato
    {

        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";


        public void RegistrarAmbos(Contrato contrato, Sueldo sueldo, Horario horario)
        {
            using (var cn = new SqlConnection(RNContrato.cadenaConexion))
            {
                cn.Open();
                SqlTransaction tr = null;

                try
                {
                    using (tr = cn.BeginTransaction())
                    {
                        try
                        {
                            string insertEmpleadoQuery = @"insert into Contrato(idEmpleado, fechaInicio, vigente, fechaFin, tipo) 
                                                        values(@idEmpleado,@fechaInicio, @vigente, @fechaFin, @tipo);
                                                         SELECT SCOPE_IDENTITY();";

                            using (var cmd = new SqlCommand(insertEmpleadoQuery, cn, tr))
                            {
                                cmd.Parameters.AddWithValue("@idEmpleado", contrato.Empleado.idEmpleado);
                                cmd.Parameters.AddWithValue("@fechaInicio", contrato.FechaInicio);
                                cmd.Parameters.AddWithValue("@vigente", contrato.Vigencia);
                                cmd.Parameters.AddWithValue("@fechaFin", contrato.FechaFin);
                                cmd.Parameters.AddWithValue("@tipo", contrato.Tipo);

                                int id = Convert.ToInt32(cmd.ExecuteScalar());

                                string insertContratoQuery = @"insert into SUELDO(monto, idContrato) values(@monto, @idContrato)";

                                using (var ContratoCmd = new SqlCommand(insertContratoQuery, cn, tr))
                                {
                                    ContratoCmd.Parameters.AddWithValue("@monto", sueldo.monto);
                                    ContratoCmd.Parameters.AddWithValue("@idContrato", id);

                                    ContratoCmd.ExecuteNonQuery();
                                }

                                string inserthorarioQuery = @"insert into HORARIO(horaEntrada, horaSalida, idContrato) values(@horaEntrada,@horaSalida, @idContrato)";

                                using (var HorarioCmd = new SqlCommand(inserthorarioQuery, cn, tr))
                                {
                                    HorarioCmd.Parameters.AddWithValue("@horaEntrada", horario.horaEntrada);
                                    HorarioCmd.Parameters.AddWithValue("@horaSalida", horario.horaSalida);
                                    HorarioCmd.Parameters.AddWithValue("@idContrato", id);

                                    HorarioCmd.ExecuteNonQuery();
                                }
                            }

                            tr.Commit();
                        }
                        catch (Exception)
                        {
                            tr.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Por si no registra el primer isert osea Empleado no se hace el registo de contrato
                    //SI o SI se tiene q registrar primero empleado para q pueda funcionar
                    throw ex;
                }
            }
        }

        public void EliminarContrato(Contrato contrato)
        {
            try
            {
                using (var cn = new SqlConnection(RNContrato.cadenaConexion))
                {
                    cn.Open();

                    // Eliminar sueldo asociado al contrato
                    string sqlDeleteSueldo = $"DELETE FROM Sueldo WHERE idSueldo = {contrato.Sueldo.idsueldo};";
                    using (var cmdSueldo = new SqlCommand(sqlDeleteSueldo, cn))
                    {
                        cmdSueldo.ExecuteNonQuery();
                    }

                    // Eliminar horario asociado al contrato
                    string sqlDeleteHorario = $"DELETE FROM Horario WHERE idHorario = {contrato.Horario.codHorario};";
                    using (var cmdHorario = new SqlCommand(sqlDeleteHorario, cn))
                    {
                        cmdHorario.ExecuteNonQuery();
                    }

                    // Eliminar el contrato principal
                    string sqlDeleteContrato = $"DELETE FROM Contrato WHERE idContrato = {contrato.idContrato};";
                    using (var cmdContrato = new SqlCommand(sqlDeleteContrato, cn))
                    {
                        cmdContrato.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Contrato> buscarContratos(string nombre)
        {
            List<Contrato> contratos = null;
            string sql = $@"SELECT C.idContrato, C.fechaInicio, C.fechaFin, C.tipo, C.vigente, ISNULL(E.nombres + ' ' + E.apellPaterno, 0) AS nombreEmpleado, C.idEmpleado, S.monto, S.idSueldo, H.horaEntrada, H.horaSalida, H.idHorario
                            FROM Contrato C LEFT JOIN SUELDO S ON S.idContrato = C.idContrato LEFT JOIN HORARIO H ON H.idContrato = C.idContrato LEFT JOIN Empleado E ON C.idEmpleado = E.idEmpleado WHERE E.nombres = '{nombre}'";

            try
            {
                using (var cn = new SqlConnection(RNContrato.cadenaConexion))
                {
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            contratos = new List<Contrato>();
                            while (dr.Read())
                            {
                                contratos.Add(new Contrato()
                                {
                                    idContrato = dr.GetInt16(dr.GetOrdinal("idContrato")),
                                    FechaInicio = dr.GetDateTime(dr.GetOrdinal("fechaInicio")),
                                    FechaFin = dr.GetDateTime(dr.GetOrdinal("fechaFin")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("vigente")),
                                    Tipo = dr.GetString(dr.GetOrdinal("tipo")),
                                    Empleado = new clsEmpleado()
                                    {
                                        idEmpleado = dr.GetString(dr.GetOrdinal("idEmpleado")),
                                        nombres = nombre,
                                    },
                                    Sueldo = new Sueldo()
                                    {
                                        idsueldo = dr.GetInt16(dr.GetOrdinal("idSueldo")),
                                        monto = (double)dr.GetDecimal(dr.GetOrdinal("monto")),
                                    },
                                    Horario = new Horario()
                                    {
                                        codHorario = dr.GetInt16(dr.GetOrdinal("idHorario")),
                                        horaEntrada = dr.GetTimeSpan(dr.GetOrdinal("horaEntrada")),
                                        horaSalida = dr.GetTimeSpan(dr.GetOrdinal("horaSalida")),
                                    }
                                }); ;
                            }
                            dr.Close();
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return contratos;
        }

        public List<Contrato> listarTodo()
        {
            List<Contrato> contratos = null;
            string sql = @"SELECT C.idContrato, C.fechaInicio, C.fechaFin, C.tipo, C.vigente, ISNULL(E.nombres + ' ' + E.apellPaterno, 0) AS nombreEmpleado, C.idEmpleado, S.monto, S.idSueldo, H.horaEntrada, H.horaSalida, H.idHorario
                            FROM Contrato C LEFT JOIN SUELDO S ON S.idContrato = C.idContrato LEFT JOIN HORARIO H ON H.idContrato = C.idContrato LEFT JOIN Empleado E ON C.idEmpleado = E.idEmpleado";

            try
            {
                using (var cn = new SqlConnection(RNContrato.cadenaConexion))
                {
                    using (var cmd = new SqlCommand(sql, cn)) 
                    {
                        cn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            contratos = new List<Contrato>();
                            while (dr.Read())
                            {
                                contratos.Add(new Contrato()
                                {
                                    idContrato = dr.GetInt16(dr.GetOrdinal("idContrato")),
                                    FechaInicio = dr.GetDateTime(dr.GetOrdinal("fechaInicio")),
                                    FechaFin = dr.GetDateTime(dr.GetOrdinal("fechaFin")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("vigente")),
                                    Tipo = dr.GetString(dr.GetOrdinal("tipo")),
                                    Empleado = new clsEmpleado()
                                    {
                                       idEmpleado = dr.GetString(dr.GetOrdinal("idEmpleado")),
                                       nombres = dr.GetString(dr.GetOrdinal("nombreEmpleado")),
                                       
                                    },
                                    Sueldo = new Sueldo()
                                    {
                                        idsueldo = dr.GetInt16(dr.GetOrdinal("idSueldo")),
                                        monto = (double)dr.GetDecimal(dr.GetOrdinal("monto")),
                                    },
                                    Horario = new Horario()
                                    {
                                        codHorario = dr.GetInt16(dr.GetOrdinal("idHorario")),
                                        horaEntrada = dr.GetTimeSpan(dr.GetOrdinal("horaEntrada")),
                                        horaSalida = dr.GetTimeSpan(dr.GetOrdinal("horaSalida")),
                                    }
                                });;
                            }
                            dr.Close();
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return contratos;
        }

        public bool VerificarEmpleadoContratoExistente(string idEmpleado)
        {
            bool existeContrato = false;
            string sql = $"SELECT COUNT(*) FROM Contrato WHERE idEmpleado = @idEmpleado";

            try
            {
                using (var cn = new SqlConnection(RNContrato.cadenaConexion))
                {
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        cn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        existeContrato = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existeContrato;
        }
    }
}
