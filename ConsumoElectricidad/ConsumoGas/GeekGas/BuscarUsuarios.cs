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
    public partial class BuscarUsuarios : Form
    {

        Usuario c = new Usuario();

        public BuscarUsuarios()
        {
            InitializeComponent();
            BusquedaUsuarios_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consumo consumo = new Consumo();
            ConsumoUsuarios ec = new ConsumoUsuarios(consumo.ConsumoCuenta(c.Id));
            ec.ShowDialog();
        }

        private void BusquedaUsuarios_Load()
        {
            dataGridView1.Columns["ID"].Width = 103;
            dataGridView1.Columns["NOMBRE"].Width = 104;
            dataGridView1.Columns["CUENTA"].Width = 104;
            dataGridView1.Columns["RFC"].Width = 103;
            dataGridView1.Rows.Clear();
            cargarTodos();
        }

        private void cargarTodos()
        {
            foreach (Usuario cuenta in c.ObtenerUsuario())
            {
                dataGridView1.Rows.Add(cuenta.Id,  cuenta.Nombre, cuenta.Cuenta, cuenta.Rfc);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                c.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals(""))
            {
                dataGridView1.Columns["ID"].Width = 103;
                dataGridView1.Columns["NOMBRE"].Width = 104;
                dataGridView1.Columns["CUENTA"].Width = 104;
                dataGridView1.Columns["RFC"].Width = 103;
                dataGridView1.Rows.Clear();


                foreach (Usuario cuenta in c.BuscarUsuarioPorNombre(txtNombre.Text))
                {
                    dataGridView1.Rows.Add(cuenta.Id, cuenta.Nombre, cuenta.Cuenta, cuenta.Rfc);
                }
            }
            else
            {
                BusquedaUsuarios_Load();
            }
        }



    
    }
}
