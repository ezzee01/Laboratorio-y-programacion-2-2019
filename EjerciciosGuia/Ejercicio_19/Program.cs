using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";

            Sumador suma = new Sumador(3);

            Console.WriteLine(suma.Sumar(2, 1));
            Console.WriteLine(suma.Sumar("2", "1"));

            Sumador suma2 = new Sumador();

            Console.WriteLine(suma + suma2);
            Console.WriteLine(suma | suma2);
            Console.WriteLine((int)suma);

            Console.ReadKey();
        }
    }
}
