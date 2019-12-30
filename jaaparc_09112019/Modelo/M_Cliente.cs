using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Cliente
    {
        public int idcliente { get; set; }
        public int idmedidor { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string genero { get; set; }
        public int idcomunidad { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }

        public Conexion conecc { get; set; }

        private CD_Conexion coneccm = new CD_Conexion();


        NpgsqlDataReader leer;
        NpgsqlCommand comando = new NpgsqlCommand();


        public void insertar(string cedula2, string nombres2, string apellidos2, string genero2, int idcomunidad2, string telefono2, string celular2, string email2)
        {
            comando.Connection = coneccm.AbrirConexion();
            comando.CommandText = "insert into ins_cliente (cedula,nombres,apellidos,genero,idcomunidad,telefono,celular,email) values  ('" + cedula2 + "','" + nombres2 + "','" + apellidos2 + "','" + genero2 + "'," + idcomunidad2 + ",'" + telefono2 + "','" + celular + "','" + email2 + "')";
            comando.ExecuteNonQuery();
            //comando.Connection = coneccm.CerrarConexion();
        }

        public DataSet ConsultarDatosClienteM()
        {
            string cadena = "insert into ins_cliente (cedula,nombres,apellidos,genero,idcomunidad,telefono,celular,email) values  ('" + this.cedula + "','" + this.nombres + "','" + this.apellidos + "','" + this.genero + "','" + this.idcomunidad + "','" + this.telefono + "','" + this.celular + "','" + this.email + "')";

            return conecc.EjecutarConsultaDatos(cadena);
        }

        public DataTable Mostrar()
        {
            string cadena = "select cli.idcliente,cli.cedula as Cédula,cli.nombres as Nombres,cli.apellidos,cli.genero,com.nomcomunidad,cli.telefono,cli.celular,cli.email " +
                " from ins_cliente cli, cat_comunidades com " +
                " where cli.idcomunidad= com.idcomunidad " +
                " order by cli.idcliente";
            //  string cadena = "select * from ins_medidor where numero = " + textoM + "";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }

        public void InsertarClienteM()
        {
            string cadena = "insert into ins_cliente (cedula,nombres,apellidos,genero,idcomunidad,telefono,celular,email) values  ('" + this.cedula + "','" + this.nombres + "','" + this.apellidos + "','" + this.genero + "','" + this.idcomunidad + "','" + this.telefono + "','" + this.celular + "','" + this.email + "')";
            conecc.EjecutarConsulta(cadena);
        }

        public void ModifcarClienteM()
        {
            // string cadena = "update ins_medidor set marca = '" + this.marca + "' where idmedidor = " + idmedidor + "";
            string cadena = "update ins_cliente set estado = '" + this.estado + "' where idcliente = '" + idcliente + "'";

            conecc.EjecutarConsulta(cadena);
        }

        public void ModifcarEstadoMedidor()
        {
            string cadena = "update ins_medidor set estado = '" + this.estado + "' where idmedidor = " + idmedidor + "";
            // string cadena = "update ins_medidor set marca = '" + this.marca + "' where numero = '" + numero + "'";

            conecc.EjecutarConsulta(cadena);
        }

        public void EliminarClienteM()
        {
            string cadena = "delete from ins_cliente where idcliente = '" + this.idcliente + "'";
            conecc.EjecutarConsulta(cadena);
        }

        public DataTable BuscarM(string textoM)
        {
            string cadena = "select * from ins_medidor where marca like '%" + textoM + "%' order by idmedidor";
            //  string cadena = "select * from ins_medidor where numero = " + textoM + "";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }
    }
}
