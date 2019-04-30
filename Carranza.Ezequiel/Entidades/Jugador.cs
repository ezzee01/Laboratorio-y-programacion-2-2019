using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Posicion
    {
        Arquero, Defensor, Central, Delantero
    }

    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura { get { return this.altura; } }

        public float Peso { get { return this.peso; } }

        public Posicion Posicion { get { return this.posicion; } }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if (this.Edad <= 40 && ValidarEstadoFisico())
            {
                retorno = true;
            }

            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Peso: {0}\n", this.peso);
            sb.AppendFormat("Altura: {0}\n", this.altura);
            sb.AppendFormat("Posicion: {0}\n", this.posicion);

            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float imc;

            imc = this.Peso / (float)Math.Pow(this.Altura, 2);

            if (imc >= 18.5 && imc <= 25)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
