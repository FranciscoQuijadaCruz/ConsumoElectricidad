using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace BaseDatos
{
    public class Usuario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string cuenta;

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        private string rfc;

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public Usuario Login(string user, string pass)
        {
            Usuario usuario = new Usuario();
            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("SESION_USER", conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@CUENTA", user);
                cmd.Parameters.AddWithValue("@CONTRASENA", pass);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    usuario.Cuenta = sdr["cuenta"].ToString();
                    usuario.Nombre = sdr["nombre"].ToString();
                    usuario.Contrasena = sdr["contrasena"].ToString();
                    usuario.Rfc = sdr["rfc"].ToString();
                    usuario.Domicilio = sdr["domicilio"].ToString();
                    usuario.Id = Convert.ToInt32(sdr["id"].ToString());
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return usuario;
        }
    
        public bool AgregarUsuario(Usuario u){

            bool retorno = false;

            SqlConnection conn = new SqlConnection(
    ConfigurationManager
        .ConnectionStrings["conn"]
        .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("NUEVO_USUARIO", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@NOMBRE", u.Nombre);
                cmd.Parameters.AddWithValue("@CUENTA", u.Cuenta);
                cmd.Parameters.AddWithValue("@CONTRA", u.Contrasena);
                cmd.Parameters.AddWithValue("@RFC", u.Rfc);
                cmd.Parameters.AddWithValue("@DOMICILIO", u.Domicilio);
                

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                int res = cmd.ExecuteNonQuery();

                if (res == 1)
                {
                    retorno = true;
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return retorno;
        }

        public Usuario BuscarPorId(int id) {

            Usuario u = new Usuario();

            SqlConnection conn = new SqlConnection(
    ConfigurationManager
        .ConnectionStrings["conn"]
        .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("BUSCAR_USUARIO_ID", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    u.Cuenta = sdr["cuenta"].ToString();
                    u.Nombre = sdr["nombre"].ToString();
                    u.Contrasena = sdr["contrasena"].ToString();
                    u.Rfc = sdr["rfc"].ToString();
                    u.Domicilio = sdr["domicilio"].ToString();
                    u.Id = Convert.ToInt32(sdr["id"].ToString());
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return u;
        }

        public List<Usuario> BuscarUsuarioPorNombre(string nombre) {

            List<Usuario> cuentas = new List<Usuario>();

            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("BUSCAR_USUARIO_NOMBRE", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Usuario cuenta = new Usuario();
                    cuenta.Cuenta = sdr["cuenta"].ToString();
                    cuenta.Nombre = sdr["nombre"].ToString();
                    cuenta.Contrasena = sdr["contrasena"].ToString();
                    cuenta.Rfc = sdr["rfc"].ToString();
                    cuenta.Domicilio = sdr["domicilio"].ToString();
                    cuenta.Id = Convert.ToInt32(sdr["id"].ToString());
                    cuentas.Add(cuenta);
                }
            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return cuentas;


        }

        public List<Usuario> ObtenerUsuario()
        {
            List<Usuario> cuentas = new List<Usuario>();

            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECCIONAR_USUARIO", conn);
                conn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Usuario cuenta = new Usuario();
                    cuenta.Cuenta = sdr["cuenta"].ToString();
                    cuenta.Nombre = sdr["nombre"].ToString();
                    cuenta.Contrasena = sdr["contrasena"].ToString();
                    cuenta.Rfc = sdr["rfc"].ToString();
                    cuenta.Domicilio = sdr["domicilio"].ToString();
                    cuenta.Id = Convert.ToInt32(sdr["id"].ToString());
                    cuentas.Add(cuenta);
                }
            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return cuentas;
        }


    }
}
