using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Deudor : Persona
    {
        public double valorDeuda{ get; set; }
        public String documento { get; set; }

        public Deudor(double valorDeuda, string documento)
        {
            this.valorDeuda = valorDeuda;
            this.documento = documento;
        }
    }
}
