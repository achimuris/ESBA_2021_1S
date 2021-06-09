using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class LibroTecnico : Libro
    {
        public override double Precio()
        {
            double precioFinal = this.Valor;
            if (this.CD != null)
            {
                precioFinal = precioFinal + CD.Precio;
            }

            precioFinal = precioFinal * 1.1;


            return precioFinal;
        }

        private CD _cd;

        public CD CD
        {
            get { return _cd; }
            set { _cd = value; }
        }

        public LibroTecnico(string unNombre, double valorLibro, CD unCD)
        {
            this.CD = unCD;
            this.Nombre = unNombre;
            this.Valor = valorLibro;
        }


    }
}