using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class rnEmpleado
    {
        private readonly static string cadenaConexion = "Data Source=LINDERCASAS\\SQLEXPRESS;Initial Catalog=ManaosMarketSof;Integrated Security=True";

        public void Actualizar(clsEmpleado nuevo)
        {
            string query = $@"UPDATE Empleado
                            SET nombres='{nuevo.nombres}',apellPaterno='{nuevo.apellPaterno}',apellMaterno='{nuevo.apellMaterno}',
                                dni='{nuevo.dni}',genero='{nuevo.genero}',fechaNacimiento='{nuevo.fechaNacimiento.ToString("yyyy/MM/dd")}',
                                telefono='{nuevo.telefono}',direccion='{nuevo.direccion}',correo='{nuevo.correo}',vigente={(nuevo.vigente==true?1:0)}
                            WHERE idEmpleado='{nuevo.idEmpleado}'";
            try
            {
                using (var conexion = new SqlConnection(rnEmpleado.cadenaConexion))
                {
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        public void Registrar(clsEmpleado nuevo)
        {
            string query = $@"INSERT INTO Empleado VALUES ('{nuevo.idEmpleado}','{nuevo.nombres}','{nuevo.apellPaterno}','{nuevo.apellMaterno}',
                                    '{nuevo.dni}','{nuevo.genero}','{nuevo.fechaNacimiento.ToString("yyyy/MM/dd")}','{nuevo.telefono}','{nuevo.direccion}','{nuevo.correo}',{(nuevo.vigente == true ? 1 : 0)})";
            try
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                {
                    using (var comando = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clsEmpleado Leer(string idEmpleado)
        {
            clsEmpleado empleado = null;
            string query = $@"SELECT idEmpleado,nombres,apellPaterno,apellMaterno,dni,genero,fechaNacimiento,telefono,direccion,correo,vigente 
                            FROM Empleado 
                            WHERE idEmpleado='{idEmpleado}'";
            using (var conexion= new SqlConnection(rnEmpleado.cadenaConexion))
            {
                using (var comando= new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    using(var dr = comando.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            empleado = new clsEmpleado()
                            {
                                idEmpleado = idEmpleado,
                                nombres = dr.GetString(dr.GetOrdinal("nombres")),
                                apellPaterno=dr.GetString(dr.GetOrdinal("apellPaterno")),
                                apellMaterno=dr.GetString(dr.GetOrdinal("apellMaterno")),
                                dni=dr.GetString(dr.GetOrdinal("dni")),
                                genero=dr.GetString(dr.GetOrdinal("genero")),
                                fechaNacimiento=dr.GetDateTime(dr.GetOrdinal("fechaNacimiento")),
                                telefono=dr.GetString(dr.GetOrdinal("telefono")),
                                direccion=dr.GetString(dr.GetOrdinal("direccion")),
                                correo=dr.GetString(dr.GetOrdinal("correo")),
                                vigente=dr.GetBoolean(dr.GetOrdinal("vigente"))
                            };
                        }
                        dr.Close();
                    }
                    conexion.Close();
                }
            }
            return empleado;
        }

        public List<clsEmpleado> ListarEmpleados()
        {
            List<clsEmpleado> listaEmpleados = null;
            string query =$@"SELECT idEmpleado,nombres, apellPaterno,apellMaterno,genero,vigente FROM Empleado";

            try
            {
                using (var conexion=new SqlConnection(rnEmpleado.cadenaConexion))
                {
                    using (var comandos= new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        using (var dr=comandos.ExecuteReader())
                        {
                            listaEmpleados = new List<clsEmpleado>();
                            while (dr.Read())
                            {
                                listaEmpleados.Add(new clsEmpleado()
                                {
                                    idEmpleado=dr.GetString(dr.GetOrdinal("idEmpleado")),
                                    nombres=dr.GetString(dr.GetOrdinal("nombres")),
                                    apellPaterno=dr.GetString(dr.GetOrdinal("apellPaterno")),
                                    apellMaterno=dr.GetString(dr.GetOrdinal("apellMaterno")),
                                    genero=dr.GetString(dr.GetOrdinal("genero")),
                                    vigente=dr.GetBoolean(dr.GetOrdinal("vigente")),
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
            return listaEmpleados;
        }

        public List<clsEmpleado> ListarEmpleadosFiltro(string text)
        {
            List<clsEmpleado> empleados = null;

            string query = $@"SELECT idEmpleado,nombres, apellPaterno,apellMaterno,genero,vigente
                            FROM Empleado
                            WHERE CONCAT(nombres,' ',apellPaterno,' ',apellMaterno) LIKE '%{text}%'";

            using (var conexion= new SqlConnection(rnEmpleado.cadenaConexion))
            {
                using (var comando= new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (var dr= comando.ExecuteReader())
                    {
                        empleados = new List<clsEmpleado>();
                        while (dr.Read())
                        {
                            empleados.Add(new clsEmpleado()
                            {
                                idEmpleado = dr.GetString(dr.GetOrdinal("idEmpleado")),
                                nombres = dr.GetString(dr.GetOrdinal("nombres")),
                                apellPaterno = dr.GetString(dr.GetOrdinal("apellPaterno")),
                                apellMaterno = dr.GetString(dr.GetOrdinal("apellMaterno")),
                                genero = dr.GetString(dr.GetOrdinal("genero")),
                                vigente = dr.GetBoolean(dr.GetOrdinal("vigente")),
                            });
                        }
                    }
                }
                conexion.Close();
            }
            return empleados;
        }

        public List<clsEmpleado> ListarVigentes()
        {
            List<clsEmpleado> empleados= null;
            string query = $@"SELECT E.idEmpleado,E.nombres,E.apellPaterno
                            FROM Empleado E
                            WHERE E.idEmpleado != (SELECT N.idEmpleado FROM Encargatura N)";
            using (var conexion= new SqlConnection(rnEmpleado.cadenaConexion))
            {
                using (var comando= new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (var dr= comando.ExecuteReader())
                    {
                        empleados = new List<clsEmpleado>();
                        while (dr.Read()==true)
                        {
                            empleados.Add(new clsEmpleado()
                            {
                                idEmpleado=dr.GetString(dr.GetOrdinal("idEmpleado")),
                                nombres=dr.GetString(dr.GetOrdinal("nombres")),
                                apellPaterno=dr.GetString(dr.GetOrdinal("apellPaterno"))
                            });
                        }
                        dr.Close();
                    }
                    conexion.Close();
                }
            }
            return empleados;
        }

      
    }
}
