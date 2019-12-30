using Npgsql;
using System;
using System.Data;

namespace Modelo
{
    public class M_Medidor
    {


        public int idmedidor { get; set; }
        public string numero { get; set; }
        public int lecturaactual { get; set; }
        public string marca { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }

        public Conexion conecc { get; set; }


        //public DataTable ConsultarComboxMedidorM()
        //{
        //    string cadena = "select * from ins_medidor where estado = 'DS' order by idmedidor";
        //    return conecc.EjecutarColsultaConRetorno(cadena);
        //}

      

       // transaction = conecc.BeginTransaction("SampleTransaction");

        public DataTable ConsultarComboxMedidorM()
        {
            string cadena = "select * from ins_medidor where estado = 'DS' order by idmedidor";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }

        public DataSet ConsultarDatosM()
        {
            string cadena = "select * from ins_medidor order by idmedidor";
            return conecc.EjecutarConsultaDatos(cadena); 
        }

        public void InsertarM()
        {
            string cadena = "insert into ins_medidor (numero,lecturaactual,marca,fecregistro) values  ('" + this.numero+ "','" + this.lecturaactual + "','" + this.marca + "','" + this.fecha + "')";
            conecc.EjecutarConsulta(cadena);
        }

        public void ModifcarM()
        {
            string cadena = "update ins_medidor set marca = '" + this.marca + "' where idmedidor = " + idmedidor +"";
           // string cadena = "update ins_medidor set marca = '" + this.marca + "' where numero = '" + numero + "'";

            conecc.EjecutarConsulta(cadena);
        }

        public void ModifcarEstado()
        {
            string cadena = "update ins_medidor set estado = '" + this.estado + "' where idmedidor = " + idmedidor + "";
            // string cadena = "update ins_medidor set marca = '" + this.marca + "' where numero = '" + numero + "'";

            conecc.EjecutarConsulta(cadena);
        }

        public void EliminarM()
        {
            string cadena = "delete from ins_medidor where numero = '" + this.numero + "'";
            conecc.EjecutarConsulta(cadena);
        }

        public DataTable BuscarM(string textoM)
        {
            string cadena = "select * from ins_medidor where marca like '%"+textoM+"%' order by idmedidor";
          //  string cadena = "select * from ins_medidor where numero = " + textoM + "";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }


        public DataTable ComboM()
        {
            string cadena = "select * from ins_medidor order by idmedidor";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }

    }
}
