using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
  class ValidarRespuesta
  {
    public static bool ValidaS_N(char c)
    {
      bool retorno = false;

      c = char.ToUpper(c);

      if(c == 'S')
      {
        retorno = true;
      }

      return retorno;
    }
  }
}
