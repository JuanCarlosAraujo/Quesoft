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
    public class DetalleProveedorService
    {
        private readonly ConexionBD _conexion;
        private readonly DetalleProveedorRepository _repositorio;

        public DetalleProveedorService()
        {
            _conexion = new ConexionBD();
            _repositorio = new DetalleProveedorRepository(_conexion);
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

        public void Guardar(String sk_producto, float cantidad, int id_proveedor)
        {
            try
            {
                _repositorio.Guardar(sk_producto, cantidad, id_proveedor);
                MessageBox.Show("detalle creado");
            }
            catch (Exception) { MessageBox.Show("Algo Fallo"); }

        }
    }
}
