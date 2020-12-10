using BLL;
using Entity;
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
    public partial class Frm_AgentesYDeudas : Form
    {
        ProveedorService proveedorService;
        DeudorService deudorService;
        Persona persona;
        public Frm_AgentesYDeudas()
        {
            InitializeComponent();
            proveedorService = new ProveedorService();
            deudorService = new DeudorService();
            openFormChild(new FormChildAgregarPersona());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormChild(new FormChildAgregarPersona());
        }

        private void openFormChild(object formChild)
        {
            if (this.panelChildForm.Controls.Count > 0 )
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

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            openFormChild(new FrmConsultasPersona());
        }
    }

}
