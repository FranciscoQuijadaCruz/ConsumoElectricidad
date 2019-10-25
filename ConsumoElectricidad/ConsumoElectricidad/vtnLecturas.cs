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
    public partial class vtnLecturas : Form
    {

        Lectura lectura = new Lectura();
        
        public vtnLecturas()
        {
            InitializeComponent();
        }

        private void vtnLecturas_Load(object sender, EventArgs e)
        {
            dgvLecturas.Columns["ID"].Width = 40;
            dgvLecturas.Columns["FECHA"].Width = 200;
            dgvLecturas.Columns["CONSUMO"].Width = 100;
            dgvLecturas.Columns["IDUSUARIO"].Width = 100;


            dgvLecturas.Rows.Clear();

            // dgvLibros.DataSource = Libro.buscarLibros();     (Se usa cuando no modificamos las columnas)

            foreach (Lectura lectura in Lectura.buscarLecturas())
            {
                dgvLecturas.Rows.Add(lectura.IdLectura, lectura.Fecha, lectura.Consumo, lectura.IdUsuario);
            }
        }
    }
}
