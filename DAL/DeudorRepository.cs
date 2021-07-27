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
    public class DeudorRepository
    {
        public static OracleConnection conn;
        public static ConexionBD conexion = new ConexionBD();
        public DeudorRepository(ConexionBD conexion)
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
            cmd.CommandText = "select * from deudor";
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public void Guardar(String primer_nombre, String primer_apellido, String documento)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("pro_añadir_deudor", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = documento;
            comando.Parameters.Add("primer_nombre", OracleDbType.Varchar2).Value = primer_nombre;
            comando.Parameters.Add("primer_apellido", OracleDbType.Varchar2).Value = primer_apellido;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
