using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDatos;

namespace GeekGas
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") ||
                txtCuenta.Text.Equals("") ||
                txtPassword.Text.Equals("") ||
                txtDomicilio.Text.Equals("") ||
                txtRFC.Text.Equals(""))
            {
                MessageBox.Show("Favor de no dejar campos vacios.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                if (MessageBox.Show("¿Desea concluir el registro?", "Mensaje",
MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString().Equals("Yes"))
                {
                    Usuario u = new Usuario();
                    u.Nombre = txtNombre.Text;
                    u.Cuenta = txtCuenta.Text;
                    u.Contrasena = txtPassword.Text;
                    u.Domicilio = txtDomicilio.Text;
                    u.Rfc = txtRFC.Text;
                    u.AgregarUsuario(u);
                    limpiarCasillas();
                }
            }
        }

        public void limpiarCasillas(){

            txtNombre.Text = "";
            txtCuenta.Text = "";
            txtPassword.Text = "";
            txtDomicilio.Text = "";
            txtRFC.Text = "";
        }
    }
}
