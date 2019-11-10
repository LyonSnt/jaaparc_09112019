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

        public void InsertarC(int idC,string nombreC)
        {
            objetoM.InsertarM(idC, nombreC);
        }
    }
}
