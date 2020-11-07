using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class ProductoFabricado : Producto
    {
        public double costoFabricacion { get; set; }

        public ProductoFabricado(String nombre, double precioVenta, int idProducto, double costoFabricacion) :
            base (nombre, precioVenta, idProducto)
        {
            this.costoFabricacion = costoFabricacion;
        }
    }
}
