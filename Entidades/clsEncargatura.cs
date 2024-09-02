using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEncargatura
    {
        //Propiedades
        public int idEncargatura { get; set; }
        public string nombre { get; set; }
        public bool vigencia { get; set; }
        public string idEmpleado { get; set; }
        public int idArea { get; set; }

        /*PROPIEDADES PARA EL DATA GRIED VIEW*/
        public string nombreEmpleado { get; set; }
        public string nombreArea { get; set; }


    }
}
