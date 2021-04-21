using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorPresentismo : Bono
    {
        public float DevolverBono(int cantidadDeAusentes)
        {
            float bono = 0;

            if (cantidadDeAusentes == 0)
            {
                bono = 100;
            }
            else
            {
                if (cantidadDeAusentes == 1)
                {
                    bono = 50;
                }
                else
                {
                    bono = 0;
                }
            }

            return bono;
        
        }
    }
}
