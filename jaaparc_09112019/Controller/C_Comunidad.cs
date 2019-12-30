using Modelo;
using System;
using System.Data;

namespace Controller
{
    public class C_Comunidad
    {

        private Conexion conexion = new Conexion();
        private M_Comunidad objetoM = new M_Comunidad();


        public DataTable ConsultarComboC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoM.conecc = conexion;
                return objetoM.ConsultarComboM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

    }
}
