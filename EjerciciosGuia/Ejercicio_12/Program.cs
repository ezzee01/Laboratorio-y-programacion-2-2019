using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 12";

      int numero;
      int suma = 0;
      char respuesta;

      do
      {
        Console.Write("Ingrese un numero: ");
        int.TryParse(Console.ReadLine(), out numero);

        suma += numero;

        Console.Write("¿Continuar? (S/N): ");
        respuesta = char.Parse(Console.ReadLine());
        Console.Clear();
      } while (ValidarRespuesta.ValidaS_N(respuesta));

      Console.Write("Suma: {0}", suma);

      Console.ReadKey();
    }
  }
}
