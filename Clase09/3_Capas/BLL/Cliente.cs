using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Cliente
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        private int _codigoDeCliente;
        public int Codigo
        {
            get { return _codigoDeCliente; }
            set { _codigoDeCliente = value; }
        }

        private TipoDeCliente _tipoDeCliente;
        public TipoDeCliente TipoDeCliente
        {
            get { return _tipoDeCliente; }
            set { _tipoDeCliente = value; }
        }

        public int CrearCliente()
        {
            DAL.Cliente objClienteDAL = new DAL.Cliente();

            this.Codigo = objClienteDAL.CrearCliente(this.Apellido, this.Nombre, this.TipoDeCliente.Codigo);

            return this.Codigo;

        }

    }
}
