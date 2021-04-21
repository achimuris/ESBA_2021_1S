using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorResultadoFijo : BonoPorResultado
    {
        public override float DevolverMonto(Categoria unaCategoria)
        {
            return 80;
        }
    }
}
