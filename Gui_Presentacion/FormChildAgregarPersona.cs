using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Gui_Presentacion
{
    public partial class FormChildAgregarPersona : Form
    {
        ProveedorService proveedorService;
        DeudorService deudorService;
        public FormChildAgregarPersona()
        {
            InitializeComponent();
            LblCantidad.Hide();
            LblProductos.Hide();
            CmbProductos.Hide();
            CmbUnidad.Hide();
            TxtCantidad.Hide();
            proveedorService = new ProveedorService();
            deudorService = new DeudorService();
            




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
            BtnGenerarFactura.Text = "Generar Factura";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblGuardar.Hide();
            if (CmbTipo.Text.Equals("Deudor"))
            {
             
                txtCorreo.Text = String.Empty;
                txtCorreo.Enabled = false;
                txtCorreo.BackColor = Color.Silver;
                LabelIdentificacion.Text = "Identificacion";
            }
            else
            {
      
                txtCorreo.Enabled = true;
                txtCorreo.BackColor = Color.White;
                LabelIdentificacion.Text = "Numero De Contacto";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = String.Empty;
            String apellido = String.Empty;
            String documento = String.Empty;
            String numero = String.Empty;
            String correo = String.Empty;

            nombre = TxtNombre.Text;
            apellido = TxtApellido.Text;
            documento = TxtId.Text;
            correo = txtCorreo.Text;

            bool validar = ValidacionGuardarPersona(nombre, apellido, documento, correo);

            if (CmbTipo.Text.Equals("Proveedor") && validar == true)
            {
                proveedorService.Guardar(nombre,apellido, documento, correo);
            }
            else if(CmbTipo.Text.Equals("Deudor") && validar == true)
            {
                Deudor persona = new Deudor(nombre, apellido, documento);
            }

            LblGuardar.Show();
        }

        private void AddDataGrigView(Persona persona)
        {

            int n = dtgvPersonas.Rows.Add();
            
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            LblGuardar.Hide();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            LblGuardar.Hide();
        }

        public bool ValidacionGuardarPersona(String nombre, String apellido, String documento, String correo)
        {
            if (nombre.Equals(String.Empty) || apellido.Equals(String.Empty) || documento.Equals(String.Empty) || (correo.Equals(String.Empty) &&  CmbTipo.Text == "Proveedor"))
            {
                LblGuardar.Text = "Error campos vacios";
                return false;
            }
            else if (nombre.Equals(String.Empty) || apellido.Equals(String.Empty) || documento.Equals(String.Empty))
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
