using System;

namespace Entidades
{
    public abstract class Emisor
    {
        public enum EProducto { SQLDatabase, MonitoringApp, AppHosting }
        private string mensaje;
        private EProducto producto;

        protected Emisor(string mensaje, EProducto producto)
        {
            this.mensaje = mensaje;
            this.producto = producto;
        }

        public abstract string EnviarMensaje();

        public static bool operator ==(Emisor emisor, Emisor emisorDos)
        {
            bool ret = false;
            if (emisor.mensaje == emisorDos.mensaje && emisor.producto == emisorDos.producto)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Emisor emisor, Emisor emisorDos)
        {
            return !(emisor == emisorDos);
        }

        public override string ToString()
        {
            return string.Format(" \n." + this.producto + " \n." + this.mensaje);
        }
    }
}
