using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiPrimeraAPP_OrientadaObjetos_ESBAClase02
{
    public class Araña : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Soy una araña y estoy comiendo mi presa que se encuentra en la telaraña");
        }

        public Araña()
        {
            this.OtroMetodo();
        }


        private void Tejer()
        {
            Console.WriteLine("Arme mi trampa");
        }

    

    }
}
