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

        public ProductoFabricado(double costoFabricacion)
        {
            this.costoFabricacion = costoFabricacion;
        }
    }
}
