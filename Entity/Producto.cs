using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    abstract class Producto
    {
        public String nombre { get; set; }
        public double precioVenta { get; set; }
        public int idProducto { get; set; }
        public Producto(string nombre, double precioVenta, int idProducto)
        {
            this.nombre = nombre;
            this.precioVenta = precioVenta;
            this.idProducto = idProducto;
        }

        public Producto()
        {
        }
    }
}
