using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsumoElectricidad
{
    class Lectura
    {

        int idLectura = 0;
        DateTime fecha = default(DateTime);
        decimal consumo = 0.0m;
        int idUsuario = 0;

        public int IdLectura
        {
            get { return idLectura; }
            set { idLectura = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public decimal Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        //Metodos
        public bool agregarLectura()
        {
            bool resultado = false;

            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("REGISTRAR_LECTURA", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@fecha", this.fecha);
                cmd.Parameters.AddWithValue("@consumo", this.consumo);
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



        public static List<Lectura> buscarLecturas()
        {
            List<Lectura> lecturas = new List<Lectura>();
            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("BUSCAR_LECTURAS", conn);
                conn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Lectura lectura = new Lectura();
                    lectura.Fecha = Convert.ToDateTime(sdr["fecha"].ToString());
                    lectura.Consumo = Convert.ToDecimal(sdr["consumo"].ToString());
                    lectura.IdUsuario = Convert.ToInt32(sdr["idUsuario"].ToString());
                    lectura.IdLectura = Convert.ToInt32(sdr["idLectura"].ToString());

                    lecturas.Add(lectura);
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return lecturas;
        }

        public bool modificarLectura()
        {
            bool resultado = false;

            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("MODIFICAR_LECTURA", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@fecha", this.fecha);
                cmd.Parameters.AddWithValue("@consumo", this.consumo);
                cmd.Parameters.AddWithValue("@idUsuario", this.idUsuario);
                cmd.Parameters.AddWithValue("@idLectura", this.idLectura);

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
