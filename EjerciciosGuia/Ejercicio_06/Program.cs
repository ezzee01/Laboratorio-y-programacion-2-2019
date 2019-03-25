using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            int añoUno;
            int añoDos;

            Console.WriteLine("Calculadora de años bisiestos.");
            Console.WriteLine("----------------------------------");
            Console.Write("Ingrese un año: ");
            añoUno = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro año: ");
            añoDos = int.Parse(Console.ReadLine());

            while (añoDos <= añoUno)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("ERROR!, el segundo año ingresado no debe ser menor o igual al primero.");
                Console.WriteLine("----------------------------------");
                Console.Write("Ingrese un año: ");
                añoUno = int.Parse(Console.ReadLine());
                Console.Write("Ingrese otro año: ");
                añoDos = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Años bisiestos en ese rango: ");

            for (int i = añoUno; i <= añoDos; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 100 == 0 && i % 400 == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }

            Console.ReadKey();
        }
    }
}
