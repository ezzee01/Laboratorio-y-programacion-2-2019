using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
  class Alumno
  {
    private byte nota1;
    private byte nota2;
    private byte notaFinal;
    public string apellido;
    public string nombre;
    public int legajo;
    public static string colegio;
    static Random random;

    public Alumno(string apellido, string nombre)
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }

    static Alumno() //Es siempre publico sin visibilidad
    {
      colegio = "UTN"; //sin this
      random = new Random();
    }

    public void CalcularFinal()
    { }

    public void Estudiar(byte notaUno, byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }

    public string Mostrar()
    {
      return this.legajo.ToString() + " " + this.apellido + " " + this.nombre + " " + colegio + (this.notaFinal == 11 ? "DESAPROBADO" : this.notaFinal.ToString()); //colegio sin this por ser estatico,
      //(condicion ? "desaprobado": "aprobado")
    }
  }
}
