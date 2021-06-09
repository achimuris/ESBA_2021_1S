using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class DetalleFactura
    {
        private int _cantidad  ;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private Libro _libro;

        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }


        public double SubTotal()
        {
            return this.Cantidad * Libro.Precio();
        }

        public override string ToString()
        {
            return this.Libro + " (cant: " + this.Cantidad + ")" ;
        }

    }
}