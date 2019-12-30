using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class C_Dashboard
    {

        //private Conexion conexion = new Conexion();
        // private M_Dashboard objetoDashboardM = new M_Dashboard();

        private M_Conexion objetoc = new M_Conexion();


        public C_Dashboard()
        {

        }



        public string contador()
        {
            return objetoc.consul();
        }
    }


}
