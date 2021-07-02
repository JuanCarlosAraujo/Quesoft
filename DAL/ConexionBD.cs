using System.Collections.Generic;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class ConexionBD
    {
        public ConexionManager conexionManager;
        public SqlConnection sqlConnection;

        public ConexionBD(ConexionManager conexionManager)
        {
            sqlConnection = conexionManager.Conexion;
        }

        public void Guardar(Producto producto)
        {
            using (var comando = sqlConnection.CreateCommand())
            {
                comando.CommandText = "insert into productos (nombreProducto,categoria,cantidad) values(@nombre,@categoria,@cantidad)";
                comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@categoria", producto.categoria);
                comando.Parameters.AddWithValue("@cantidad", producto.cantidad);

                comando.ExecuteNonQuery();
            }
        }

        public List<Producto> Consultar()
        {
            List<Producto> productos = new List<Producto>();
            using (var comando = sqlConnection.CreateCommand())
            {
                comando.CommandText = "SELECT nombreProducto,categoria,cantidad FROM productos";
                var lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Producto producto = new Producto();
                        producto.Nombre = lector.GetString(0);
                        producto.categoria = lector.GetString(1);
                        producto.cantidad = lector.GetInt32(2);

                        productos.Add(producto);
                    }
                }
                lector.Close();
            }
            return productos;
        }
    }
}
