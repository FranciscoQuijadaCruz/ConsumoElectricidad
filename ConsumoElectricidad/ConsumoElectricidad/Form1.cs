using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsumoElectricidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            vtnUsuarios ventanaUsuarios = new vtnUsuarios();
            ventanaUsuarios.ShowDialog();
        }

        private void btnLecturas_Click(object sender, EventArgs e)
        {
            vtnLecturas ventanaLecturas = new vtnLecturas();
            ventanaLecturas.ShowDialog();
        }
    }
}
