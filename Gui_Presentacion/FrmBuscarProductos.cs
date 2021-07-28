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
    public partial class FrmBuscarProductos : Form
    {
        ProductosService productos;
        public FrmBuscarProductos()
        {
            InitializeComponent();
            productos = new ProductosService();
            DgvConsultarProducto.DataSource = productos.Leer();
        }
    }
}
