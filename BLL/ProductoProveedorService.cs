using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ProductoProveedorService
    {
        private readonly ConexionBD _conexion;
        private readonly ProductoProveedoRepository _repositorio;

        public ProductoProveedorService()
        {
            _conexion = new ConexionBD();
            _repositorio = new ProductoProveedoRepository(_conexion);
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

        public void Guardar(String sk_producto, int id_proveedor)
        {
            try
            {
                _repositorio.Guardar( sk_producto,  id_proveedor);
                MessageBox.Show("Producto insertado en proveedor");
            }
            catch (Exception) { MessageBox.Show("Algo Fallo"); }

        }
    }
}
