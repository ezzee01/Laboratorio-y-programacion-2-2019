using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Pesos
  {
    #region ATRIBUTOS
    private double cantidad;
    private static float cotizRespectoDolar = (float)42.12;
    #endregion

    #region CONSTRUCTORES
    private Pesos()
    { }

    public Pesos(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Pesos(double cantidad, float cotizacion) : this(cantidad)
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
    public static explicit operator Dolar(Pesos p)
    {
      return (Dolar)p;
    }

    public static explicit operator Euro(Pesos p)
    {
      return (Euro)p;
    }

    public static implicit operator Pesos(double d)
    {
      Pesos pesos = new Pesos(d);
      return pesos;
    }

    public static bool operator !=(Pesos p, Dolar d)
    {
      return !(p == d);
    }

    public static bool operator !=(Pesos p, Euro e)
    {
      return !(p == e);
    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return !(p1 == p2);
    }

    public static Pesos operator -(Pesos p, Dolar d)
    { }

    public static Pesos operator -(Pesos p, Euro e)
    { }

    public static Pesos operator +(Pesos p, Dolar d)
    { }

    public static Pesos operator +(Pesos p, Euro e)
    { }

    public static bool operator ==(Pesos p, Dolar d)
    {
      bool retorno = false;

      if (p.cantidad == d.GetCantidad())
      {
        retorno = true;
      }
      return retorno;
    }

    public static bool operator ==(Pesos p, Euro e)
    {
      bool retorno = false;

      if (p.cantidad == e.GetCantidad())
      {
        retorno = true;
      }
      return retorno;
    }

    public static bool operator ==(Pesos p1, Pesos p2)
    {
      bool retorno = false;

      if (p1.cantidad == p2.cantidad)
      {
        retorno = true;
      }
      return retorno;
    }
    #endregion
  }
}
