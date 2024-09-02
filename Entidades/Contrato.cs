using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contrato
    {
        public int idContrato {  get; set; }
        public clsEmpleado Empleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public bool Vigencia { get; set; }
        public DateTime FechaFin { get; set; }
        public string Tipo { get; set; }

        public Sueldo Sueldo { get; set; }
        public Horario Horario { get; set; }


        public string idEmpleado
        {
            get
            {
                var nombre = "";
                if (this.Empleado != null)
                {
                    nombre = this.Empleado.idEmpleado.ToString();
                }
                return nombre;
            }
        }

        public string nombreEmpleado
        {
            get
            {
                var nombreEMP = "";
                if (this.Empleado != null)
                {
                    nombreEMP = this.Empleado.nombres + ' ' + this.Empleado.apellPaterno;
                }
                return nombreEMP;
            }
        }


        public string MostrarHorarioEntrada
        {
            get
            {
                var horarioEntrada = "";
                if (this.Horario != null)
                {
                    horarioEntrada = this.Horario.horaEntrada.ToString();
                }
                return horarioEntrada;
            }
        }

        public string MostrarHorarioSalida
        {
            get
            {
                var horarioSalida = "";
                if (this.Horario != null)
                {
                    horarioSalida = this.Horario.horaSalida.ToString();
                }
                return horarioSalida;
            }
        }

        public string SueldoMonto
        {
            get
            {
                var Sueldomonto = "";
                if (this.Sueldo != null)
                {
                    Sueldomonto = this.Sueldo.monto.ToString();
                }
                return Sueldomonto;
            }
        }

        public int idSueldo
        {
            get
            {
                var idSueldo = 0;
                if (this.Sueldo != null)
                {
                    idSueldo = this.Sueldo.idsueldo;
                }
                return idSueldo;
            }
        }

        public int codHorario
        {
            get
            {
                var idHorario = 0;
                if (this.Horario != null)
                {
                    idHorario = this.Horario.codHorario;
                }
                return idHorario;
            }
        }
    }
}
