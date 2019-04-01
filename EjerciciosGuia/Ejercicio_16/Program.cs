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
      Console.Title = "Ejercicio Nro 16";

      //CON CONSTRUCTOR
      //Alumno alumno1 = new Alumno("Perez", "Pedro", 0001);
      //Alumno alumno2 = new Alumno("Conti", "Alejandro", 0002);
      //Alumno alumno3 = new Alumno("Gomez", "Martin", 0003);

      //SIN CONSTRUCTOR
      Alumno alumno1 = new Alumno();
      Alumno alumno2 = new Alumno();
      Alumno alumno3 = new Alumno();

      alumno1.apellido = "Perez";
      alumno1.nombre = "Pedro";
      alumno1.legajo = 1001;

      alumno2.apellido = "Conti";
      alumno2.nombre = "Alejandro";
      alumno2.legajo = 1002;

      alumno3.apellido = "Gomez";
      alumno3.nombre = "Martin";
      alumno3.legajo = 1003;

      alumno1.Estudiar(7, 9);
      alumno1.CalcularFinal();

      alumno2.Estudiar(5, 3);
      alumno2.CalcularFinal();

      alumno3.Estudiar(2, 2);
      alumno3.CalcularFinal();

      Console.WriteLine("Legajo-----Apellido-----Nombre-----Nota Final");
      Console.WriteLine(alumno1.Mostrar());
      Console.WriteLine(alumno2.Mostrar());
      Console.WriteLine(alumno3.Mostrar());

      Console.ReadKey();
    }
  }
}
