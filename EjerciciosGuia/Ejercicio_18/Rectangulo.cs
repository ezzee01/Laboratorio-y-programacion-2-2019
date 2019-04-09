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
      this.vertice1 = new Punto(vertice1.GetX(), vertice1.GetY());
      this.vertice3 = new Punto(vertice3.GetX(), vertice3.GetY());
      this.vertice2 = new Punto;
      this.vertice4 = new Punto()
    }

    public float Area()
    {
      float base1;
      float altura;

      base1 = Math.Abs(this.vertice3.GetX()) - Math.Abs(this.vertice1.GetX());
      altura = Math.Abs(this.vertice2.GetY()) - Math.Abs(this.vertice1.GetY());

      this.area = base1 * altura;
      return this.area;
    }

    public float Perimetro()
    {
      float base1;
      float altura;

      base1 = Math.Abs(this.vertice3.GetX()) - Math.Abs(this.vertice1.GetX());
      altura = Math.Abs(this.vertice2.GetY()) - Math.Abs(this.vertice1.GetY());

      this.perimetro = (base1 + altura) * 2;
      return this.perimetro;
    }
  }
}
