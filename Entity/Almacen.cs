using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Almacen
    {
        public List<Mercancia> productos{ get; set; }

        public Almacen(List<Mercancia> productos)
        {
            this.productos = productos;
        }

        public Almacen()
        {
        }

        public void AñadirProductos(Mercancia producto)
        {

            productos.Add(producto);
           
        }

        public String MostrarProductos()
        {
            foreach(){

            }
            return "";
        }
        
        
    }
}
