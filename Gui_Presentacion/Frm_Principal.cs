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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            FrmAlmacen almacen = new FrmAlmacen();
            almacen.Show();
        }

        private void pictureBoxAgentes_Click(object sender, EventArgs e)
        {
            Frm_AgentesYDeudas agentesYDeudas = new Frm_AgentesYDeudas();
            agentesYDeudas.Show();
        }

        private void pictureBoxProductos_Click(object sender, EventArgs e)
        {
            Frm_Productos productos = new Frm_Productos();
            productos.Show();
        }

        private void pictureBoxFinanzas_Click(object sender, EventArgs e)
        {
            Frm_Finanzas finanzas = new Frm_Finanzas();
            finanzas.Show();
        }
    }
}
