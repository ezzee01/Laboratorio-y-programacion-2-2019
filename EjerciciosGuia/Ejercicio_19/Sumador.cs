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

    //public static explicit operator int (Sumador s)
    //{ }

    //public  static bool operator |(Sumador s1, Sumador s2)
    //{ }

    //public static long operator +(Sumador s1, Sumador s2)
    //{ }

    public long Sumar (long a , long b)
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
