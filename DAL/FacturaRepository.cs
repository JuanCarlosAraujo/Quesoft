using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class FacturaRepository : IAcciones<Factura>
    {
  
        public static OracleConnection conn;
        public FacturaRepository(ConexionBD conexion)
        {
            
        }
        public Factura BuscarPorIdentificacion(string identificacion)
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

        public List<Factura> ConsultarTodo()
        {
            OracleDataReader dataReader;
            List<Factura> facturas = new List<Factura>();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Select * from persona ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToPerson(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }

        public Factura DataReaderMapToPerson(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Factura factura = new Factura();
            factura.IdFactura = (int)dataReader["IdFactura"];
            factura.TipoFactura = (int)dataReader["Tipo"];
            factura.Persona = (Persona)dataReader["Persona"];
            factura.Productos = (List<DetalleFactura>)dataReader["Detalle"];
            factura.ValorTotal = (double)dataReader["ValorTotal"];
            factura.EstadoFactura = (bool)dataReader["Estado"];
            return factura;
        }

        public void Eliminar(Factura delete)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = "Delete from Facturas where Identificacion=@Identificacion";
                command.Parameters.Add("@Identificacion", delete.IdFactura);
                command.ExecuteNonQuery();
            }
        }

        public void Guardar(Factura save)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = @"Insert Into Facturas (IdFactura,TipoFactura,Persona,Productos, ValorTotal, EstadoFactura) 
                                        values (@IdFactura,@TipoFactura,@Persona,@Productos,@ValorTotal, @EstadoFactura)";
                command.Parameters.Add("@IdFactura", save.IdFactura);
                command.Parameters.Add("@TipoFactura", save.TipoFactura);
                command.Parameters.Add("@Persona", save.Persona);
                command.Parameters.Add("@Productos", save.Productos);
                command.Parameters.Add("@ValorTotal", save.ValorTotal);
                command.Parameters.Add("@EstadoFactura", save.EstadoFactura);
                var filas = command.ExecuteNonQuery();
            }
        }
    }
}
