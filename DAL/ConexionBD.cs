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
        internal OracleConnection connection;
        public static string conexionstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public ConexionBD(string conexionString)
        {
            connection = new OracleConnection(conexionString);
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }


    }
}
