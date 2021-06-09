using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Libreria
    {

        private List<Libro> _libros;

        public List<Libro> Libros
        {
            get { return _libros; }
            set { _libros = value; }
        }


        private string _razonSocial;

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }


        public Libreria()
        {
            LibroTecnico objUMLyPatrones = new LibroTecnico("UML y Patrones de diseño", 5000, null);

            CD objCD = new CD();
            objCD.Precio = 150;

            LibroTecnico objUMLEn24Horas = new LibroTecnico("UML en 24 horas", 1200, objCD);
            
            LibroTecnico objCleanCode = new LibroTecnico("Código limpio", 7500, null);

            Novela objHarryPotter = new Novela(7500, "Fantastico", "Harry Potter y la piedra filosofal");
            Novela objAlicia = new Novela(2030, "Fantasia", "Alicia en el país de las maravillas");
            Novela objCrimenAndCastigo = new Novela(9999, "Drama", "Crimen y castigo");

            this.Libros = new List<Libro>();

            Libros.Add(objUMLyPatrones);
            Libros.Add(objUMLEn24Horas);
            Libros.Add(objCleanCode);
            Libros.Add(objHarryPotter);
            Libros.Add(objAlicia);
            Libros.Add(objCrimenAndCastigo);



        }

    }
}