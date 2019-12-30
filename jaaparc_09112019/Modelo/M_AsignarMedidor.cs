using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_AsignarMedidor
    {

        public int idregistro { get; set; }
        public int idcliente { get; set; }
        public int idmedidor { get; set; }
        public int idpago { get; set; }
        public double cosregistro { get; set; }
        public int numcuota { get; set; }
        public DateTime fechainicio { get; set; }
        public string fechfin { get; set; }
        public double valorpagado { get; set; }
        public double intereses { get; set; }
        public string estado { get; set; }

        public Conexion conecc { get; set; }

        public DataSet ConsultarDatosClienteM()
        {
            string cadena = "select * from ins_cliente";
            return conecc.EjecutarConsultaDatos(cadena);
        }

        public DataSet ConsultarDatosInscripcionM()
        {
            string cadena = "SELECT a.idregistro, concat(b.apellidos,' ',b.nombres), c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado, a.idcliente, a.idmedidor, a.idpago FROM ins_cabregistro a, ins_cliente b, ins_medidor c, ins_conspago d WHERE a.idcliente = b.idcliente AND a.idmedidor = c.idmedidor AND a.idpago = d.idpago ORDER BY a.idregistro";

            return conecc.EjecutarConsultaDatos(cadena);
        }

        public DataTable Mostrar()
        {
            string cadena = "SELECT a.idregistro, concat(b.apellidos,' ',b.nombres) as nombres, c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado FROM ins_cabregistro a, ins_cliente b, ins_medidor c, ins_conspago d WHERE a.idcliente = b.idcliente AND a.idmedidor = c.idmedidor AND a.idpago = d.idpago ORDER BY a.idregistro";
           
            //  string cadena = "select * from ins_medidor where numero = " + textoM + "";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }

        public void InsertarAsignarClienteM()
        {
            string cadena = "insert into ins_cabregistro (idcliente,idmedidor,idpago,cosregistro,numcuota,fechainicio,fechafinal,valorpagado) values  ('" + this.idcliente + "','" + this.idmedidor + "','" + this.idpago + "','" + this.cosregistro + "','" + this.numcuota + "','" + this.fechainicio + "','" + this.fechfin + "','" + this.valorpagado + "')";
            conecc.EjecutarConsulta(cadena);
        }

        public void InsertarDetalleClienteM()
        {
            string cadena = "insert into ins_detregistro (idregistro,idcliente,idmedidor,idpago,valorpagado) values  ('" + this.idregistro + "','" + this.idcliente + "','" + this.idmedidor + "','" + this.idpago + "','" + this.valorpagado + "')";
            conecc.EjecutarConsulta(cadena);
        }

        public void ModifcarClienteM()
        {
            // string cadena = "update ins_medidor set marca = '" + this.marca + "' where idmedidor = " + idmedidor + "";
            string cadena = "update ins_cliente set estado = '" + this.estado + "' where idcliente = '" + idregistro + "'";

            conecc.EjecutarConsulta(cadena);
        }

        public void ModificarValorPagadoM()
        {
            string cadena = "update ins_cabregistro set valorpagado = '" + this.valorpagado + "' where idregistro = " + idregistro + "";
            // string cadena = "update ins_medidor set marca = '" + this.marca + "' where numero = '" + numero + "'";

            conecc.EjecutarConsulta(cadena);
        }

        public void EliminarClienteM()
        {
            string cadena = "delete from ins_cliente where idcliente = '" + this.idregistro + "'";
            conecc.EjecutarConsulta(cadena);
        }

        public DataTable BuscarClientesInscripcionM(string textoM)
        {

            string cadena = "SELECT a.idregistro, concat(b.apellidos,' ',b.nombres), c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado, a.idcliente, a.idmedidor, a.idpago FROM ins_cabregistro a INNER JOIN ins_cliente b ON a.idcliente = b.idcliente INNER JOIN ins_medidor c ON a.idmedidor = c.idmedidor INNER JOIN ins_conspago d ON a.idpago = d.idpago where apellidos ilike '%" + textoM + "%' order by a.idregistro";
            //string cadena = "select * from ins_medidor where marca like '%" + textoM + "%' order by idmedidor";
            
           // string cadena = "SELECT a.idregistro, concat(b.nombres,' ',b.apellidos) as nombres, c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado FROM ins_cabregistro a, ins_cliente b, ins_medidor c, ins_conspago d WHERE a.idcliente = b.idcliente AND a.idmedidor = c.idmedidor AND a.idpago = d.idpago ORDER BY a.idregistro";

            //string cadena = "select * from ins_cabregistro where idregistro = " + textoM + "";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }

        public DataTable BuscarClientesInscripcionBuscarM(string textoM)
        {

            string cadena = "SELECT a.idregistro, concat(b.apellidos,' ',b.nombres), c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado, a.idcliente, a.idmedidor, a.idpago FROM ins_cabregistro a INNER JOIN ins_cliente b ON a.idcliente = b.idcliente INNER JOIN ins_medidor c ON a.idmedidor = c.idmedidor INNER JOIN ins_conspago d ON a.idpago = d.idpago where a.idregistro = " + textoM + " order by a.idregistro";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }

        public DataTable BuscarValorPagadoM(int textoM)
        {

           // string cadena = "SELECT a.idregistro, concat(b.nombres, ' ', b.apellidos) as nombres, c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado, a.idcliente, a.idmedidor, a.idpago FROM ins_cabregistro a INNER JOIN ins_cliente b ON a.idcliente = b.idcliente INNER JOIN ins_medidor c ON a.idmedidor = c.idmedidor INNER JOIN ins_conspago d ON a.idpago = d.idpago where nombres ilike '%" + textoM + "%' order by a.idregistro";
            //string cadena = "select * from ins_medidor where marca like '%" + textoM + "%' order by idmedidor";

            // string cadena = "SELECT a.idregistro, concat(b.nombres,' ',b.apellidos) as nombres, c.numero, d.descpago, a.cosregistro, a.fechainicio, a.fechafinal, a.valorpagado, a.intereses, a.numcuota, a.estado FROM ins_cabregistro a, ins_cliente b, ins_medidor c, ins_conspago d WHERE a.idcliente = b.idcliente AND a.idmedidor = c.idmedidor AND a.idpago = d.idpago ORDER BY a.idregistro";

           string cadena = "SELECT SUM(valorpagado) FROM ins_detregistro WHERE idregistro = " + textoM + "";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }
    }
}
