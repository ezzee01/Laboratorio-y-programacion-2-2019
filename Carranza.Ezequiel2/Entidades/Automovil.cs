using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        private Automovil()
        {
            this.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
        {
            this.Patente = patente;
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora):this(patente, color)
        {
            this.valorHora = valorHora;
        }

        public string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Color: {0}", this.color);
            sb.AppendFormat("Valor hora: {0}", this.valorHora);
        }

        public override bool Equals(object obj)
        { }

        public override string ImprimirTicket()
        {
            return base.ImprimirTicket();
        }
    }
}
