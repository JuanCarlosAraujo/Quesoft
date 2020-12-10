using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ProductosService
    {
        private readonly ConexionBD _conexion;
        private readonly ProductoRepository _repositorio;
        public ProductosService(string connectionString)
        {
            
             _conexion = new ConexionBD();
             _repositorio = new ProductoRepository(_conexion);
          
        }
        public Producto BuscarxIdentificacion(string identificacion)
        {
            _conexion.Open();
            Producto producto = _repositorio.BuscarPorIdentificacion(identificacion);
            _conexion.Close();
            return producto;
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                _conexion.Open();
                var persona = _repositorio.BuscarPorIdentificacion(identificacion);
                if (persona != null)
                {
                    _repositorio.Eliminar(persona);
                    _conexion.Close();
                    return ($"El registro {persona.Nombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { _conexion.Close(); }

        }


    }
}
