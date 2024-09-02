using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
        public class Planilla
        {
            public int IdPlanilla { get; set; }
            public string NombreCompleto { get; set; }
            public int NumAsistencias { get; set; }
            public int NumTardanzas { get; set; }
            public decimal Sueldo { get; set; }
        }
    
}
