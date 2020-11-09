using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public Producto Producto { set; get; }
        public double ValorTotal { set; get; }
        public double Cantidad { set; get; }
        public String Unidad { set; get; }

        public DetalleFactura(Producto producto, double cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.ValorTotal = this.Producto.PrecioVenta * cantidad;
        }

        public void TransformarUnidades(Producto producto, String unidad)
        {
            if (Producto.Nombre == "Queso" && Unidad == "Libra")
            {
                this.Cantidad = this.Cantidad * 0.453592;
                this.Unidad = "Kilogramos";
            }
        }
    }
}
