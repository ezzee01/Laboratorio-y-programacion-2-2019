using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 31 Consola";

      Negocio negocio = new Negocio("Heladeria");
      Cliente c1 = new Cliente(1, "cliente1");
      Cliente c2 = new Cliente(2, "cliente2");
      Cliente c3 = new Cliente(3, "cliente3");
      Cliente c4 = new Cliente(4, "cliente4");

      negocio.Cliente = c1;
      negocio.Cliente = c2;
      negocio.Cliente = c3;
      negocio.Cliente = c4;

      while(~negocio)
      {
        Console.WriteLine("Cliente atendido");
      }
      Console.WriteLine("Sin clientes");

      Console.ReadKey();
    }
  }
}
