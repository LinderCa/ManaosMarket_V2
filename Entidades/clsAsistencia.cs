using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsAsistencia
    {
        public int idAsistencia { get; set; }
        public bool estado { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan horaLlegada { get; set; }
        public TimeSpan horaSalida { get; set; }
        public string idEmpleado { get; set; }

    }
}
