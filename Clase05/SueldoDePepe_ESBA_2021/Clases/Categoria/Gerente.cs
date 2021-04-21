using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Gerente : Categoria
    {
        public override float Neto()
        {
            return 1000;
        }
    }
}
