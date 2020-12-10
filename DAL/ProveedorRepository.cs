using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ProveedorRepository 
    {
        public static OracleConnection conn;
        public static ConexionBD conexion = new ConexionBD();
        public ProveedorRepository(ConexionBD conexion)
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
            cmd.CommandText = "select * from PROVEEDOR";
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public void Guardar(String primer_nombre, String primer_apellido, String numero_proveedor, String correo_proveedor)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("pro_añadir_proveedor", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("primer_nombre", OracleDbType.Varchar2).Value = primer_nombre;
            comando.Parameters.Add("primer_apellido", OracleDbType.Varchar2).Value = primer_apellido;
            comando.Parameters.Add("numero_proveedor", OracleDbType.Varchar2).Value = numero_proveedor;
            comando.Parameters.Add("correo_proveedor", OracleDbType.Varchar2).Value = correo_proveedor;
            comando.ExecuteNonQuery();
            conexion.Close();

        }


        public Proveedor BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "select * from Proveedor where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }


        public Proveedor DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Proveedor proveedor = new Proveedor();
            proveedor.Id_proveedor = (int)dataReader["Id_proveedor"];
            proveedor.Nombre = (string)dataReader["Nombre"];
            proveedor.ProductosFactura = (List<Factura>)dataReader["ProductosFactura"];
            proveedor.ValorDeuda = (int)dataReader["ValorDeuda"];
            return proveedor;
        }

        public void Eliminar(Proveedor delete)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Delete from Proveedor where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion", delete.Id_proveedor);
                command.ExecuteNonQuery();
            }
        }

        public void Guardar(Proveedor save)
        {
            using (var command = conn.CreateCommand())
            {

                command.CommandText = @"Insert Into Proveedor (id_proveedor,Numero_proveedor,Nombre_proveedor,Correo_proveedor) 
                                        values (@id_proveedor,@Numero_proveedor,@Correo_proveedor)";
                command.Parameters.Add("@id_proveedor", save.Apellido);
                command.Parameters.Add("@Numero_proveedor", save.Nombre);
                command.Parameters.Add("@Nombre_proveedor", save.ProductosFactura);
                command.Parameters.Add("@Correo_proveedor", save.Correo);
                var filas = command.ExecuteNonQuery();
            }
        }
    }
}
