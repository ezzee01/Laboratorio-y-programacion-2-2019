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

    //public bool Pintar(int gasto, out string dibujo)
    //{ }

    public void Recargar()
    {
      //SetTinta();
    }

    private void SetTinta(short tinta)
    {
      
    }
  }
}
