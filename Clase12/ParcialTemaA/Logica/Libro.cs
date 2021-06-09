using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Libro
    {
        private string _isbn;

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private Autor _autor;

        public Autor Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }


        private double _valorLibro;

        public double Valor
        {
            get { return _valorLibro; }
            set { _valorLibro = value; }
        }

        public abstract double Precio();
        public override string ToString()
        {
            return this.Nombre + " - " + " $ " + this.Precio().ToString();
        }
    }
}
