using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Novela : Libro
    {
        public override double Precio()
        {
            return this.Valor;
        }

        private string _genero;

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public Novela(double unPrecio, string unGenero, string unNombre)
        {
            this.Valor = unPrecio;
            this.Genero = unGenero;
            this.Nombre = unNombre;
        }
    }
}