using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Gui_Presentacion
{
    public partial class Frm_MainMenu : Form
    {
        public static ProveedorService proveedorService = new ProveedorService();
        public Frm_MainMenu()
        {
            InitializeComponent();
            BtnMainMenu.Hide();
            proveedorService.Connection();


        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
        public void EsconderMenus()
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            labelAgentes.Hide();
            labelAlmacen.Hide();
            labelFinanzas.Hide();
            labelGestion.Hide();
            welcome.Hide();
            labelWelcome2.Hide();
            pictureAlmacen.Hide();
            pictureBox3.Hide();
            pictureBoxAgentes.Hide();
            pictureBoxFinanzas.Hide();
            pictureBoxLogo.Hide();
            pictureBoxProductos.Hide();

        }
        public void MostrarMenu()
        {
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            labelAgentes.Show();
            labelAlmacen.Show();
            labelFinanzas.Show();
            labelGestion.Show();
            welcome.Show();
            labelWelcome2.Show();
            pictureAlmacen.Show();
            pictureBox3.Show();
            pictureBoxAgentes.Show();
            pictureBoxFinanzas.Show();
            pictureBoxLogo.Show();
            pictureBoxProductos.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EsconderMenus();
            BtnMainMenu.Show();
            openFormChild(new FrmAlmacen());
            
        }

        private void pictureBoxAgentes_Click(object sender, EventArgs e)
        {
            EsconderMenus();
            BtnMainMenu.Show();
            openFormChild(new Frm_AgentesYDeudas());
            

        }

        private void pictureBoxProductos_Click(object sender, EventArgs e)
        {
            EsconderMenus();
            BtnMainMenu.Show();
            openFormChild(new Frm_Productos());
            
        }

        private void pictureBoxFinanzas_Click(object sender, EventArgs e)
        {
            EsconderMenus();
            BtnMainMenu.Show();
            openFormChild(new Frm_Finanzas());
            
        }
        private void openFormChild(object formChild)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }

            Form child = formChild as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(child);
            this.panelMain.Tag = child;
            child.Show();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.RemoveAt(0);
            BtnMainMenu.Hide();
            MostrarMenu();
        }
    }
    public static class ConfigConnection
    {
        public static string connectionString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }

    public static class PanelMenu
    {
        public static Panel panel = new Panel();
    } 
}
