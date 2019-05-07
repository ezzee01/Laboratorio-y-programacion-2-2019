using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Espacio Disponible: {0}", e.espacioDisponible);
            sb.AppendFormat("Nombre: {0}\n", e.nombre);
            foreach (Vehiculo v in e.vehiculos)
            {
                sb.AppendLine(v.ToString());
            }
            return sb.ToString();
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;
            foreach (Vehiculo aux in e.vehiculos)
            {
                if (aux == v)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            string retorno = "El vehículo no es parte del estacionamiento";

            if (e == v)
            {
                retorno = v.ImprimirTicket();
            }

            return retorno;
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != v && v.Patente != null && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
    }
}
