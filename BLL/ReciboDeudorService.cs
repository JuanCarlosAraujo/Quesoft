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
    class ReciboDeudorService
    {
        private readonly ConexionBD _conexion;
        private readonly ReciboDeudorRepository _repositorio;

        public ReciboDeudorService()
        {
            _conexion = new ConexionBD();
            _repositorio = new ReciboDeudorRepository(_conexion);
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

        public void Guardar(String cedula)
        {
            try
            {
                _repositorio.Guardar(cedula);
                MessageBox.Show("Recibo creado");
            }
            catch (Exception) { MessageBox.Show("Algo Fallo"); }

        }
    }
}
