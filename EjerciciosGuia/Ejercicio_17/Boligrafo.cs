using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_2
{
    class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        const short cantidadTintMaxima = 100;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            if (tinta <= 100)
            {
                this.tinta = tinta;
            }
            else if (tinta > 100)
            {
                this.tinta = 100;
            }
            else
            {
                this.tinta = 0;
            }
        }

        public short getTinta()
        {
            return this.tinta;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            bool retorno = false;

            if (this.tinta >= gasto)
            {
                for (int i = 1; i <= Math.Abs(gasto); i++)
                {
                    dibujo += "*";
                }
                Console.ForegroundColor = this.color;
                SetTinta((short)-gasto);
                //if (this.tinta < 0)
                //{
                //    dibujo = "No se pudo pintar";
                //}
                retorno = true;
            }
            else Console.ForegroundColor = ConsoleColor.White;
            //else
            //{
            //    retorno = true;
            //    dibujo = "No se pudo pintar";
            //}
            return retorno;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintMaxima);
        }

        private void SetTinta(short tinta)
        {
            short auxTinta = this.tinta;

            if (tinta >= -100 && tinta <= 100)
            {
                if (this.tinta >= 0 && this.tinta <= cantidadTintMaxima)
                {
                    if (tinta < 0)
                    {
                        this.tinta += tinta;
                    }
                    else
                    {
                        this.tinta += tinta;
                    }
                }
            }
        }
    }
}
