using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horario
    {
        public int codHorario {  get; set; }
        public TimeSpan horaEntrada { get; set; }
        public TimeSpan horaSalida { get; set; }
        public Contrato contrato { get; set; }
    }
}
