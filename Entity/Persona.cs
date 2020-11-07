using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    abstract class Persona 
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public List<Factura> productosFactura { get; set; }

        public Persona(string Nombre, string Apellido, List<Factura> productosFactura)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.productosFactura = productosFactura;
        }

        public Persona()
        {
        }
    }
}
