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
    class ReciboProveedorService
    {
        private readonly ConexionBD _conexion;
        private readonly ReciboProveedorRepository _repositorio;

        public ReciboProveedorService()
        {
            _conexion = new ConexionBD();
            _repositorio = new ReciboProveedorRepository(_conexion);
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

        public void Guardar(String id_proveedor,Char estado_factura)
        {
            try
            {
                _repositorio.Guardar(id_proveedor, estado_factura);
                MessageBox.Show("Recibo creado");
            }
            catch (Exception) { MessageBox.Show("Algo Fallo"); }

        }
    }
}
