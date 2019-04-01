using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            string operacion;
            double numeroUno;
            double numeroDos;

            Console.WriteLine("Calculadora.");
            Console.WriteLine("--------------");

            Console.Write("Ingrese primer numero: ");
            while (double.TryParse(Console.ReadLine(), out numeroUno) == false)
            {
                Console.Write("ERROR! ");
                Console.Write("Reingrese primer numero: ");
            }

            Console.Write("Ingrese operacion: ");
            operacion = Console.ReadLine();

            Console.WriteLine("Ingrese segundo numero: ");
            while (double.TryParse(Console.ReadLine(), out numeroDos) == false)
            {
                Console.Write("ERROR! ");
                Console.Write("Reingrese segundo numero: ");
            }

            Console.WriteLine("Resultado: {0}", Calculadora.Calcular(numeroUno, numeroDos, operacion));

            Console.ReadKey();
        }
    }
}
