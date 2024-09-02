using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ReglasNegocio
{
    public class rnPlanilla
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public List<Planilla> ObtenerPlanillas()
        {
            List<Planilla> planillas = new List<Planilla>();
            string consultaSQL = "SELECT * FROM Planillas";

            try
            {
                using (SqlConnection conexion = new SqlConnection(rnPlanilla.cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conexion))
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Planilla planilla = new Planilla();
                                planilla.IdPlanilla = reader.GetInt32(reader.GetOrdinal("idPlanilla"));
                                planilla.NombreCompleto = reader.GetString(reader.GetOrdinal("nombreCompleto"));
                                planilla.NumAsistencias = reader.GetInt32(reader.GetOrdinal("numAsistencias"));
                                planilla.NumTardanzas = reader.GetInt32(reader.GetOrdinal("numTardanzas"));
                                planilla.Sueldo = reader.GetDecimal(reader.GetOrdinal("sueldo"));

                                planillas.Add(planilla);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return planillas;
        }
        public List<Planilla> ObtenerPlanillasFiltradas(string filtro)
        {
            List<Planilla> planillas = new List<Planilla>();
            string consultaSQL = "SELECT * FROM Planillas";

            if (!string.IsNullOrEmpty(filtro))
            {
                consultaSQL += $" WHERE NombreCompleto LIKE '%{filtro}%'"; // Modificar el filtro según tus necesidades
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(rnPlanilla.cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conexion))
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Planilla planilla = new Planilla();
                                planilla.IdPlanilla = reader.GetInt32(reader.GetOrdinal("idPlanilla"));
                                planilla.NombreCompleto = reader.GetString(reader.GetOrdinal("nombreCompleto"));
                                planilla.NumAsistencias = reader.GetInt32(reader.GetOrdinal("numAsistencias"));
                                planilla.NumTardanzas = reader.GetInt32(reader.GetOrdinal("numTardanzas"));
                                planilla.Sueldo = reader.GetDecimal(reader.GetOrdinal("sueldo"));

                                planillas.Add(planilla);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return planillas;
        }

    }
}



