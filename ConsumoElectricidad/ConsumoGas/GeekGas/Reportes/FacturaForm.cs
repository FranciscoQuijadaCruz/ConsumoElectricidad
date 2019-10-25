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
    public partial class FacturaForm : Form
    {

        private string nombre ="";
        private string direccion ="";
        private string rfc = "";
        private int id = 0;
        private double costo;
        private double cantidad;
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public FacturaForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Factura reporte = new Factura();
            reporte.SetParameterValue("@COSTO", costo);
            reporte.SetParameterValue("@CANTIDAD", cantidad);
            reporte.SetParameterValue("@NOMBRE", nombre);
            reporte.SetParameterValue("@RFC", rfc);
            reporte.SetParameterValue("@FECHA", fecha);
            reporte.SetParameterValue("@ID", id);
            reporte.SetParameterValue("@DIRECCION", direccion);


            crystalReportViewer1.ReportSource = reporte;


        }
    }
}
