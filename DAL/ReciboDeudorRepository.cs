using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReciboDeudorRepository
    {
        public static OracleConnection conn;
        public static ConexionBD conexion = new ConexionBD();
        public ReciboDeudorRepository(ConexionBD conexion)
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
            cmd.CommandText = "select * from recibo_deudor";
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public void Guardar(String cedula)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("pro_añadir_recibo_deudor", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cedula;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
