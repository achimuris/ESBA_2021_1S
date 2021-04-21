using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Empleado
    {
        private Categoria categoria;

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private int faltas;

        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }

        private int legajo;

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private BonoPorPresentismo bonoporPresentismo;

        public BonoPorPresentismo BonoPorPresentismo
        {
            get { return bonoporPresentismo; }
            set { bonoporPresentismo = value; }
        }

        private BonoPorResultado bonoPorResultado;

        public BonoPorResultado BonoPorResultado
        {
            get { return bonoPorResultado; }
            set { bonoPorResultado = value; }
        }

    }
}
