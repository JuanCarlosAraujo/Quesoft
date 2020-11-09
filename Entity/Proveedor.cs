using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor : Persona
    {

        public Proveedor(String nombre, String apellido, List<Factura> productosFactura, double valorDeuda) :
            base(nombre, apellido, productosFactura, valorDeuda)
        {
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
