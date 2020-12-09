using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProveedorRepository : IAcciones<Proveedor>
    {
        public static OracleConnection conn;
        public ProveedorRepository(ConexionBD conexion)
        {
            conn = conexion.connection;
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

        public List<Proveedor> ConsultarTodo()
        {
            OracleDataReader dataReader;
            List<Proveedor> proveedores = new List<Proveedor>();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Select * from persona ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proveedor proveedor = DataReaderMapToPerson(dataReader);
                        proveedores.Add(proveedor);
                    }
                }
            }
            return proveedores;
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
