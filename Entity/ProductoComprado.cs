using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    
    class ProductoComprado : Producto
    {

       public double costoCompra { get; set; }

        public ProductoComprado(double costoCompra)
        {
            this.costoCompra = costoCompra;
        }
    }
}
