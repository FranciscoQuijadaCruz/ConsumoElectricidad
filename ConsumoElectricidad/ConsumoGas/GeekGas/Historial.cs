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
    public partial class Historial : Form
    {
        List<Consumo> consumos;
        public Historial()
        {
            InitializeComponent();
        }

        public Historial(List<Consumo> consumos)
        {
            this.consumos = consumos;
            InitializeComponent();
            Historial_Load();
        }

        private void Historial_Load()
        {
            dataGridView1.Columns["ID"].Width = 104;
            dataGridView1.Columns["FECHA"].Width = 104;
            dataGridView1.Columns["CANTIDAD"].Width = 103;
            dataGridView1.Columns["COSTO"].Width = 103;
            dataGridView1.Rows.Clear();
            cargarTodos();
        }

        private void cargarTodos()
        {
            foreach (Consumo cuenta in consumos)
            {
                dataGridView1.Rows.Add(cuenta.Id, cuenta.Fecha.ToString(),cuenta.Cantidad.ToString(), cuenta.Costototal.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
