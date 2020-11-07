using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Mercancia
    {
        public Producto producto { get; set; }
        public double cantidad { get; set; }
        public double precioTotal { get; set; }
        public String unidad { get; set; }

        public Mercancia(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            precioTotal = producto.precioVenta * cantidad;
        }

        public Mercancia()
        {
        }

        public void TransformarUnidades()
        {
            if (producto.nombre == "Queso" && unidad == "Libra")
            {
                this.cantidad = this.cantidad * 0.453592;
                this.unidad = "Kilogramos";
            }
           
        }

    }
}
