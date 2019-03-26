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

      int valorHora;
      string nombre;
      int antiguedad;
      int cantHorasTrabajadas;
      int cantEmpleados = 0;
      string respuesta = "s";
      float valorACobrar = 0;
      float descuentos;
      float valorCobrado;
      string resultadoMostrar;

      do
      {
        Console.Write("Ingrese nombre del empleado: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese antiguedad: ");
        antiguedad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese valor hora: ");
        valorHora = int.Parse(Console.ReadLine());
        Console.Write("Ingrese cantidad de horas trabajadas en el mes: ");
        cantHorasTrabajadas = int.Parse(Console.ReadLine());

        cantEmpleados++;

        valorACobrar = (float)(valorHora * cantHorasTrabajadas) + (antiguedad * 150);
        descuentos = (float)valorACobrar * 13 / 100;
        valorCobrado = valorACobrar - descuentos;
        Console.WriteLine("Nombre-----Antiguedad-----Valor Hora-----Total Bruto-----Desc-----Total Neto");
        Console.WriteLine("{0}     {1}              {2}             {3}      {4}     {5}", nombre, antiguedad, valorHora, valorACobrar, descuentos, valorCobrado);

        Console.Write("Desea ingresar mas empleados?(S/N): ");
        respuesta = Console.ReadLine().ToLower();
        Console.Clear();
      } while (respuesta == "s");

      //Console.ReadKey();
    }
  }
}
