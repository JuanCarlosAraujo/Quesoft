using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public String Nombre { get; set; }
        public int cantidad { get; set; }
        public string categoria { set; get; }
        public Producto(string nombre)
        {
            this.Nombre = nombre;
        }

        public Producto()
        {
        }
    }
}
