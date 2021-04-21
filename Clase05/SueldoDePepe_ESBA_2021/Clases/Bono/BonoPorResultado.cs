using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public abstract class BonoPorResultado : Bono
    {
        public abstract float DevolverMonto(Categoria unaCategoria);
    }
}
