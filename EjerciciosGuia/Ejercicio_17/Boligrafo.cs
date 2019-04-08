using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_2
{
    class Boligrafo
    {
        private ConsoleColor color = new ConsoleColor();
        private short tinta;
        const short cantidadTintMaxima = 100;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
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

            if (this.tinta > 0)
            {
                SetTinta((short)gasto);
                for (int i = 0; i <= gasto; i++)
                {
                    dibujo += "*";
                }
                return true;
            }
            else
                return false;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintMaxima);
        }

        private void SetTinta(short tinta)
        {
            short auxTinta = this.tinta;

            while (tinta >= -100 && tinta <= 100)
            {
                if (tinta > 0)
                {
                    if (auxTinta + tinta <= 100)
                    {
                        this.tinta += tinta;
                    }

                    if (tinta == cantidadTintMaxima)
                    {
                        this.tinta = cantidadTintMaxima;
                    }
                }
                else
                {
                    if (auxTinta - tinta >= 0)
                    {
                        this.tinta -= tinta;
                    }
                }
            }
        }
    }
}
