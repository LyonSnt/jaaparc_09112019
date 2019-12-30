using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Conexion
    {

        private NpgsqlConnection Conexion = new NpgsqlConnection("server = localhost; User Id= postgres; Port = 7474; Database = jaaparc_2312; Password = snayder;");



        public NpgsqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }



        public NpgsqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
        

        public string consul()
        {
            Conexion.Open();
            string query = "select count(*) f from ins_cliente";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Conexion);
            NpgsqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                return rd["f"].ToString();
            }
            Conexion.Close();
            return "Null";
           
        }


        public string UltimoRegistroClienteM()
        {
            Conexion.Open();
            string query = "SELECT (idcliente) ultimoregistro from ins_cliente ORDER BY idcliente DESC LIMIT 1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Conexion);
            NpgsqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                return rd["ultimoregistro"].ToString();
            }
            Conexion.Close();
            return "Null";

        }

        public string UltimoRegistroEmisionM()
        {
            Conexion.Open();
            string query = "SELECT (idfacturacion) ultimoregistro from fct_cabfacturacion ORDER BY idfacturacion DESC LIMIT 1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Conexion);
            NpgsqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                return rd["ultimoregistro"].ToString();
            }
            Conexion.Close();
            return "Null";

        }

        public string PasarTextbox(int textoM, string no)
        {
            Conexion.Open();
            string query = "SELECT SUM(valorpagado) FROM ins_detregistro WHERE idregistro = " + textoM + "";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Conexion);
            NpgsqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read() == true)
            {
                no = rd["valorpagado"].ToString();
            }
            Conexion.Close();
            return "Null";

        }

        public void grafico(string[] series, int[]puntos)
        {
            ArrayList Cliente = new ArrayList();
           
            Conexion.Open();
            string query = "select count(*) f from ins_cliente";
            NpgsqlCommand cmd = new NpgsqlCommand(query, Conexion);
            NpgsqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                Cliente.Add(rd.GetString(0));
                Cliente.Add(rd.GetString(1));
            }

            //Series series =
           Conexion.Close();
        }
    }
}
