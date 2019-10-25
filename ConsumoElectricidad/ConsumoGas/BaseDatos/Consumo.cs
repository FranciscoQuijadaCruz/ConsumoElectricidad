using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace BaseDatos
{
   public class Consumo
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double costototal;

        public double Costototal
        {
            get { return costototal; }
            set { costototal = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public bool CrearTicket(Consumo c){

            bool retorno = false;

            SqlConnection conn = new SqlConnection(
        ConfigurationManager
        .ConnectionStrings["conn"]
        .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("GENERAR_TICKET", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@FECHA", Convert.ToDateTime(c.Fecha));
                cmd.Parameters.AddWithValue("@CANTIDAD", c.Cantidad);
                cmd.Parameters.AddWithValue("@IDUSUARIO", c.idUsuario);
                cmd.Parameters.AddWithValue("@COSTO", c.Costototal);

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

        public List<Consumo> ConsumoCuenta(int id)
        {
            List<Consumo> consumos = new List<Consumo>();
            SqlConnection conn = new SqlConnection(
                ConfigurationManager
                    .ConnectionStrings["conn"]
                    .ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("OBTENER_CONSUMOS_POR_USUARIO", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Consumo consumodiario = new Consumo();
                    consumodiario.Fecha = Convert.ToDateTime(sdr["fecha"].ToString());
                    consumodiario.Cantidad = Convert.ToDouble(sdr["cantidad"].ToString());
                    consumodiario.IdUsuario = Convert.ToInt32(sdr["idUsuario"].ToString());
                    consumodiario.Id = Convert.ToInt32(sdr["id"].ToString());
                    consumodiario.Costototal = Convert.ToDouble(sdr["costototal"].ToString());

                    consumos.Add(consumodiario);
                }

            }
            catch (Exception e) { }

            finally { conn.Close(); }

            return consumos;
        }

}

}
