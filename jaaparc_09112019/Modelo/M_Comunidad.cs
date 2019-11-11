using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Comunidad
    {

        private Conexion conectarC = new Conexion();

        NpgsqlDataReader leer;
        DataTable tabla = new DataTable();
        NpgsqlCommand comando = new NpgsqlCommand();

        public NpgsqlConnection cn;
        private NpgsqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public NpgsqlDataAdapter da;

        public DataTable MostrarM()
        {
            comando.Connection = conectarC.AbrirConexion();
            comando.CommandText = "select * from comunidad";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conectarC.CerraConexion();
            return tabla;
        }

        public void InsertarM(string nombre)
        {
            comando.Connection = conectarC.AbrirConexion();
            comando.CommandText = "insert into comunidad (com_nombre) values ('"+nombre+"')";
            comando.ExecuteNonQuery();
        }

        public void ActualizarM(string nombre, int id)
        {
            comando.Connection = conectarC.AbrirConexion();
          //  comando.CommandText = "update  comunidad set com_id = " + id + ", com_nombre = '" + nombre + "' where com_id = '" + id + "'";
            comando.CommandText = "update  comunidad set com_nombre = '" + nombre + "' where com_id = '" + id + "'";

            comando.ExecuteNonQuery();
        }


        public void EliminarM(int idM)
        {
            comando.Connection = conectarC.AbrirConexion();
            comando.CommandText = "delete from comunidad where com_id = (" + idM + ")";
            comando.ExecuteNonQuery();
        }

    }
}
