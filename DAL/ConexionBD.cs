using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionBD
    {
       public static OracleConnection conn = new OracleConnection();
        public static string conexionstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        
        public OracleConnection Conectar()
        {
            conn.ConnectionString = conexionstring;
            return conn;
       }

        public void Open()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close(); 
        }
        public String State()
        {
            return conn.State.ToString();
        }

    }
}
