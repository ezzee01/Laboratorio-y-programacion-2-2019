using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "Error! El numero debe ser mayor a 0.";
            int resto;
            int entero = (int)numero;

            if(numero > 0)
            {
                binario = "";
            }

            while (entero > 0)
            {
                resto = entero % 2;
                entero = entero / 2;
                binario = resto.ToString() + binario;
            }

            return binario;
        }

        public static double BinarioDecimal(string binario)
        {
            double numero = -1;
            long numeroBinario;

            if (long.TryParse(binario, out numeroBinario))
            {
                if (numeroBinario > 0)
                {
                    numero = 0;
                    for (int i = 1; i <= binario.Length; i++)
                    {
                        if (binario.ElementAt(i - 1) == '1')
                        {
                            numero += Math.Pow(2, binario.Length - i);
                        }
                    }
                    return numero;
                }
                else return numero;
            }
            else return numero;
        }
    }
}
