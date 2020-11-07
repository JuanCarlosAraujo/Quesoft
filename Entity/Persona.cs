using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    abstract class Persona 
    {
        public String primerNombre { get; set; }
        public String segundoNombre { get; set; }
        public String primerApellido { get; set; }
        public String segundoApellido { get; set; }
        public List<Factura> productosFactura { get; set; }

        public Persona(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, List<Factura> productosFactura)
        {
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.productosFactura = productosFactura;
        }

        public Persona()
        {
        }
    }
}
