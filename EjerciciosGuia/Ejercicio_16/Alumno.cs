using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_16
{
  class Alumno
  {
    private byte nota1;
    private byte nota2;
    private float notaFinal;
    public string apellido;
    public string nombre;
    public int legajo;
    Random final = new Random();

    //CON CONSTRUCTOR
    //public Alumno(string apellido, string nombre, int legajo)
    //{
    //  this.nombre = nombre;
    //  this.apellido = apellido;
    //  this.legajo = legajo;
    //}

    public void CalcularFinal()
    {
      if (nota1 >= 4 && nota2 >= 4)
      {
        this.notaFinal = final.Next(1, 10);
      }
      else this.notaFinal = -1;
    }

    public void Estudiar(byte notaUno, byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }

    public string Mostrar()
    {
      string cadena = this.legajo.ToString() + "       " + this.apellido + "        " + this.nombre + "      ";

      if (notaFinal != -1)
      {
        cadena += this.notaFinal.ToString();
      }
      else cadena += "Alumno desaprobado";
      return cadena;
    }
  }
}
