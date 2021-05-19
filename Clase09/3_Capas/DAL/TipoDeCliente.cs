using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TipoDeCliente
    {

        public DataTable GetTipos()
        {
            Conexion objConexion = new Conexion();

            return objConexion.LeerPorStoreProcedure("sp_Recuperar_Tipo");

        }

        public int CrearTipo(string laDescripcion)
        {
            Conexion objConexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = objConexion.crearParametro("@descripcion", laDescripcion);
            return objConexion.EscribirPorStoreProcedure("sp_Crear_Tipo", parametros);
            //return objConexion.EscribirPorComando("insert into tTipoDeCliente  (descripcion_tipo) values " + "('" + laDescripcion + "')");
        }
    }
}
