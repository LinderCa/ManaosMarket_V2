using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsTardanza
    {
        public int idTardanza { get; set; }
        public DateTime fecha { get; set; }
        public int horasTardanza { get; set; }
        public string motivo { get; set; }
        public bool estado { get; set; }
        public string idEmpleado { get; set; }

    }
}
