using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EmisorDeWhatsapp : Emisor
    {
        private bool numeroCargado;
        private int numeroTelefono;

        public int NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set
            {
                if (value > 1500000000 && value < 1599999999)
                {
                    this.numeroTelefono = value;
                    this.numeroCargado = true;
                }
                else this.numeroCargado = false;
            }
        }

        public EmisorDeWhatsapp(string mensaje, EProducto producto):base(mensaje,producto)
        { }

        public override string EnviarMensaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine((string)this);

            if (this.numeroCargado == true)
            {
                sb.AppendLine("\n.Enviando mensaje");
            }
            else sb.AppendLine("\n.No se pudo enviar el mensaje");

            return sb.ToString();
        }

        public static explicit operator string(EmisorDeWhatsapp emisor)
        {
            StringBuilder sb = new StringBuilder();

            if (emisor.numeroCargado == true)
            {
                sb.AppendLine(emisor.ToString());
                sb.AppendFormat(" \n.{0} \n", emisor.numeroTelefono);
            }
            else sb.AppendLine(".No cargado");

            return sb.ToString();
        }
    }
}
