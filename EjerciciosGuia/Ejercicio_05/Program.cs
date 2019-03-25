using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            int numero;
            int sumaUno;
            int sumaDos;
            int contador = 0;

            Console.Write("Ingrese un numero entero mayor a 0: ");
            numero = int.Parse(Console.ReadLine());

            while (numero < 1)
            {
                Console.Write("Error, el numero debe ser mayor a 0. Reingrese: ");
                numero = int.Parse(Console.ReadLine());
            }

            while (contador < numero)
            {
                contador++;
                sumaUno = 0;
                sumaDos = 0;

                for (int i = 1; i < contador; i++)
                {
                    sumaUno += i;
                }

                for (int j = contador + 1; j <= sumaUno; j++)
                {
                    if (sumaUno == sumaDos || sumaDos > sumaUno)
                    {
                        break;
                    }

                    sumaDos += j;
                }

                if (sumaDos == sumaUno)
                {
                    Console.WriteLine("Centros numericos: {0}, ", contador);
                }
            }

            Console.ReadKey();
        }
    }
}
