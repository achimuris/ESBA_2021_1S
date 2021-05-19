using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Cliente
    {
        public int CrearCliente(string apellido, string nombre, int tipo_cliente)
        {
            string nombre_sp = "sp_crear_cliente";
            SqlParameter[] parametros = new SqlParameter[4];
            Conexion objConexion = new Conexion();
            int id_cliente = 0;

            parametros[0] = objConexion.crearParametro("@nombre_cliente", nombre);
            parametros[1] = objConexion.crearParametro("@apellido_cliente", apellido);
            parametros[2] = objConexion.crearParametro("@id_tipo_cliente", tipo_cliente);
            parametros[3] = objConexion.crearParametro("@id_cliente", id_cliente);
            parametros[3].Direction = System.Data.ParameterDirection.Output;

            bool seCreoElCliente = (objConexion.EscribirPorStoreProcedure(nombre_sp, parametros) > 0);

            if (seCreoElCliente)
            {
                id_cliente = (int)parametros[3].Value;
            }
            else
            {
                id_cliente = -1;
            }

            return id_cliente;

        }
    }
}
