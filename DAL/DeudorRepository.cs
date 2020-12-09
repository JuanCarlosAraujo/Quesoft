using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeudorRepository : IAcciones<Deudor>
    {
        public static OracleConnection conn;
        public DeudorRepository(ConexionBD conexion)
        {
            conn = conexion.connection;
        }

        public Deudor BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "select * from Deudores where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }
        public List<Deudor> ConsultarTodo()
        {
            OracleDataReader dataReader;
            List<Deudor> deudores = new List<Deudor>();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Select * from persona ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Deudor deudor = DataReaderMapToPerson(dataReader);
                        deudores.Add(deudor);
                    }
                }
            }
            return deudores;
        }

        public Deudor DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Deudor deudor = new Deudor();
            deudor.Documento= (string)dataReader["Identificacion"];
            deudor.Nombre = (string)dataReader["Nombre"];
            deudor.ProductosFactura = (List<Factura>)dataReader["ProductosFactura"];
            deudor.ValorDeuda = (int)dataReader["ValorDeuda"];
            return deudor;
        }

        public void Eliminar(Deudor delete)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Delete from Deudores where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion", delete.Documento);
                command.ExecuteNonQuery();
            }
        }

        public void Guardar(Deudor save)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = @"Insert Into Proveedor (Identificacion,Nombre,Apellido,Productos_factura) 
                                        values (@identificacion,@Nombre,@Apellido,@Productos_factura)";
                command.Parameters.Add("@identificacion", save.Documento);
                command.Parameters.Add("@Nombre", save.Nombre);
                command.Parameters.Add("@Apellido", save.Apellido);
                command.Parameters.Add("@Productos_factura", save.ProductosFactura);
                var filas = command.ExecuteNonQuery();
            }
        }
    }
}
