using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  #region enumerado
  public enum EConector
  {
    PCIExpress, USB, MiniUSB, MicroUSB, PS2
  }
  #endregion

  public abstract class Periferico
  {
    #region atributos
    private EConector conector;
    private string marca;
    private string modelo;
    #endregion

    #region constructores
    public Periferico(string marca, string modelo, EConector conector)
    {
      this.marca = marca;
      this.modelo = modelo;
      this.conector = conector;
    }
    #endregion

    #region operadores
    public static explicit operator string(Periferico p)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(string.Format(" " + p.marca + " " + p.modelo + " <Puerto: {0}>", p.conector.ToString()));
      

      return sb.ToString();
    }

    public static bool operator ==(Periferico p1, Periferico p2)
    {
      bool retorno = false;
      if (p1.marca == p2.marca && p1.modelo == p2.modelo)
      {
        retorno = true;
      }
      return retorno;
    }

    public static bool operator !=(Periferico p1, Periferico p2)
    {
      return !(p1 == p2);
    }
    #endregion

    #region metodos
    public abstract string ExponerDatos();
    #endregion
  }
}
