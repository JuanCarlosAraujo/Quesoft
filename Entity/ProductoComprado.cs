using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class ProductoComprado : Producto
    {

        public double CostoCompra { get; set; }

        public ProductoComprado(String nombre, double precioVenta, string idProducto, double costoCompra) :
            base(nombre, precioVenta, idProducto)
        {
            this.CostoCompra = costoCompra;
        }
    }
}
