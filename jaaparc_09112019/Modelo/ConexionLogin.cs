using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class ConexionLogin
    {

        private readonly string connectionString;
        public ConexionLogin()
        {
            connectionString = "server = localhost; User Id = postgres; Port = 7474; Database = loginprueba2211; Password = snayder;";
        }
        protected NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
