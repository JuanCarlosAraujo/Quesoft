using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoRepository
    {
        public static OracleConnection conn;
        public static ConexionBD conexion = new ConexionBD();
        public ProductoRepository(ConexionBD conexion)
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
            cmd.CommandText = "select * from producto";
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public String ConsultarUltimoIdProducto(string nombre_producto)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select sk_producto from producto when nombre_producto=:nombre_producto";
            cmd.Parameters.Add("nombre_producto", OracleDbType.Varchar2).Value = nombre_producto;
            cmd.ExecuteNonQuery();
            return Convert.ToString(cmd);
        }

        public void Guardar(String nombre_producto, String categoria, float valor_venta, float costo)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("pro_añadir_producto", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("nombre_producto", OracleDbType.Varchar2).Value = nombre_producto;
            comando.Parameters.Add("categoria", OracleDbType.Varchar2).Value = categoria;
            comando.Parameters.Add("valor_venta", OracleDbType.BinaryFloat).Value = valor_venta;
            comando.Parameters.Add("costo", OracleDbType.BinaryFloat).Value = costo;
            comando.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
