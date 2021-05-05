using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class TipoDeCliente
    {

        public DataTable GetTipos()
        {
            Conexion objConexion = new Conexion();

            return objConexion.LeerPorComando("select * from tTipoDeCliente");

        }

        public int CrearTipo(string laDescripcion)
        {
            Conexion objConexion = new Conexion();

            return objConexion.EscribirPorComando("insert into tTipoDeCliente  (descripcion_tipo) values " + "('" + laDescripcion + "')");
        }
    }
}
