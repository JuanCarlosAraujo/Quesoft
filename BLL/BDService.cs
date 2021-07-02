using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class BDService
    {
        private ConexionBD conexionBD;
        private ConexionManager conexionManager;

        public BDService(string cadena)
        {
            conexionManager = new ConexionManager(cadena);
            conexionBD = new ConexionBD(conexionManager);
        }

        public List<Producto> Consultar()
        {
            try
            {
                conexionManager.Open();
                return conexionBD.Consultar();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conexionManager.Close();
            }
        }

        public string Guardar(Producto producto)
        {
            try
            {
                conexionManager.Open();
                conexionBD.Guardar(producto);
                return "se guardo correctamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
            finally
            {
                conexionManager.Close();
            }
        }
    }
}
