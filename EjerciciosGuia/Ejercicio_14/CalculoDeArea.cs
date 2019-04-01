using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            double area;

            area = Math.Pow(numero, 2);

            return area;
        }

        public static double CalcularTriangulo(double numero1, double numero2)
        {
            double area;

            area = (numero1 * numero2) / 2;

            return area;
        }

        public static double CalcularCirculo(double numero)
        {
            double area;

            area = Math.PI * Math.Pow(numero, 2);

            return area;
        }
    }
}
