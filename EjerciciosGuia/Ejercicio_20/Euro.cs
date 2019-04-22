using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        #region ATRIBUTOS
        private double cantidad;
        private static float cotizRespectoDolar;
        #endregion

        #region CONSTRUCTORES
        static Euro()
        {
            cotizRespectoDolar = (float)1.13;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        { }
        #endregion

        #region PROPIEDADES
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion

        #region OPERADORES
        public static explicit operator Dolar(Euro e)
        {
            return (Dolar)e;
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)e;
        }

        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        { }

        public static Euro operator -(Euro e, Pesos p)
        { }

        public static Euro operator +(Euro e, Dolar d)
        { }

        public static Euro operator +(Euro e, Pesos p)
        { }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;

            if (e.cantidad == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;

            if (e.cantidad == p.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (e1.cantidad == e2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
