using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double numero1, double numero2, string operacion)
        {
            double retorno = 0;

            switch (operacion)
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;
                case "-":
                    retorno = numero1 - numero2;
                    break;
                case "*":
                    retorno = numero1 * numero2;
                    break;
                case "/":
                    if (Validar(numero2) == false)
                    {
                        retorno = numero1 / numero2;
                    }
                    else
                    {
                        Console.Write("ERROR! ");
                        Console.Write("El divisor no puede ser cero. ");
                    }
                    break;
                default:
                    Console.Write("ERROR! ");
                    Console.Write("Operacion incorrecta. ");
                    break;
            }

            return retorno;
        }

        public static bool Validar(double numero2)
        {
            bool retorno = false;

            if (numero2 == 0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
