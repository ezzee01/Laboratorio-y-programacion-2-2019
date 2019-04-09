using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
  class Rectangulo
  {
    private float area;
    private float perimetro;
    private Punto vertice1;
    private Punto vertice2;
    private Punto vertice3;
    private Punto vertice4;

    public Rectangulo(Punto vertice1, Punto vertice3)
    {
      this.vertice1 = vertice1;
      this.vertice3 = vertice3;
    }

    public float Area()
    {
      float base1;
      float altura;

      base1 = Math.Abs(vertice3.GetX()) - Math.Abs(vertice1.GetX());
      altura = Math.Abs(vertice2.GetY()) - Math.Abs(vertice1.GetY());

      area = base1 * altura;
      return this.area;
    }

    public float Perimetro()
    {
      float base1;
      float altura;

      base1 = Math.Abs(vertice3.GetX()) - Math.Abs(vertice1.GetX());
      altura = Math.Abs(vertice2.GetY()) - Math.Abs(vertice1.GetY());

      perimetro = (base1 + altura) * 2;
      return this.perimetro;
    }
  }
}
