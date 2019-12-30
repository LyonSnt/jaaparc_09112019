using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class C_ConceptoPago
    {

        private Conexion Conexion = new Conexion();
        private M_ConceptoPago ObjetoConceptoPagoM = new M_ConceptoPago();


        public DataTable ConsultarComboxConceptoPagoC()
        {
            try
            {
                Conexion.AbrirConexion();
                ObjetoConceptoPagoM.conecc = Conexion;
                return ObjetoConceptoPagoM.ConsultarComboxConceptoPagoM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }
        }



    }
}
