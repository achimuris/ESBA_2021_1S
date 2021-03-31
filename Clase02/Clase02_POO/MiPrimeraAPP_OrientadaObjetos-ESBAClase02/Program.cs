using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiPrimeraAPP_OrientadaObjetos_ESBAClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos que la variable "araña" es del tipo Araña
            Araña araña;

            //Utilizamos el constructor "por defecto", y nos devuelve una araña para que lo podamos utilizar
            araña = new Araña();


            //Declaro y le asocio la posición de memoria para tener un objeto del tipo "Pez"
            Pez nemo = new Pez();

            araña.Comer();
            nemo.Comer();

            
            
            Console.ReadKey();
        }
    }

}
