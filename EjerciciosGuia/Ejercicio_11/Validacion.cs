using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
   class Validacion
  {
    public static bool Validar(int valor, int min, int max)
    {
      bool retorno = false;

      if(valor >= -100 && valor <= 100)
      {
        retorno = true;
      }

      return retorno;
    }
  }
}
