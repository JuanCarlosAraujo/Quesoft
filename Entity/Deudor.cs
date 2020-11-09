using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Deudor : Persona
    {
        public String Documento { get; set; }

        public Deudor(String nombre, String apellido, List<Factura> productosFactura, double valorDeuda, string documento) :
            base(nombre, apellido, productosFactura, valorDeuda)
        {
            this.Documento = documento;
        }

        public Deudor(String nombre, String apellido, String documento) :
            base(nombre, apellido)
        {
            this.Documento = documento;
        }

        public Deudor()
        {

        }
    }
}
