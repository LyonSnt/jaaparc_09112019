

using System;
using System.Data;

namespace Modelo
{
    public class M_Comunidad
    {

        public int idcomunidad { get; set; }
        public string nomcomunidad { get; set; }
        public string estado { get; set; }

        public Conexion conecc { get; set; }


        public DataTable ConsultarComboM()
        {
            string cadena = "select * from cat_comunidades order by idcomunidad";
            return conecc.EjecutarColsultaConRetorno(cadena);
        }


        

    }
}
