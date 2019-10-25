using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeekGas.Reportes;

namespace GeekGas
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.ShowDialog();
        }

        private void btnGenerarFacturas_Click(object sender, EventArgs e)
        {
            BuscarUsuarios bu = new BuscarUsuarios();
            bu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void btnReporteTotalAnual_Click(object sender, EventArgs e)
        {
            ReporteGlobalForm rgf = new ReporteGlobalForm();
            rgf.Show();
            this.Hide();
        }
    }
}
