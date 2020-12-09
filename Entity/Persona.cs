using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public List<Factura> ProductosFactura { get; set; }
        public double ValorDeuda { get; set; }

        public Persona(string Nombre, string Apellido, List<Factura> productosFactura, double valorDeuda)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.ProductosFactura = productosFactura;
            this.ValorDeuda = valorDeuda;
        }

        public Persona(String nombre, String apellido)
        {
        }

        public Persona()
        {
        }

        public void AgregarProductos(Factura factura)
        {
            ValorDeuda = factura.ValorTotal + ValorDeuda;
            this.ProductosFactura.Add(factura);
        }

        public void AbonaFactura(int idFactura, double abono)
        {
            foreach (Factura item in ProductosFactura)
            {
                if (idFactura == item.IdFactura)
                {
                    item.PagoDefacturaRealizado(abono);
                    this.ValorDeuda = this.ValorDeuda - abono;
                }
            }
        }
    }
}
