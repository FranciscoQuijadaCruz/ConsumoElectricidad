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
    public partial class ReportViewer : Form
    {

        int mes;

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
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


        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            //Creamos el reporte
            ConsumoMensualUsuario reporte = new ConsumoMensualUsuario();
            //Le damos valores al reporte
            reporte.SetParameterValue("@MONTH",this.mes);
            reporte.SetParameterValue("@YEAR", this.anio);
            reporte.SetParameterValue("@ID_USUARIO", this.idUsuario);

            //Le mandamos el reporte al Crystal Reports Viewer
            crvFactura.ReportSource = reporte;
        }
    }
}
