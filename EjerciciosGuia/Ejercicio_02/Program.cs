using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 02";

      int numero;
      int cubo;
      int cuadrado;

      Console.Write("Ingrese un numero: ");
      numero = int.Parse(Console.ReadLine());      

      while(numero <= 0)
      {
        Console.WriteLine("ERROR. ¡Reingresar número!");
        Console.Write("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());
      }

      cubo = int.Parse(Math.Pow(numero, 3).ToString());
      cuadrado = int.Parse(Math.Pow(numero, 2).ToString());

      Console.WriteLine("Cubo: {0}", cubo);
      Console.WriteLine("Cuadrado: {0}", cuadrado);

      Console.ReadKey();
    }
  }
}
