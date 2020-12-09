using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProveedorService
    {
        private readonly ConexionBD _conexion;
        private readonly ProveedorRepository _repositorio;

        public ProveedorService(string connectionString)
        {
            _conexion = new ConexionBD(connectionString);
            _repositorio = new ProveedorRepository(_conexion);
        }

        public GuardarProveedorResponse Guardar(Proveedor proveedor)
        {
            try
            {
                _conexion.Open();
                _repositorio.Guardar(proveedor);
                _conexion.Close();
                return new GuardarProveedorResponse(proveedor);
            }
            catch (Exception e)
            {
                return new GuardarProveedorResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { _conexion.Close(); }
        }

        public Proveedor BuscarxIdentificacion(string identificacion)
        {
            _conexion.Open();
            Proveedor proveedor = _repositorio.BuscarPorIdentificacion(identificacion);
            _conexion.Close();
            return proveedor;
        }

        public List<Proveedor> ConsultarTodos()
        {
            _conexion.Open();
            List<Proveedor> proveedor = _repositorio.ConsultarTodo();
            _conexion.Close();
            return proveedor;
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

    public class GuardarProveedorResponse
    {
        public GuardarProveedorResponse(Proveedor proveedor)
        {
            Error = false;
            Proveedor = proveedor;
        }
        public GuardarProveedorResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Proveedor Proveedor { get; set; }
    }



}
