using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class rnArea
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public void Actualizar(clsArea nuevaArea)
        {
            string sql = $@"UPDATE Area 
                            SET nombre='{nuevaArea.nombre}',descripcion='{nuevaArea.descripcion}',vigente={(nuevaArea.vigente==true ? 1 : 0)}
                            WHERE idArea={nuevaArea.idArea}";
            try
            {
                using (var conexion= new SqlConnection(rnArea.cadenaConexion))
                {
                    using (var comando= new SqlCommand(sql, conexion))
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

        public List<clsArea> listado()
        {
            List<clsArea> areas = null;
            string sql = $@"SELECT A.idArea,A.nombre,A.descripcion,A.vigente
                            FROM Area A
                            WHERE A.vigente=1";
            try
            {
                using (var conexion= new SqlConnection(rnArea.cadenaConexion))
                {
                    using (var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr = comandos.ExecuteReader())
                        {
                            areas = new List<clsArea>();
                            while (dr.Read() == true)
                            {
                                areas.Add(new clsArea()
                                {
                                    idArea=dr.GetInt16(dr.GetOrdinal("idArea")),
                                    nombre=dr.GetString(dr.GetOrdinal("nombre")),
                                    descripcion=dr.GetString(dr.GetOrdinal("descripcion")),
                                    vigente=dr.GetBoolean(dr.GetOrdinal("vigente"))
                                });
                            }
                            dr.Close();
                        }
                        conexion.Close();
                    }
                }
            }catch(Exception e)
            {
                throw e;
            }
            return areas;
        }

        public List<clsArea> Listar(string texto)
        {
            List<clsArea> areas = null;
            string sql = $@"SELECT A.idArea, A.nombre,A.descripcion,A.vigente
                            FROM Area A
                            WHERE A.nombre LIKE '{texto}%' ";
            try
            {
                using (var conexion= new SqlConnection(rnArea.cadenaConexion))
                {
                    using (var comnandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr= comnandos.ExecuteReader())
                        {
                            areas = new List<clsArea>();
                            while(dr.Read() == true){
                                areas.Add(new clsArea()
                                {
                                    idArea = dr.GetInt16(dr.GetOrdinal("idArea")),
                                    nombre = dr.GetString(dr.GetOrdinal("nombre")),
                                    descripcion = dr.GetString(dr.GetOrdinal("descripcion")),
                                    vigente = dr.GetBoolean(dr.GetOrdinal("vigente"))
                                });
                            }
                            dr.Close();
                        }
                    }
                    conexion.Close();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return areas;
        }

        public void Registrar(clsArea nuevaArea)
        {
            String sql = $@" INSERT INTO Area VALUES('{nuevaArea.nombre}','{nuevaArea.descripcion}',{(nuevaArea.vigente==true ? 1: 0) })";
            try
            {
                using (var conexion= new SqlConnection(rnArea.cadenaConexion))
                {
                    using (var comando=new SqlCommand(sql,conexion))
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
