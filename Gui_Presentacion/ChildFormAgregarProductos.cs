using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Presentacion
{
    public partial class ChildFormAgregarProductos : Form
    {
        public static ProductosService productosService = new ProductosService();
        public static ProductoProveedorService productosProveedorService = new ProductoProveedorService();
        public ChildFormAgregarProductos()
        {
            InitializeComponent();
            DtgvAgregarProductos.DataSource = productosService.Leer();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = String.Empty;
            float costo;
            String categoria = String.Empty;
            float precioventa;
            String cantidad = String.Empty;
            int proveedor;
            String sk_producto;

            nombre = TxtNombre.Text;
            costo = (float)Convert.ToDouble(TxtCosto);
            categoria = CmbCategoria.Text;
            precioventa = (float)Convert.ToDouble(TxtPrecioVenta);
            cantidad = TxtPrecioVenta.Text;
            proveedor = Convert.ToInt32(CmbProveedor);

            productosService.Guardar(nombre, categoria, precioventa, costo);
            sk_producto = productosService.ConsultarIdProducto(nombre);
            productosProveedorService.Guardar(sk_producto, proveedor);



        }
    }
}
