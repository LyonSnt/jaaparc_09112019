using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Comunidad
    {

        private Conexion conectarC = new Conexion();

        NpgsqlDataReader leer;
        DataTable tabla = new DataTable();
        NpgsqlCommand comando = new NpgsqlCommand();

        public NpgsqlConnection cn;
        private NpgsqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public NpgsqlDataAdapter da;

        public DataTable Mostrar()
        {
            comando.Connection = conectarC.AbrirConexion();
            comando.CommandText = "select * from comunidad";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conectarC.CerraConexion();
            return tabla;
        }

    }
}
