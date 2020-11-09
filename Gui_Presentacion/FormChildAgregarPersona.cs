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
    public partial class FormChildAgregarPersona : Form
    {
        public FormChildAgregarPersona()
        {
            InitializeComponent();
            LblCantidad.Hide();
            LblProductos.Hide();
            CmbProductos.Hide();
            CmbUnidad.Hide();
            TxtCantidad.Hide();
            BtnAgregar.Hide();
            

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {
            BtnGuardar.Hide();
            LblCantidad.Show();
            LblProductos.Show();
            CmbProductos.Show();
            CmbUnidad.Show();
            TxtCantidad.Show();
            BtnAgregar.Show();
            BtnGenerarFactura.Text = "Generar Factura";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblGuardar.Hide();
            if (CmbTipo.Text.Equals("Deudor"))
            {
                TxtId.Enabled = true;
                TxtId.BackColor = Color.White;
            }
            else
            {
                TxtId.Text = String.Empty;
                TxtId.Enabled = false;
                TxtId.BackColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = String.Empty;
            String apellido = String.Empty;
            String documento = String.Empty;

            nombre = TxtNombre.Text;
            apellido = TxtApellido.Text;
            documento = TxtId.Text;

            bool validar = ValidacionGuardarPersona(nombre, apellido, documento);

            if (CmbTipo.Text.Equals("Proveedor") && validar == true)
            {
                Proveedor persona = new Proveedor(nombre, apellido);
            }
            else if(CmbTipo.Text.Equals("Deudor") && validar == true)
            {
                Deudor persona = new Deudor(nombre, apellido, documento);
            }

            LblGuardar.Show();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            LblGuardar.Hide();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            LblGuardar.Hide();
        }

        public bool ValidacionGuardarPersona(String nombre, String apellido, String documento)
        {
            if (nombre.Equals(String.Empty) || apellido.Equals(String.Empty) || CmbTipo.Text.Equals(String.Empty))
            {
                LblGuardar.Text = "Error campos vacios";
                return false;
            }
            else if (nombre.Equals(String.Empty) || apellido.Equals(String.Empty) || (documento.Equals(String.Empty)) && CmbTipo.Text == "Deudor")
            {
                LblGuardar.Text = "Error campos vacios";
                return false;
            }
            else
            {
                LblGuardar.Text = "Guardado";
                return true;
            }
        }
    }
}
