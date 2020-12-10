using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeudorService
    {
        private readonly ConexionBD _conexion;
        private readonly DeudorRepository _repositorio;

        public DeudorService(string connectionString)
        {
            
            _repositorio = new DeudorRepository(_conexion);
        }

        public GuardarDeudorResponse Guardar(Deudor deudor)
        {
            try
            {
                _conexion.Open();
                _repositorio.Guardar(deudor);
                _conexion.Close();
                return new GuardarDeudorResponse(deudor);
            }
            catch (Exception e)
            {
                return new GuardarDeudorResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { _conexion.Close(); }
        }

        public Deudor BuscarxIdentificacion(string identificacion)
        {
            _conexion.Open();
            Deudor deudor = _repositorio.BuscarPorIdentificacion(identificacion);
            _conexion.Close();
            return deudor;
        }

        public List<Deudor> ConsultarTodos()
        {
            _conexion.Open();
            List<Deudor> deudor = _repositorio.ConsultarTodo();
            _conexion.Close();
            return deudor;
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

    public class GuardarDeudorResponse
    {
        public GuardarDeudorResponse(Deudor deudor)
        {
            Error = false;
            Deudor = deudor;
        }
        public GuardarDeudorResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Deudor Deudor { get; set; }
    }

}
