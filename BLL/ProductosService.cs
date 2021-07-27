using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;

namespace BLL
{
    public class ProductosService
    {
        private readonly ConexionBD _conexion;
        private readonly ProductoRepository _repositorio;

        public ProductosService()
        {
            _conexion = new ConexionBD();
            _repositorio = new ProductoRepository(_conexion);
        }

        public void Connection()
        {
            try
            {
                _conexion.Open();
                MessageBox.Show(_conexion.State());
                _conexion.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public DataTable Leer()
        {
            try
            {
                _repositorio.Leer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return _repositorio.Leer();
        }
        public String ConsultarIdProducto(String fk)
        {


            try
            {
                _conexion.Open();
                _repositorio.ConsultarUltimoIdProducto(fk);
                _conexion.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return _repositorio.ConsultarUltimoIdProducto(fk);
            
        }

        public void Guardar(String nombre_producto, String categoria, float valor_venta, float costo)
        {
            try
            {
                _repositorio.Guardar(nombre_producto, categoria, valor_venta, costo);
                MessageBox.Show("Persona Insertada");
            }
            catch (Exception) { MessageBox.Show("Algo Fallo"); }

        }


    }
}
