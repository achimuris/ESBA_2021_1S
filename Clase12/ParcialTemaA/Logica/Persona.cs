using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public abstract class Persona
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
    }
}