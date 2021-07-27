using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoFabricado : Producto
    {
        public double CostoFabricacion { get; set; }

        public ProductoFabricado(String nombre, double precioVenta, string idProducto, double costoFabricacion) :
            base(nombre, precioVenta, idProducto)
        {
            this.CostoFabricacion = costoFabricacion;
        }
    }
}
