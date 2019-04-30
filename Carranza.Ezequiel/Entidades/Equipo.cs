using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre { get { return this.nombre; } }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre del equipo: {0}\n", e.Nombre);

            if (e.directorTecnico != null)
            {
                sb.AppendLine(e.directorTecnico.Mostrar());
            }
            else sb.AppendLine("Sin DT asignado\n");

            foreach (Jugador aux in e.jugadores)
            {
                sb.AppendLine(aux.Mostrar());
            }
            return sb.ToString();
        }

        public static bool operator !=(Equipo e, Jugador j)
        { return !(e == j); }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador aux in e.jugadores)
            {
                if (aux == j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count <= cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int cont = 0;

            if (e.directorTecnico != null && e.jugadores.Count == cantidadMaximaJugadores)
            {
                foreach (Jugador aux in e.jugadores)
                {
                    switch (aux.Posicion)
                    {
                        case Posicion.Arquero:
                            cont++;
                            if (cont > 1)
                            {
                                return retorno;
                            }
                            else retorno = true;
                            break;
                        case Posicion.Central:
                            retorno = true;
                            break;
                        case Posicion.Defensor:
                            retorno = true;
                            break;
                        case Posicion.Delantero:
                            retorno = true;
                            break;
                    }
                }
            }
            return retorno;
        }
    }
}
