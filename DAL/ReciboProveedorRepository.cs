using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReciboProveedorRepository
    {

        public static OracleConnection conn;
        public static ConexionBD conexion = new ConexionBD();
        public ReciboProveedorRepository(ConexionBD conexion)
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
            cmd.CommandText = "select * from recibo_proveedor";
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public void Guardar(String id_proveedor,  char estado_factura)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("pro_añadir_recibo_proveedor", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
	        comando.Parameters.Add("id_proveedor", OracleDbType.Varchar2).Value = id_proveedor;
	        comando.Parameters.Add("estado_factura", OracleDbType.Char).Value = estado_factura;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }       
}