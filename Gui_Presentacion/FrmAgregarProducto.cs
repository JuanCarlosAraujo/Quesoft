using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Gui_Presentacion
{
    public partial class FrmAgregarProducto : Form
    {
        private BDService conexionBDService;
        public FrmAgregarProducto()
        {
            InitializeComponent();
            conexionBDService = new BDService(ExtraccionCadena.Conexion);
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexionBDService.Consultar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = TxtNombre.Text;
            producto.categoria = CmbTipo.Text;
            producto.cantidad = Convert.ToInt32(TxtCantidad.Text);
            MessageBox.Show(conexionBDService.Guardar(producto));
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexionBDService.Consultar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
