using Common.Cache;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UserDao : ConexionLogin
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from log_login where nomusuario = '" + user+"' and password = '"+pass+"'";
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            UserLoginCache.IdUsuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                           
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
