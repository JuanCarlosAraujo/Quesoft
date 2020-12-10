using BLL;
using Entity;
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

namespace Gui_Presentacion
{
    public partial class FrmConsultasPersona : Form
    {
        ProveedorService proveedorService;
        DeudorService deudorService;
        Persona persona;
        public FrmConsultasPersona()
        {
            InitializeComponent();
            
            proveedorService = new ProveedorService();
            deudorService = new DeudorService(ConfigConnection.connectionString);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            proveedorService.Connection();
            DgvConsultarPersona.DataSource = proveedorService.Leer();
        }
       //public static string conexionstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
