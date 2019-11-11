using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class C_Comunidad
    {

        private M_Comunidad objetoM = new M_Comunidad();

        public DataTable MostarC()
        {
            DataTable tabla = new DataTable();
            tabla = objetoM.MostrarM();
            return tabla;
        }

        public void InsertarC(string nombreC)
        {
            objetoM.InsertarM(nombreC);
        }

        public void ActualizarC( string nombreC, string idC)
        {
            objetoM.ActualizarM(nombreC, Convert.ToInt32(idC));
        }

        public void EliminarC(string idC)
        {
            objetoM.EliminarM(Convert.ToInt32(idC));
        }
    }
}
