using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEmpleado
    {
        public string idEmpleado { get; set; }
        public string nombres { get; set; }
        public string apellPaterno { get; set; }
        public string apellMaterno { get; set; }
        public string dni { get; set; }
        public string genero { get; set; } //CHAR(1) - M - F
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public bool vigente { get; set; }

        public string mostrarGenero
        {
            get
            {
                string resultado = "";
                if (genero == "M") resultado = "Masculino";
                else resultado = "Femenino";

                return resultado;
            }
        }

        public string nombresCompletos
        {
            get
            {
                return nombres + ' ' + apellPaterno;
            }
        }

    }
}
