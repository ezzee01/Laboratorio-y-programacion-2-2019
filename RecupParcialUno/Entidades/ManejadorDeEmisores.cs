using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class ManejadorDeEmisores
  {
    private List<Emisor> emisores;
    private string region;

    private ManejadorDeEmisores()
    {
      emisores = new List<Emisor>();
    }

    public ManejadorDeEmisores(string region) : this()
    {
      this.region = region;
    }

    public string EnviarMensajes()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(this.ToString());
      //foreach (Emisor e in this.emisores)
      //{
      //  sb.AppendLine(e.EnviarMensaje());
      //}

      return sb.ToString();
    }

    public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisor)
    {
      return !(manejador == emisor);
    }

    public static bool operator ==(ManejadorDeEmisores manejador, Emisor emisor)
    {
      bool ret = false;

      foreach (Emisor e in manejador.emisores)
      {
        if (e == emisor)
        {
          ret = true;
          break;
        }
      }
      return ret;
    }

    public static bool operator +(ManejadorDeEmisores manejador, Emisor emisor)
    {
      bool ret = false;

      if (manejador != emisor)
      {
        manejador.emisores.Add(emisor);
        ret = true;
      }
      return ret;
    }

    public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
    {
      bool ret = false;

      if (manejador == emisor)
      {
        for (int i = 0; i < manejador.emisores.Count; i++)
        {
          if(emisor == manejador.emisores.ElementAt(i))
          {
            manejador.emisores.RemoveAt(i);
            ret = true;
            break;
          }
        }
      }

      return ret;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendFormat("\n.Region: {0}\n", this.region);

      foreach (Emisor e in this.emisores)
      {
        sb.AppendLine(e.EnviarMensaje());
      }

      return sb.ToString();
    }
  }
}
