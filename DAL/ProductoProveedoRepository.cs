using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoProveedoRepository
    {
        public static OracleConnection conn;
        public static ConexionBD conexion = new ConexionBD();
        public ProductoProveedoRepository(ConexionBD conexion)
        {
            conn = conexion.Conectar();
        }

        public OracleConnection Conexion()
        {
            conn = conexion.Conectar();
            return conn;
        }

        public DataTable Leer()
        {
            DataTable dt = new DataTable();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from producto_proveedor";
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public void Guardar(String sk_producto, int id_proveedor)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("pro_añadir_producto_proveedor", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("sk_producto", OracleDbType.Varchar2).Value = sk_producto;
            comando.Parameters.Add("id_proveedor", OracleDbType.Int32).Value = id_proveedor;
            comando.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
