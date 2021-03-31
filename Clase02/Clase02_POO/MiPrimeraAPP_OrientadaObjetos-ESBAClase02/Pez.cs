using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiPrimeraAPP_OrientadaObjetos_ESBAClase02
{
    public class Pez  : Animal
    {

        public override void Comer()
        {
            Console.WriteLine("Soy un pez, estoy en la pecera y mi dueño me dio alimento");
        }


        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Pez()
        {
            this._nombre = "Nemo";
        }
    }
}
