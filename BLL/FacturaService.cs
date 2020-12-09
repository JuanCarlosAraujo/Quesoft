using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class FacturaService
    {
        private readonly ConexionBD _conexion;
        private readonly FacturaRepository _repositorio;

        public FacturaService(string connectionString)
        {
            _conexion = new ConexionBD(connectionString);
            _repositorio = new FacturaRepository(_conexion);
        }

        public GuardarFacturaResponse Guardar(Factura factura)
        {
            try
            {
                _conexion.Open();
                _repositorio.Guardar(factura);
                _conexion.Close();
                return new GuardarFacturaResponse(factura);
            }
            catch (Exception e)
            {
                return new GuardarFacturaResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { _conexion.Close(); }
        }

        public Factura BuscarxIdentificacion(string identificacion)
        {
            _conexion.Open();
            Factura factura = _repositorio.BuscarPorIdentificacion(identificacion);
            _conexion.Close();
            return factura;
        }

        public List<Factura> ConsultarTodos()
        {
            _conexion.Open();
            List<Factura> factura = _repositorio.ConsultarTodo();
            _conexion.Close();
            return factura;
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                _conexion.Open();
                var factura = _repositorio.BuscarPorIdentificacion(identificacion);
                if (factura != null)
                {
                    _repositorio.Eliminar(factura);
                    _conexion.Close();
                    return ($"El registro {factura.IdFactura} se ha eliminado satisfactoriamente.");
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

    public class GuardarFacturaResponse
    {
        public GuardarFacturaResponse(Factura factura)
        {
            Error = false;
            Factura = factura;
        }
        public GuardarFacturaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Factura Factura { get; set; }
    }

}
