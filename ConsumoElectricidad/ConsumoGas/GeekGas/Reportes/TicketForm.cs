using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeekGas.Reportes
{
    public partial class TicketForm : Form
    {
        double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public TicketForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Ticket reporte = new Ticket();
            reporte.SetParameterValue("@COSTO", costo);
            reporte.SetParameterValue("@CANTIDAD", cantidad);
            reporte.SetParameterValue("@NOMBRE", nombre);

            crystalReportViewer1.ReportSource = reporte;

        }
    }
}
