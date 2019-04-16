using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
  class PuestoAtencion
  {
    #region ATRIBUTOS
    public enum Puesto
    {
      Caja1,
      Caja2
    }
    private static int numeroActual;
    private Puesto puesto;
    #endregion

    #region PROPIEDADES
    public static int NumeroActual
    {
      get
      {
        numeroActual++;
        return numeroActual;
      }
    }
    #endregion

    #region CONSTRUCTORES Y METODOS
    static PuestoAtencion()
    {
      numeroActual = 0;
    }

    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }

    public bool Atender(Cliente cli)
    {
      Thread.Sleep(1000);
      return true;
    }
    #endregion
  }
}
