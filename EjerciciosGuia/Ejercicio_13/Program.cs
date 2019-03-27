using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 13";

      double numeroDecimal;
      string numeroBinario;
      double numeroEnDecimal;
      string numeroEnBinario;

      Console.Write("Ingrese numero decimal: ");
      numeroDecimal = double.Parse(Console.ReadLine());

      numeroEnBinario = Conversor.DecimalBinario(numeroDecimal);

      Console.WriteLine("El numero decimal en binario es: {0}", numeroEnBinario);

      Console.Write("Ingrese numero binario: ");

      numeroBinario = Console.ReadLine();

      numeroEnDecimal = Conversor.BinarioDecimal(numeroBinario);

      Console.WriteLine("El numero binario en decimal es: {0}", numeroEnDecimal);

      Console.ReadKey();
    }
  }
}
