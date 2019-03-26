using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumno1 = new Alumno("", "");
      Alumno alumno2 = new Alumno("", "");
      Alumno alumno3 = new Alumno("", "");
      //Alumno.colegio = "UTN";
      //alumno1.apellido = "Perez";

      alumno1.Estudiar(8, 9);

      Console.WriteLine(alumno1.Mostrar());
      Console.ReadKey();
    }
  }
}
