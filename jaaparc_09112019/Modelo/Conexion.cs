using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Conexion
    {


        private NpgsqlConnection CadenaConexion = new NpgsqlConnection("server = localhost; User Id= postgres; Port = 7474; Database = jaaprac_8; Password = snayder;");

        public NpgsqlConnection AbrirConexion()
        {
            if (CadenaConexion.State == ConnectionState.Closed)
                CadenaConexion.Open();
            return CadenaConexion;
        }

        public NpgsqlConnection CerraConexion()
        {
            if (CadenaConexion.State == ConnectionState.Open)
                CadenaConexion.Close();
            return CadenaConexion;
        }

    }
}
