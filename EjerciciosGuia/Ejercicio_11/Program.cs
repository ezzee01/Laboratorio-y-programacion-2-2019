using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 11";

      int numero;
      int acumulador = 0;
      int min = int.MaxValue;
      int max = int.MinValue;
      float promedio;

      for (int i = 0; i < 10; i++)
      {
        Console.Write("Ingrese un numero entre -100 y 100: ");
        numero = int.Parse(Console.ReadLine());

        while (Validacion.Validar(numero, -100, 100) == false)
        {
          Console.WriteLine("Error, numero fuera de rango.");
          Console.Write("Ingrese un numero entre -100 y 100: ");
          numero = int.Parse(Console.ReadLine());
        }

        acumulador += numero;

        if (numero > max)
        {
          max = numero;
        }
        else if (numero < min)
        {
          min = numero;
        }
      }

      promedio = acumulador / 10;

      Console.Clear();
      Console.WriteLine("Valor maximo: {0}", max);
      Console.WriteLine("Valor minimo: {0}", min);
      Console.WriteLine("Promedio: {0}", promedio);
      Console.ReadKey();
    }
  }
}
