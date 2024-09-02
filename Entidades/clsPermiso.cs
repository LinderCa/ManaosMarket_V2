using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    using System;

    public class clsPermiso
    {
        public string Codigo { get; set; }
        public string idEmpleado { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Int32 numeroDias { get; set; }
        public String Motivo { get; set; }

        public clsPermiso()
        {
        }
        public clsPermiso(string codigo, string idempleado, DateTime horainicio, DateTime horafin, DateTime fechainicio, DateTime fechafin, Int32 numerodias, String motivo)
        {
            Codigo = codigo;
            idEmpleado = idempleado;
            horaInicio = horainicio;
            horaFin = horafin;
            fechaInicio = fechainicio;
            fechaFin = fechafin;
            numeroDias = numerodias;
            Motivo = motivo;
        }
    }

}
