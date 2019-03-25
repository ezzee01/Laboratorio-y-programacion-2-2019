using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            DateTime date;
            int año;
            int dias = 0;
            int diasNow = 0;
            int diasVividos;
            int contadorAñosBisiestos = 0;
            int contador = 0;

            Console.Write("Ingrese fecha de nacimiento (aa/bb/cccc): ");
            date = DateTime.Parse(Console.ReadLine());
            año = date.Year;

            for (int i = año + 1; i <= DateTime.Now.Year; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 100 == 0 && i % 400 == 0)
                {
                    contadorAñosBisiestos++;
                }
                else contador++;
            }

            for (int i = date.Month; i <= 12; i++)
            {
                switch (i)
                {
                    case 01:
                        dias += 31;
                        break;
                    case 02:
                        if (año % 4 == 0 && año % 100 != 0 || año % 100 == 0 && año % 400 == 0)
                        {
                            dias += 29;
                        }
                        else dias += 28;
                        break;
                    case 03:
                        dias += 31;
                        break;
                    case 04:
                        dias += 30;
                        break;
                    case 05:
                        dias += 31;
                        break;
                    case 06:
                        dias += 30;
                        break;
                    case 07:
                        dias += 31;
                        break;
                    case 08:
                        dias += 31;
                        break;
                    case 09:
                        dias += 30;
                        break;
                    case 10:
                        dias += 31;
                        break;
                    case 11:
                        dias += 30;
                        break;
                    case 12:
                        dias += 31;
                        break;
                }
            }

            for (int i = DateTime.Now.Month; i <= 12; i++)
            {
                switch (i)
                {
                    case 01:
                        diasNow += 31;
                        break;
                    case 02:
                        if (año % 4 == 0 && año % 100 != 0 || año % 100 == 0 && año % 400 == 0)
                        {
                            diasNow += 29;
                        }
                        else diasNow += 28;
                        break;
                    case 03:
                        diasNow += 31;
                        break;
                    case 04:
                        diasNow += 30;
                        break;
                    case 05:
                        diasNow += 31;
                        break;
                    case 06:
                        diasNow += 30;
                        break;
                    case 07:
                        diasNow += 31;
                        break;
                    case 08:
                        diasNow += 31;
                        break;
                    case 09:
                        diasNow += 30;
                        break;
                    case 10:
                        diasNow += 31;
                        break;
                    case 11:
                        diasNow += 30;
                        break;
                    case 12:
                        diasNow += 31;
                        break;
                }
            }

            diasVividos = (contador * 365) + (contadorAñosBisiestos * 366) + (dias - date.Day) - (diasNow - DateTime.Now.Day);

            Console.WriteLine("Tiene {0} dias vividos", diasVividos);

            Console.ReadKey();
        }
    }
}
