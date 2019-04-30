using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private int edad;

        public string Apellido { get { return this.apellido; } }

        public string Nombre { get { return this.nombre; } }

        public int Dni { get { return this.dni; } }

        public int Edad { get { return this.edad; } }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public abstract bool ValidarAptitud(); //

        public virtual string Mostrar() //puede ser sobre escrito en las clases derivadas
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Apellido: {0}\n", this.apellido);
            sb.AppendFormat("Edad: {0}\n", this.edad);
            sb.AppendFormat("Dni: {0}", this.dni);

            return sb.ToString();
        }
    }
}
