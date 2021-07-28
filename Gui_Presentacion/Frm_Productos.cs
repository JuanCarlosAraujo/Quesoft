using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gui_Presentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void ValidarNombresYApellidos()
        {
            if (ValidarCampos(TxtNombre.Text) == true || ValidarCampos(TxtApellido.Text) == true)
            {
                errorProvider1.SetError(BtnGuardar, "Error, Verifique que: no existan numeros en nombres y apellidos");
            }
            else errorProvider1.Clear();
        }

        private bool ValidarCampos(string campos)
        {
            bool validarLetras = false;

            for (int i = 33; i <= 255; i++)
            {
                validarLetras = campos.Contains(Convert.ToString(Convert.ToChar(i)));
                if (validarLetras == true)
                {
                    break;
                }
                if (i == 64)
                {
                    i = 90;
                }
                if (i == 96)
                {
                    i = 122;
                }
            }
            return validarLetras;
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarTelefono()
        {
            bool validarNumeros = false;

            for (int i = 32; i <= 255; i++)
            {
                validarNumeros = TxtId.Text.Contains(Convert.ToString(Convert.ToChar(i)));
                if (validarNumeros == true)
                {
                    break;
                }
                if (i == 47)
                {
                    i = 57;
                }

            }
            if (validarNumeros == true)
            {
                errorProvider1.SetError(BtnGuardar, "Error, Verifique que: no existan Letras en Numero de telefono");
            }
            else errorProvider1.Clear();
            return validarNumeros;
        }

        private Boolean ValidarEscrituraCorreo()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtCorreo.Text, expresion))
            {
                if (Regex.Replace(txtCorreo.Text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ValidarCorreo()
        {
            if (ValidarEscrituraCorreo() == false)
            {
               errorProvider1.SetError(BtnGuardar, "Error, Verifique que: El correo este bien escrito");
            }
            else errorProvider1.Clear();
        }
    }
}
