using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorResultadoVariable : BonoPorResultado
    {
        public override float DevolverMonto(Categoria unaCategoria)
        {
            return (float) (unaCategoria.Neto() * 0.1);
        }
    }
}
