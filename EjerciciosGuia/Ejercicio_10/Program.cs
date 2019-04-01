using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            int altura;
            string asterisco = "*";
            string espacio = " ";
            int indice;
            //string espacioAsterisco = "";

            Console.WriteLine("Ingrese altura: ");
            while (int.TryParse(Console.ReadLine(), out altura) == false)
            {
                Console.WriteLine("ERROR. Ingrese altura: ");
            }

            for (int i = altura, z = 1; i > 0; i--, z += 2)
            {
                for (int g = i; g >= 0; g--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < z; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
