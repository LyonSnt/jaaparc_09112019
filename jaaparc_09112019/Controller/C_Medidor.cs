using Modelo;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Controller
{
   public class C_Medidor
    {
        private Conexion Conexion = new Conexion();
        private M_Medidor objetoMedidorM = new M_Medidor();

      

        public C_Medidor()
        {
            //objetoM.numero = 0;
            //objetoM.lecturaactual = 0;
          //  objetoM.marca = "";
           // objetoM.fecha = "";
        }

        //este es el constructor de la clase,,y debe llevar el mismo nombre que la cl
        //clase C_Medior

        public C_Medidor(string numero, string lecturaactual,string marca, DateTime fecha)
        {
            objetoMedidorM.numero = numero;
            objetoMedidorM.lecturaactual = Convert.ToInt32(lecturaactual);
            objetoMedidorM.marca = marca;
            objetoMedidorM.fecha = fecha;
        }
        

        public C_Medidor(string numero)
        {
            objetoMedidorM.numero = numero;
        }

      

        public C_Medidor(string marca, string idmedidor)
        {
            objetoMedidorM.marca = marca;
            objetoMedidorM.idmedidor = Convert.ToInt32(idmedidor);
        }


        //ESTA PARTE HAY QUE REVIAR 
        public C_Medidor(string estado, string idmedidor,string escc)
        {
            objetoMedidorM.estado= estado;
            objetoMedidorM.idmedidor = Convert.ToInt32(idmedidor);
        }


        public DataTable ConsultarComboxMedidorC()
        {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
                return objetoMedidorM.ConsultarComboxMedidorM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }
        }

        public DataSet ConsultarDatosC()
       {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
              return objetoMedidorM.ConsultarDatosM();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }
       }

        public void InsertarC()
        {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
                objetoMedidorM.InsertarM();
            }
            catch (Exception e)
            {
                throw e;
               
               
            }
            finally { Conexion.CerrarConexion(); }

        }

        public void ModificarC()
        {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
                objetoMedidorM.ModifcarM();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }

        }

        public void EliminarC()
        {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
                objetoMedidorM.EliminarM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }

        }

        public DataTable BuscarC( string textoC)
        {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
                return objetoMedidorM.BuscarM(textoC);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }
        }

        public DataTable ComboC()
        {
            try
            {
                Conexion.AbrirConexion();
                objetoMedidorM.conecc = Conexion;
                return objetoMedidorM.ComboM();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { Conexion.CerrarConexion(); }
        }

    }
}
