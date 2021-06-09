using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Cliente : Persona
    {
        private int _dni;

        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

    }
}