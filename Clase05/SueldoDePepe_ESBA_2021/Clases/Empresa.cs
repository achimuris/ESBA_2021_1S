using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Empresa
    {
        private string cuil;

        public string CUIL
        {
            get { return cuil; }
            set { cuil = value; }
        }


        private string razonSocial;

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        /// <summary>
        /// Implementar los objetos necesarios para calcular el sueldo de 
        /// pepe. El sueldo de pepe se calcula así: 
        /// sueldo = neto + bono x presentismo + bono x resultados.
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns>sueldo</returns>
        public float CalcularSueldo(Empleado empleado)
        {
            float sueldoFinal = 0;

            float neto = empleado.Categoria.Neto();
            float bono_por_resultado = 0;
            float bono_Por_presentismo = 0;

            if (empleado.BonoPorResultado != null)
            {
                bono_por_resultado = empleado.BonoPorResultado.DevolverMonto(empleado.Categoria);
            }

            if (empleado.BonoPorPresentismo != null)
            {
                bono_Por_presentismo = empleado.BonoPorPresentismo.DevolverBono(empleado.Faltas);
            }


            sueldoFinal = neto + bono_por_resultado + bono_Por_presentismo;

            return sueldoFinal;
        }

    }
}
