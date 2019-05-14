using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class PlacaVideo : Periferico
  {
    #region atributos
    private int ramMB;
    #endregion

    #region constructores
    public PlacaVideo(string marca, string modelo, int ram) : base(marca, modelo, EConector.PCIExpress)
    {
      this.ramMB = ram;
    }
    #endregion

    #region metodos
    public override string ExponerDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("PLACA DE VIDEO");
      sb.AppendLine((string)this);
      sb.AppendFormat("Memoria {0}MB\n", this.ramMB);

      return sb.ToString();
    }
    #endregion

  }
}
