using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiPrimeraAPP_OrientadaObjetos_ESBAClase02
{
    public abstract class Animal
    {
        private int patas;

        public void Caminar()
        {
            
        }

        public abstract void Comer();

        protected void OtroMetodo()
        {

        }

        private void UnMetodoPrivado()
        {
            Console.WriteLine("Soy privado");
        }

    }
}
