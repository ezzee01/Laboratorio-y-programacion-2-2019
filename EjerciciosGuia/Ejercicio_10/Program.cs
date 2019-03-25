﻿using System;
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

            Console.WriteLine("Ingrese altura: ");
            while (int.TryParse(Console.ReadLine(), out altura) == false)
            {
                Console.WriteLine("ERROR. Ingrese altura: ");
            }

            for (int i = 1; i <= altura; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}", asterisco);
                }
                else
                {
                    asterisco = "*" + asterisco + "*";
                    Console.WriteLine(asterisco);
                }
            }

            Console.ReadKey();
        }
    }
}
