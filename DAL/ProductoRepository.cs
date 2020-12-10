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
    public class ProductoRepository : IAcciones<Producto>
    {
        public static OracleConnection conn;
        public ProductoRepository(ConexionBD conexion)
        {
            
        }
        public Producto BuscarPorIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "select * from Producto where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion",OracleDbType.Varchar2).Value = identificacion;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Producto producto = DataReaderMapToPerson(dataReader);
                return producto;
            }
        }
        public List<Producto> ConsultarTodo()
        {
            OracleDataReader dataReader;
            List<Producto> productos = new List<Producto>();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Select * from persona ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToPerson(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;

        }
        public Producto DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.IdProducto = (string)dataReader["Id_Producto"];
            producto.Nombre = (string)dataReader["Nombre"];
            producto.PrecioVenta = (int)dataReader["PrecioVenta"];
            return producto;
        }

        public void Eliminar(Producto delete)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Delete from Productos where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion", delete.IdProducto);
                command.ExecuteNonQuery();
            }
        }


        public void Guardar(Producto save)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = @"Insert Into Productos (sk_Producto,Nombre,Valor_Venta) 
                                        values (@sk_Producto,@Nombre,@Valor_Venta)";
                command.Parameters.Add("@sk_Producto", save.IdProducto);
                command.Parameters.Add("@Nombre", save.Nombre);
                command.Parameters.Add("@Valor_Venta", save.PrecioVenta);
                var filas = command.ExecuteNonQuery();
            }
        }

    }
}
