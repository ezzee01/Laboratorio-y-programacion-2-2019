using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 19";

      Sumador suma = new Sumador(3);

      suma.Sumar(2, 1);
      suma.Sumar("2","1");

      Console.ReadKey();
    }
  }
}
