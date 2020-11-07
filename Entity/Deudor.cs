using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Deudor : Persona
    {
        public double valorDeuda{ get; set; }
        public String documento { get; set; }

        public Deudor(String nombre, String apellido,  List<Factura> productosFactura, double valorDeuda, string documento) : 
            base(nombre, apellido, productosFactura)
        {
            this.valorDeuda = valorDeuda;
            this.documento = documento;
        }
    }
}
