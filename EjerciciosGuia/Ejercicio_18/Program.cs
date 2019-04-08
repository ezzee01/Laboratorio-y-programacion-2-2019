using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";

            Punto punto1 = new Punto(2, 5);
            Punto punto2 = new Punto(4, 3);

            Rectangulo rectangulo = new Rectangulo(punto1, punto2);

            Console.WriteLine(rectangulo.Area());
            Console.WriteLine(rectangulo.Perimetro());

            Console.ReadKey();
        }
    }
}
