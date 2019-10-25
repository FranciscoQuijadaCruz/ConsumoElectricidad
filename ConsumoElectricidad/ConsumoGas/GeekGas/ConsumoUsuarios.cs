using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDatos;
using GeekGas.Reportes;

namespace GeekGas
{
    public partial class ConsumoUsuarios : Form
    {
        List<Consumo> consumos;
        List<Consumo> facturar = new List<Consumo>();
        public ConsumoUsuarios()
        {
            InitializeComponent();
        }

        public ConsumoUsuarios(List<Consumo> consumos)
        {
            this.consumos = consumos;
            InitializeComponent();
            ElegirConsumo_Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ElegirConsumo_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["ID"].Width = 104;
            dataGridView1.Columns["FECHA"].Width = 104;
            dataGridView1.Columns["CANTIDAD"].Width = 103;
            dataGridView1.Columns["TOTAL"].Width = 103;
            dataGridView1.Rows.Clear();
            cargarTodos();
        }

        private void cargarTodos()
        {
            foreach (Consumo cuenta in consumos)
            {
                dataGridView1.Rows.Add(cuenta.Id, cuenta.Fecha.ToString(), cuenta.Cantidad.ToString(), cuenta.Costototal.ToString());
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ElegirConsumo_Load()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {

            }
            else
            {
                if (!dataGridView1.CurrentRow.Selected)
                {

                }
                else { 
                Consumo consumo = new Consumo();
                consumo.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                consumo.Fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                consumo.Cantidad = Convert.ToDouble(dataGridView1.CurrentRow.Cells["CANTIDAD"].Value.ToString());
                consumo.Costototal = Convert.ToDouble(dataGridView1.CurrentRow.Cells["TOTAL"].Value.ToString());
                consumo.IdUsuario = consumos[0].IdUsuario;
                dataGridView1.CurrentRow.Visible = false;
                dataGridView2.Rows.Add(consumo.Id, consumo.Fecha, consumo.Cantidad, consumo.Costototal);
                facturar.Add(consumo);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacturaForm t = new FacturaForm();
           // t.Costo = costo;
            //t.Cantidad = cantidad;
            //t.Nombre = u.Nombre;
            //t.Fecha =
            //t.Id =
            //t.Rfc = u.Rfc;

            t.ShowDialog();
        }


    }
}
