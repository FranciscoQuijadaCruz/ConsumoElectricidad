using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsumoElectricidad
{
    class Usuario
    {

        int idUsuario = 0;
        string nombre = "";
        string apellido = "";
        string correo = "";
        string direccion = "";


        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        //Metodos

        public bool agregarUsuario()
        {
            bool resultado = false;

            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("AGREGAR_USUARIO", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@nombre", this.nombre);
                cmd.Parameters.AddWithValue("@apellido", this.apellido);
                cmd.Parameters.AddWithValue("@correo", this.correo);
                cmd.Parameters.AddWithValue("@direccion", this.direccion);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                int res = cmd.ExecuteNonQuery();

                if (res == 1)
                {
                    resultado = true;
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return resultado;
        }



        public static List<Usuario> buscarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("BUSCAR_USUARIOS", conn);
                conn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre = sdr["nombre"].ToString();
                    usuario.Apellido = sdr["apellido"].ToString();
                    usuario.Correo = sdr["correo"].ToString();
                    usuario.Direccion = sdr["direccion"].ToString();
                    usuario.IdUsuario = Convert.ToInt32(sdr["idUsuario"].ToString());

                    usuarios.Add(usuario);
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return usuarios;
        }

        public bool modificarUsuario()
        {
            bool resultado = false;

            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("MODIFICAR_USUARIO", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@nombre", this.nombre);
                cmd.Parameters.AddWithValue("@apellido", this.apellido);
                cmd.Parameters.AddWithValue("@correo", this.correo);
                cmd.Parameters.AddWithValue("@direccion", this.direccion);
                cmd.Parameters.AddWithValue("@idUsuario", this.idUsuario);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                int res = cmd.ExecuteNonQuery();

                if (res == 1)
                {
                    resultado = true;
                }
            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return resultado;
        }


    }
}
