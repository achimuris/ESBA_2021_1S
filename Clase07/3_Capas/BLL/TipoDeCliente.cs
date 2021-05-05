using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TipoDeCliente
    {
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        public DataTable DevolverTipos()
        {
            DAL.TipoDeCliente objDAL = new DAL.TipoDeCliente();

            return objDAL.GetTipos();
        }

        public int CrearTipo()
        {

            DAL.TipoDeCliente objDAL = new DAL.TipoDeCliente();

            return objDAL.CrearTipo(this.Descripcion);
        }

    }
}
