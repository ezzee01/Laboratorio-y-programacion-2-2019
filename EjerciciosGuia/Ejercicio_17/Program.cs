using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17_2;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";

            string dibujo;
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);

            if (boligrafo1.Pintar(50, out dibujo))
            {
                Console.Write("{0}\n", dibujo);
            }
            else
            {
                Console.Write("No se pudo pintar");
            }


            if (boligrafo2.Pintar(50, out dibujo))
            {
                Console.Write("{0}\n", dibujo);
            }
            else
            {
                Console.Write("No se pudo pintar");
            }


            if (boligrafo1.Pintar(50, out dibujo))
            {
                Console.Write("{0}\n", dibujo);
            }
            else
            {
                Console.Write("No se pudo pintar");
            }

            boligrafo2.Recargar();

            if (boligrafo2.Pintar(50, out dibujo))
            {
                Console.Write("{0}\n", dibujo);
            }
            else
            {
                Console.Write("No se pudo pintar");
            }

            if (boligrafo1.Pintar(50, out dibujo)) //Sin tinta
            {
                Console.Write("{0}\n", dibujo);
            }
            else
            {
                Console.Write("No se pudo pintar");
            }

            Console.ReadKey();
        }
    }
}
