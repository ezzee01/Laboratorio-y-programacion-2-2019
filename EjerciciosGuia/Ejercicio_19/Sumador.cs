using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador() : this(0)
        { }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long retorno = s1.cantidadSumas + s2.cantidadSumas;
            return retorno;
        }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }
    }
}
