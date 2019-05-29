using System;
using System.Collections.Generic;
using System.Text;

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

        public ManejadorDeEmisores(string region):this()
        {
            this.region = region;
        }

        public string EnviarMensajes()
        {
            string ret = "";
            foreach(Emisor aux in this.emisores)
            {
                ret = aux.EnviarMensaje();
            }

            return ret;
        }

        public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisor)
        {
            return !(manejador == emisor);
        }

        public static bool operator ==(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool ret = false;

            foreach(Emisor e in manejador.emisores)
            {
                if(e == emisor)
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

            if(manejador != emisor)
            {
                manejador.emisores.Add(emisor);
                ret = true;
            }
            return ret;
        }

        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            bool ret = false;
            foreach (Emisor e in manejador.emisores)
            {
                if (manejador == emisor)
                {
                    manejador.emisores.Remove(emisor);
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(".Region: {0}\n", this.region);

            foreach(Emisor e in this.emisores)
            {
                sb.AppendLine(e.EnviarMensaje());
            }

            return sb.ToString();
        }
    }
}
