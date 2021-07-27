using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mercancia
    {
        public Producto Producto { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotal { get; set; }
        public String Unidad { get; set; }

        public Mercancia(Producto producto, int cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.PrecioTotal = producto.PrecioVenta * cantidad;
        }

        public Mercancia()
        {
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
