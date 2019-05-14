using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Teclado : Periferico
  {
    #region atributos
    public enum EDistribucion
    {
      Dvorak, QWERTY, QWERTZ, AZERTY
    }

    private EDistribucion distribucion;
    #endregion

    #region constructores
    public Teclado(string marca, string modelo, EConector conector) : this(marca, modelo, conector, EDistribucion.Dvorak)
    {

    }

    public Teclado(string marca, string modelo, EConector conector, EDistribucion region) : base(marca, modelo, conector)
    {
      this.distribucion = region;
    }
    #endregion

    #region operadores
    public static bool operator !=(Teclado t, EDistribucion distribucion)
    {
      return !(t == distribucion);
    }

    public static bool operator ==(Teclado t, EDistribucion distribucion)
    {
      bool retorno = false;

      if (t.distribucion == distribucion)
      {
        retorno = true;
      }
      return retorno;
    }
    #endregion

    #region metodos
    public override string ExponerDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("TECLADO");
      sb.AppendLine((string)this);
      sb.AppendFormat("Distribución {0}\n", this.distribucion);

      return sb.ToString();
    }
    #endregion
  }
}
