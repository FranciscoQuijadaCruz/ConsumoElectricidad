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
    public partial class vtnUsuarios : Form
    {

        Usuario usuario = new Usuario();

        public vtnUsuarios()
        {
            InitializeComponent();
        }

        private void vtnUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.Columns["ID"].Width = 20;
            dgvUsuarios.Columns["NOMBRE"].Width = 100;
            dgvUsuarios.Columns["APELLIDO"].Width = 100;
            dgvUsuarios.Columns["CORREO"].Width = 120;
            dgvUsuarios.Columns["DIRECCION"].Width = 180;


            dgvUsuarios.Rows.Clear();

            // dgvLibros.DataSource = Libro.buscarLibros();     (Se usa cuando no modificamos las columnas)

            foreach (Usuario usuario in Usuario.buscarUsuarios())
            {
                dgvUsuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Direccion);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Direccion = txtDireccion.Text;

            cargarTodos();
            if (usuario.IdUsuario > 0) //Guardar modificado
            {
                usuario.modificarUsuario();
                cargarTodos();
            }
            else //Guardar Nuevo
            {
                usuario.agregarUsuario();
                cargarTodos();
            }
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cargarTodos()
        {
            dgvUsuarios.Rows.Clear();

            // dgvLibros.DataSource = Libro.buscarLibros();     (Se usa cuando no modificamos las columnas)

            foreach (Usuario usuario in Usuario.buscarUsuarios())
            {
                dgvUsuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Direccion);
            }
        }

        //Para ver el Reporte 
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString());

                int mes = 10;
                int anio = 2018;

                ReportViewer rv = new ReportViewer();
                rv.IdUsuario = idUsuario;
                rv.Mes = mes;
                rv.Anio = anio;

                rv.ShowDialog(this);

                

            }
        }
    }
}
