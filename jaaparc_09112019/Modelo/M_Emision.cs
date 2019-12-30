using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class M_Emision
   {
        public int idfacturacion { get; set; }
        public string descripcion { get; set; }
        public string mes { get; set; }
        public int anio { get; set; }
        public double recaudacion { get; set; }


        //ESTA PARTE DE LA TABLA DETALLE DE EMISION (FCT_DETFACTURACION)
        public int iddetfacturacion { get; set; }
        public int idregistro { get; set; }
        public int idcliente { get; set; }
        public int idmedidor { get; set; }
        public int lecturaanterior { get; set; }
        public int lecturaactual { get; set; }
        public int consumom3 { get; set; }
        public decimal valortarifa { get; set; }
        public double total { get; set; }



        public Conexion conecc { get; set; }


        public void InsertarEmisionM()
        {
            string cadena = "insert into fct_cabfacturacion (descripcion,mes,anio,recaudacion) values  ('" + this.descripcion + "','" + this.mes + "','" + this.anio + "','" + this.recaudacion + "')";
            conecc.EjecutarConsulta(cadena);
        }

        public DataTable ConsultarDatosEmision2M()
        {
            // string cadena = "select b.nombres,c.numero,a.LECTURAANTERIOR, a.LECTURAACTUAL,a.CONSUMOM3,a.VALORTARIFA,a.TOTAL,a.idregistro,a.idcliente,a.idmedidor from fct_detfacturacion a, ins_cliente b, ins_medidor c, fct_cabfacturacion d where a.IDFACTURACION = '"+ this.idfacturacion +"' and a.idcliente = b.idcliente and a.idmedidor = c.idmedidor and a.idfacturacion = d.idfacturacion";

             string cadena = "select b.nombres,c.numero,a.LECTURAANTERIOR, a.LECTURAACTUAL,a.CONSUMOM3,a.VALORTARIFA,a.TOTAL,a.idregistro,a.idcliente,a.idmedidor from fct_detfacturacion a, ins_cliente b, ins_medidor c, fct_cabfacturacion d where a.IDFACTURACION = 13 and a.idcliente = b.idcliente and a.idmedidor = c.idmedidor and a.idfacturacion = d.idfacturacion";

          //  string cadena = "select * from hoy28";


            return conecc.EjecutarColsultaConRetorno(cadena);
        }

        public DataSet ConsultarDatosEmisionM(string idfactuta)
        {
             string cadena = "select a.idregistro,concat(b.apellidos,' ',b.nombres),c.numero,a.LECTURAANTERIOR, a.LECTURAACTUAL,a.CONSUMOM3,a.VALORTARIFA,a.TOTAL,a.idcliente,a.idmedidor from fct_detfacturacion a, ins_cliente b, ins_medidor c, fct_cabfacturacion d where a.IDFACTURACION =  " + idfactuta + " and a.idcliente = b.idcliente and a.idmedidor = c.idmedidor and a.idfacturacion = d.idfacturacion";


          //string cadena = "select idregistro,idcliente,idmedidor,lecturaanterior,lecturaactual,consumom3,valortarifa,total from fct_detfacturacion where idfacturacion = "+idfactuta+"";

            return conecc.EjecutarConsultaDatos(cadena);
        }

        public void InsertarDetalleEmisionM()
        {
            string cadena = "insert into fct_detfacturacion (idfacturacion,idregistro,idcliente,idmedidor,lecturaanterior,lecturaactual,consumom3,valortarifa,total) values  ('" + this.idfacturacion + "','" + this.idregistro + "','" + this.idcliente + "','" + this.idmedidor + "','" + this.lecturaanterior + "','" + this.lecturaactual + "','" + this.consumom3 + "','" + this.valortarifa + "','" + this.total + "')";

            conecc.EjecutarConsulta(cadena);
        }


    }
}
