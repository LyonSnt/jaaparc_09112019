using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class C_Emision
    {
        private Conexion conexion = new Conexion();
        private M_Emision m_Emision = new M_Emision();
        private M_Conexion m_Conexion = new M_Conexion();


        public C_Emision()
        {

        }

        public C_Emision(string descripcion, string mes, string anio, string recaudacion)
        {
            m_Emision.descripcion = descripcion;
            m_Emision.mes = mes;
            m_Emision.anio = Convert.ToInt32(anio);
            m_Emision.recaudacion = Convert.ToDouble(recaudacion);
        }

        public C_Emision(string idfacturacion, string idregistro, string idcliente, string idmedidor, string lecturaanterior, string lecturaactual, string consumom3, string valortarifa, string total)
        {
            m_Emision.idfacturacion = Convert.ToInt32(idfacturacion);
            m_Emision.idregistro = Convert.ToInt32(idregistro);
            m_Emision.idcliente = Convert.ToInt32(idcliente);
            m_Emision.idmedidor = Convert.ToInt32(idmedidor);
            m_Emision.lecturaanterior = Convert.ToInt32(lecturaanterior);
            m_Emision.lecturaactual = Convert.ToInt32(lecturaactual);
            m_Emision.consumom3 = Convert.ToInt32(consumom3);
            m_Emision.valortarifa =Convert.ToDecimal(valortarifa);
            m_Emision.total = Convert.ToDouble(total);


        }


        public C_Emision(string idfactutacion)
        {
            m_Emision.idfacturacion = Convert.ToInt32(idfactutacion);
        }

        public void InsertarEmisionC()
        {
            try
            {
                conexion.AbrirConexion();
                m_Emision.conecc = conexion;
                m_Emision.InsertarEmisionM();
            }
            catch (Exception e)
            {
                throw e;
                // MessageBox.Show("parte del controller no se que pasa");

            }
            finally { conexion.CerrarConexion(); }

        }

        public void InsertarDetalleEmisionC()
        {
            try
            {
                conexion.AbrirConexion();
                m_Emision.conecc = conexion;
                m_Emision.InsertarDetalleEmisionM();
            }
            catch (Exception e)
            {
                throw e;
                // MessageBox.Show("parte del controller no se que pasa");

            }
            finally { conexion.CerrarConexion(); }

        }

        public string UltimoRegistroEmisionC()
        {
            return m_Conexion.UltimoRegistroEmisionM();
        }



        public DataTable ConsultarDatosEmision2C()
        {
            try
            {
                conexion.AbrirConexion();
                m_Emision.conecc = conexion;
                DataTable tabla = new DataTable();
                tabla = m_Emision.ConsultarDatosEmision2M();
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public DataSet ConsultarDatosEmisionC(string idfactuta)
        {
            try
            {
                conexion.AbrirConexion();
                m_Emision.conecc = conexion;
                return m_Emision.ConsultarDatosEmisionM(idfactuta);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }
    }
}
