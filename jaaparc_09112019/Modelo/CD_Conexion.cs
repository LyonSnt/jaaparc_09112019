using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CD_Conexion
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
    }
}
