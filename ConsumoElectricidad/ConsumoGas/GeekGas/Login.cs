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
    public partial class Login : Form
    {
        
        Usuario u = new Usuario();
        public Login()
        {
            InitializeComponent();
        }



        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtCuenta.Text.Equals("") || txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (txtCuenta.Text.Equals("administrador") && txtContrasena.Text.Equals("parangaricutirimicuaro"))
                {
                    VentanaAdmin va = new VentanaAdmin();
                    va.Show();
                    this.Hide();
                }
                else
                {
                    if (u.Login(txtCuenta.Text, txtContrasena.Text).Id > 0)
                    {
                        VentanaUsuario vu = new VentanaUsuario(u.Login(txtCuenta.Text, txtContrasena.Text));
                        vu.Show();
                        this.Hide();

                    }
                    else {
                        MessageBox.Show("Cuenta o contraseña incorrecta.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }
        
    }
}
