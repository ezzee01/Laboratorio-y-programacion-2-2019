using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 08";

      int valorHora = 0;
      String nombre = "";
      int antiguedad = 0;
      int horasTrabajadas = 0;
      float totalBruto = 0;
      int porcentajeDescuento = 13;
      float descuento = 0;
      float totalNeto = 0;
      string respuesta;

      do
      {
        Console.Write("Nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Valor hora: ");
        int.TryParse(Console.ReadLine(), out valorHora);
        Console.Write("Antiguedad: ");
        int.TryParse(Console.ReadLine(), out antiguedad);
        Console.Write("Horas Trabajadas: ");
        int.TryParse(Console.ReadLine(), out horasTrabajadas);

        totalBruto = valorHora * horasTrabajadas + antiguedad * 150;
        descuento = totalBruto * porcentajeDescuento / 100;
        totalNeto = totalBruto - descuento;

        //Console.Clear();
        Console.WriteLine("\n-------------RECIBO----------------\n" +
                            "Nombre: {0}\n" +
                            "Antiguedad: {1} años\n" +
                            "Valor Hora: ${2}\n" +
                            "Total Bruto: ${3}\n" +
                            "Descuento: {4}% (${5})\n" +
                            "Total Neto: ${6}\n" +
                            "-----------------------------------"
                            , nombre, antiguedad, valorHora, totalBruto, porcentajeDescuento, descuento, totalNeto);


        Console.Write("¿Desea ingresar otro empleado? (S/N): ");
        respuesta = Console.ReadLine().ToLower();
      } while (respuesta == "s");


      //Console.ReadKey();
    }
  }
}
