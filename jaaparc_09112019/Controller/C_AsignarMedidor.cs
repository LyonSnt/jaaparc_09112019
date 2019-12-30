using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class C_AsignarMedidor
    {
        private Conexion conexion = new Conexion();
        private M_AsignarMedidor objetoAsignarClienteM = new M_AsignarMedidor();

        private M_Conexion comen = new M_Conexion();


        public C_AsignarMedidor()
        {

        }

        public C_AsignarMedidor(string idcliente, string idmedidor, string idpago, string cosregistro, string numcuota, DateTime fechainicio, string fechafin, string valorpagado)
        {
            objetoAsignarClienteM.idcliente = Convert.ToInt32(idcliente);
            objetoAsignarClienteM.idmedidor = Convert.ToInt32(idmedidor);
            objetoAsignarClienteM.idpago = Convert.ToInt32(idpago);
            objetoAsignarClienteM.cosregistro = Convert.ToDouble(cosregistro);
            objetoAsignarClienteM.numcuota = Convert.ToInt32(numcuota);
            objetoAsignarClienteM.fechainicio = fechainicio;
            objetoAsignarClienteM.fechfin = fechafin;
            objetoAsignarClienteM.valorpagado = Convert.ToDouble(valorpagado);
            
        }

        public C_AsignarMedidor(string idregistro,string idcliente, string idmedidor, string idpago, string valorpagado)
        {
            objetoAsignarClienteM.idregistro = Convert.ToInt32(idregistro);
            objetoAsignarClienteM.idcliente = Convert.ToInt32(idcliente);
            objetoAsignarClienteM.idmedidor = Convert.ToInt32(idmedidor);
            objetoAsignarClienteM.idpago = Convert.ToInt32(idpago);
            objetoAsignarClienteM.valorpagado = Convert.ToDouble(valorpagado);

        }

        public C_AsignarMedidor(string valorpagado, string idregistro)
        {
            objetoAsignarClienteM.valorpagado = Convert.ToDouble(valorpagado);
            objetoAsignarClienteM.idregistro = Convert.ToInt32(idregistro);
        }


        public string meme(int m, string v)
        {
           return comen.PasarTextbox(m,v);

           // return objetoc.consul();
        }

        public void ModificarValorPagadoC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                objetoAsignarClienteM.ModificarValorPagadoM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }

        }

        public DataTable ConsultarDatosCliente()
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                DataTable tabla = new DataTable();
                tabla = objetoAsignarClienteM.Mostrar();
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public DataTable BuscarClientesInscripcionC(string textoC)
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                return objetoAsignarClienteM.BuscarClientesInscripcionM(textoC);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public DataTable BuscarClientesInscripcionBuscarC(string textoC)
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                return objetoAsignarClienteM.BuscarClientesInscripcionBuscarM(textoC);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public DataTable BuscarValorPagadoC(int textoC)
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                return objetoAsignarClienteM.BuscarValorPagadoM(textoC);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public DataSet ConsultarDatosInscripcionC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                return objetoAsignarClienteM.ConsultarDatosInscripcionM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public void InsertarAsignarClienteC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                objetoAsignarClienteM.InsertarAsignarClienteM();
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { conexion.CerrarConexion(); }

        }


        public void InsertarDetalleClienteC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoAsignarClienteM.conecc = conexion;
                objetoAsignarClienteM.InsertarDetalleClienteM();
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { conexion.CerrarConexion(); }

        }



        

    }
}
