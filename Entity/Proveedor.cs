using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor : Persona
    {
        public String Correo { get; set; }
        public int Id_proveedor { get; set; }
        public Proveedor(String nombre, String apellido, List<Factura> productosFactura, double valorDeuda, String correo, int id_proveedor) :
            base(nombre, apellido, productosFactura, valorDeuda)
        {
            this.Correo = correo;
            this.Id_proveedor = id_proveedor;
        }

        public Proveedor(String nombre, String apellido) :
            base(nombre, apellido)
        {
            

        }

        public Proveedor()
        {
        }
    }
}
