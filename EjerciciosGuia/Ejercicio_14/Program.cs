using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            int opcion;
            double lado;
            double altura;
            double radio;
            string respuesta = "n";

            while (respuesta == "n")
            {
                Console.WriteLine("Calculadora de areas.");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1_Cuadrado.");
                Console.WriteLine("2_Triangulo.");
                Console.WriteLine("3_Circulo.");
                Console.WriteLine("4_Salir.");
                Console.Write("Seleccione una opción: ");

                while (int.TryParse(Console.ReadLine(), out opcion) == false || opcion < 1 || opcion > 4)
                {
                    Console.Write("ERROR! ");
                    Console.Write("Seleccione una opción: ");
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Area del cuadrado.");
                        Console.WriteLine("--------------------");
                        Console.Write("Ingrese valor del lado: ");
                        while (double.TryParse(Console.ReadLine(), out lado) == false || lado < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor del lado: ");
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Area del cuadrado: {0}", CalculoDeArea.CalcularCuadrado(lado));
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Presione una tecla para continuar..");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Area del triangulo.");
                        Console.WriteLine("--------------------");
                        Console.Write("Ingrese valor de la base: ");
                        while (double.TryParse(Console.ReadLine(), out lado) == false || lado < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor de la base: ");
                        }

                        Console.Write("Ingrese valor de la altura: ");
                        while (double.TryParse(Console.ReadLine(), out altura) == false || altura < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor de la altura: ");
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Area del triangulo: {0}", CalculoDeArea.CalcularTriangulo(lado, altura));
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Presione una tecla para continuar..");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Area del circulo.");
                        Console.WriteLine("--------------------");
                        Console.Write("Ingrese valor del radio: ");
                        while (double.TryParse(Console.ReadLine(), out radio) == false || radio < 0)
                        {
                            Console.Write("ERROR! ");
                            Console.Write("Reingrese valor del radio: ");
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Area del circulo: {0}", CalculoDeArea.CalcularCirculo(radio));
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Presione una tecla para continuar..");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("¿Desea salir? (S/N): ");
                        respuesta = Console.ReadLine().ToLower();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
