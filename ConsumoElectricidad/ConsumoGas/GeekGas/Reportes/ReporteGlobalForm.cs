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
    public partial class ReporteGlobalForm : Form
    {
        int anio;

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public ReporteGlobalForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteGlobal reporte = new ReporteGlobal();
            reporte.SetParameterValue("@YEAR", this.anio);
            reporte.SetParameterValue("@ID_USUARIO", this.idUsuario);
            this.crystalReportViewer1.RefreshReport();
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
