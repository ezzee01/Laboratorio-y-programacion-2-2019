using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Dolar
  {
    #region ATRIBUTOS
    private double cantidad;
    private static float cotizRespectoDolar;
    #endregion

    #region CONSTRUCTORES
    static Dolar()
    {
            cotizRespectoDolar = 1;
    }

    public Dolar(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Dolar(double cantidad, float cotizacion) : this(cantidad)
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

    // 1 Euro equivale a 1,13 dólares y 1 dólar equivale a 42,12 pesos  1 e---- 1.13 d

    #region OPERADORES
    public static explicit operator Euro(Dolar d)
    {
      return (Euro)d;
    }

    public static explicit operator Pesos(Dolar d)
    {
      return (Pesos)d;
    }

    public static implicit operator Dolar(double d)
    {
      Dolar dolar = new Dolar(d);
      return dolar;
    }

    public static bool operator !=(Dolar d, Euro e)
    {
      return !(d == e);
    }

    public static bool operator !=(Dolar d, Pesos e)
    {
      return !(d == e);
    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return !(d1 == d2);
    }

    public static Dolar operator -(Dolar d, Euro e)
    { }

    public static Dolar operator -(Dolar d, Pesos p)
    { }

    public static Dolar operator +(Dolar d, Euro e)
    { }

    public static Dolar operator +(Dolar d, Pesos p)
    { }

    public static bool operator ==(Dolar d, Euro e)
    {
      bool retorno = false;

      if (d.cantidad == e.GetCantidad())
      {
        retorno = true;
      }

      return retorno;
    }

    public static bool operator ==(Dolar d, Pesos p)
    {
      bool retorno = false;

      if (d.cantidad == p.GetCantidad())
      {
        retorno = true;
      }
      return retorno;
    }

    public static bool operator ==(Dolar d1, Dolar d2)
    {
      bool retorno = false;

      if (d1.cantidad == d2.cantidad)
      {
        retorno = true;
      }
      return retorno;
    }
    #endregion
  }
}
