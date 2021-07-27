using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DeudorService
    {
        private readonly ConexionBD _conexion;
        private readonly DeudorRepository _repositorio;

        public DeudorService()
        {
            _conexion = new ConexionBD();
            _repositorio = new DeudorRepository(_conexion);
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

        public void Guardar(String primer_nombre, String primer_apellido, String documento)
        {
            try
            {
                _repositorio.Guardar(primer_nombre, primer_apellido, documento);
                MessageBox.Show("Persona Insertada");
            }
            catch (Exception) { MessageBox.Show("Algo Fallo"); }

        }
    }

}
