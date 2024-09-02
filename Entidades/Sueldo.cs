using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sueldo
    {
        public int idsueldo {  get; set; }
        public double monto { get; set; }
        public Contrato contrato { get; set; }
    }
}
