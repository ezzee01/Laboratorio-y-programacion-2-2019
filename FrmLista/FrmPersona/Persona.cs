using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPersona
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
       
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override string ToString()
        {
            return string.Format("Nombre: " + this.nombre + "  " + "Apellido: " + this.apellido + "  " + "DNI: " + this.dni);
        }
    }
}
