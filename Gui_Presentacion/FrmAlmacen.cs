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
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
        {
            InitializeComponent();
        }

        private void BtnMostrarProductos_Click(object sender, EventArgs e)
        {
            openFormChild(new FrmBuscarProductos());
        }

        private void BtnAgregarProductos_Click(object sender, EventArgs e)
        {
            openFormChild(new ChildFormAgregarProductos());
        }

        private void BtnCalcularVentas_Click(object sender, EventArgs e)
        {

        }
        private void openFormChild(object formChild)
        {
            if (this.panelChildForm.Controls.Count > 0)
            {
                this.panelChildForm.Controls.RemoveAt(0);
            }

            Form child = formChild as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(child);
            this.panelChildForm.Tag = child;
            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFormChild(new FrmModificarProductos());
        }
    }
}
