using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Persona Persona { set; get; }
        public double ValorTotal { set; get; }
        public List<DetalleFactura> Productos { set; get; }
        public int IdFactura { set; get; }
        public int TipoFactura { set; get; }
        public bool EstadoFactura { set; get; }
        public DateTime Fecha { set; get; }
        public double AbonoRealizado { set; get; }

        public Factura(Persona persona, List<DetalleFactura> productos, int tipoFactura, bool estadoFactura)
        {
            this.Persona = persona;
            this.Productos = productos;
            this.TipoFactura = tipoFactura;
            this.EstadoFactura = estadoFactura;
            this.Fecha = DateTime.Now;
            CostoTotal();
        }

        public Factura()
        {

        }

        public void RealizarDetalleFactura(Producto producto, double cantidad, string unidad)
        {
            DetalleFactura detallefactura = new DetalleFactura(producto, cantidad);
            this.Productos.Add(detallefactura);
        }

        public void CostoTotal()
        {
            foreach (DetalleFactura producto in this.Productos)
            {
                this.ValorTotal = this.ValorTotal + producto.ValorTotal;
            }
        }

        public void RealizarCompra(Persona persona, int tipoFactura, bool estadoFactura)
        {
            this.Persona = persona;
            this.TipoFactura = tipoFactura;

            CostoTotal();
            this.Fecha = DateTime.Now;
            this.EstadoFactura = false;
        }

        public void PagoDefacturaRealizado(double abonoRealizado)
        {
            this.AbonoRealizado = this.AbonoRealizado + abonoRealizado;
            if (this.AbonoRealizado == ValorTotal)
            {
                this.EstadoFactura = true;
            }
        }
    }
}
