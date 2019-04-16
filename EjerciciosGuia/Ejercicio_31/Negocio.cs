using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
  class Negocio
  {
    #region ATRIBUTOS
    private PuestoAtencion caja;
    private Queue<Cliente> cliente;
    private string nombre;
    #endregion

    #region CONTRUCTORES
    private Negocio()
    {
      cliente = new Queue<Cliente>();
      caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
    }

    public Negocio(string nombre)
    {
      this.nombre = nombre;
    }
    #endregion

    #region PROPIEDADES
    public Cliente Cliente
    {
      get { return this.cliente.Dequeue(); }
      set {  == this.Cliente  }
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
      foreach(Cliente aux in n.cliente)
      {
        if(aux == c)
        {
          retorno = false;
        }
        else
        {
          n.cliente.Enqueue(c);
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      bool retorno = false;
      foreach(Cliente aux in n.cliente)
      {
        if(aux == c)
        {
          retorno = true;
        }
        else
        {
          retorno = false;
        }
      }
      return retorno;
    }
    #endregion
  }
}
