using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        #region atributos
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;
        #endregion

        #region constructores
        private Maquina()
        {
            perifericos = new List<Periferico>();
            cantidadMaxPerifericos = 3;
        }

        public Maquina(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region propiedades
        public int CantidadMaximaPerifericos
        {
            get
            { return this.cantidadMaxPerifericos; }
            set
            {
                if (value < 1)
                {
                    this.cantidadMaxPerifericos = 1;
                }
                else
                   if (value > 4)
                {
                    this.cantidadMaxPerifericos = 4;
                }
                else this.cantidadMaxPerifericos = value;

            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.nombre);
                foreach(Periferico p in this.perifericos)
                {
                    sb.AppendLine(p.ExponerDatos());
                }
                return sb.ToString();
            }
        }

        #endregion

        #region operadores
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }

        public static bool operator ==(Maquina m, Periferico p)
        {
            bool retorno = false;
            foreach (Periferico aux in m.perifericos)
            {
                if (aux == p)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static string operator +(Maquina m, Periferico p)
        {
            string retorno = "No se puede conectar el dispositivo.";

            if (m != p && m.perifericos.Count < m.cantidadMaxPerifericos)
            {
                m.perifericos.Add(p);
                retorno = "Periferico conectado!";
            }
            return retorno;
        }

        public static string operator -(Maquina m, Periferico p)
        {
            string retorno = "No se puede desconectar el dispositivo.";
                        
            if (m == p)
            {
                m.perifericos.Remove(p);
                retorno = "Periferico desconectado!";
            }
            return retorno;
        }
        #endregion
    }
}
