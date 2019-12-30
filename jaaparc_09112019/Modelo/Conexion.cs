using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Conexion
    {
        //verrrr inicio
  
       
        private NpgsqlConnection cnx = new NpgsqlConnection();
        private NpgsqlCommand comando = new NpgsqlCommand();
        private  NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

      


        public NpgsqlConnection cn1 { get; set; }
        public NpgsqlCommand comando1 { get; set; }
        public NpgsqlCommand adapter1 { get; set; }


        public void AbrirConexion()
        {
            cnx.ConnectionString = "server = localhost; User Id= postgres; Port = 7474; Database = jaaparc_2312; Password = snayder;";
            cnx.Open();
            comando.Connection = cnx;
            adapter = new NpgsqlDataAdapter(comando);
        }

        public void CerrarConexion()
        {
            cnx.Close();
        }

        public void EjecutarConsulta(string consulta)
        {
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
        }

        //public string consultarFacutar()
        //{

        //}

        public DataSet EjecutarConsultaDatos(string consulta)
        {
            DataSet ds = new DataSet();
            comando.CommandText = consulta;
            adapter.Fill(ds);
            return ds;
        }

        public DataTable EjecutarColsultaConRetorno(string consulta)
        {
            DataTable table = new DataTable();
            comando.CommandText = consulta;
            adapter.Fill(table);
            return table; 

        }

    }
}
