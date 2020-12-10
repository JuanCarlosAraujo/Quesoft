using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ProveedorService
    {
        private readonly ConexionBD _conexion;
        private readonly ProveedorRepository _repositorio;

        public ProveedorService()
        {
            _conexion = new ConexionBD();
            _repositorio = new ProveedorRepository(_conexion);
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
