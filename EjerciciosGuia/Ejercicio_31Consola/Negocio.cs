using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31Consola
{
  class Negocio
  {
    #region ATRIBUTOS
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;
    #endregion

    #region CONTRUCTORES
    private Negocio()
    {
      clientes = new Queue<Cliente>();
      caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
    }

    public Negocio(string nombre) : this()
    {
      this.nombre = nombre;
    }
    #endregion

    #region PROPIEDADES
    public Cliente Cliente
    {
      get
      {
        if (this.clientes.Count != 0)
        {
          return this.clientes.Dequeue();
        }
        else return null;
      }
      set
      {
        bool var = this + value;
      }
    }

    public int ClientesPendientes
    {
      get { return this.clientes.Count; }
    }
    #endregion

    #region OPERADORES
    public static bool operator !=(Negocio n, Cliente c)
    {
      return !(n == c);
    }

    public static bool operator ~(Negocio n)
    {
      if (n.caja.Atender(n.Cliente))
      {
        return true;
      }
      else return false;
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      bool retorno = false;

      if (n != c)
      {
        n.clientes.Enqueue(c);
        retorno = true;
      }
      return retorno;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      bool retorno = false;

      foreach (Cliente aux in n.clientes)
      {
        if (aux == c)
        {
          retorno = true;
          break;
        }
      }
      return retorno;
    }
    #endregion
  }
}
