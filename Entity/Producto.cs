using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    abstract class Producto
    {
        public String Nombre { get; set; }
        public double PrecioVenta { get; set; }
        public int IdProducto { get; set; }
        public Producto(string nombre, double precioVenta, int idProducto)
        {
            this.Nombre = nombre;
            this.PrecioVenta = precioVenta;
            this.IdProducto = idProducto;
        }

        public Producto()
        {
        }
    }
}
