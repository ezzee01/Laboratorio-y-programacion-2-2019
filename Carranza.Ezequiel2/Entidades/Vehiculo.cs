using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get { return this.patente; }
            set
            {
                if (this.patente.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.patente = patente;
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendFormat("Fecha: {0}", this.ingreso.Date.ToString());
            sb.AppendFormat("Hora: {0}", this.ingreso.Hour.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (v1.Patente == v2.Patente) //FALTA EQUALS
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        { return string.Format("Patente {0}", this.patente); }
    }
}
