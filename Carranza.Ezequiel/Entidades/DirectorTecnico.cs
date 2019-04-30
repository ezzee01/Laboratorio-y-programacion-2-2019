using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set { this.añosExperiencia = value; }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if (this.Edad < 64 && this.AñosExperiencia >= 2)
            {
                retorno = true;
            }

            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Años de experiencia: {0}\n", this.añosExperiencia);
            return sb.ToString();
        }
    }
}
