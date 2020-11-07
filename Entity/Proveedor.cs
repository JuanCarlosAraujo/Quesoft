using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Proveedor : Persona
    {
        public double valorDeuda { get; set; }

        public Proveedor(String nombre, String apellido, List<Factura> productosFactura, double valorDeuda) :
            base(nombre, apellido, productosFactura)
        {
            this.valorDeuda = valorDeuda;
        }

        public Proveedor()
        {
        }
    }
}
