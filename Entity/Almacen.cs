using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Almacen
    {
        public List<Mercancia> Productos { get; set; }

        public Almacen(List<Mercancia> productos)
        {
            this.Productos = productos;
        }

        public Almacen()
        {
        }

        public String AñadirProductos(Mercancia producto)
        {
            Productos.Add(producto);
            return "se ha añadido correctamente";
        }
    }
}

