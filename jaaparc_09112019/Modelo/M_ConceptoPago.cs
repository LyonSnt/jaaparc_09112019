using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_ConceptoPago
    {
        public int idpago { get; set; }
        public string descpago { get; set; }
        public double valor { get; set; }
        public double porcentaje { get; set; }


        public Conexion conecc { get; set; }


        public DataTable ConsultarComboxConceptoPagoM()
        {
            string cadena = "select * from ins_conspago where idpago = 1";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }
    }
}
