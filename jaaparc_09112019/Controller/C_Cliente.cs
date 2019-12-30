using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Controller
{
    public class C_Cliente
    {

        private Conexion conexion = new Conexion();
        private M_Cliente objetoM = new M_Cliente();

        private M_Conexion objetoM_cont = new M_Conexion();



        //public void InsertarClie(string cedula, string nombres, string apellidos, string genero, string idcomunidad, string telefono, string celular, string email)
        //{
        //    objetoM.insertar(cedula,nombres,apellidos,genero,Convert.ToInt32(idcomunidad),telefono,celular,email);
        //}
         

        public C_Cliente()
        {

        }

        public string UltimoRegistroClienteC()
        {
            return objetoM_cont.UltimoRegistroClienteM();
        }

        public C_Cliente(string cedula, string nombres, string apellidos, string genero, int idcomunidad, string telefono, string celular, string email)
        {
            objetoM.cedula = cedula;
            objetoM.nombres = nombres;
            objetoM.apellidos = apellidos;
            objetoM.genero = genero;
            objetoM.idcomunidad =idcomunidad;
            objetoM.telefono= telefono;
            objetoM.celular = celular;
            objetoM.email = email;
           // objetoM.fecha = fecha;
        }


        public C_Cliente(string idcliente)
        {
            objetoM.idcliente = Convert.ToInt32(idcliente);
        }

        //public C_Cliente(string estado, string idcliente)
        //{
        //    objetoM.estado = estado;
        //    objetoM.idcliente = Convert.ToInt32(idcliente);
        //}

        public C_Cliente(string estado, string idmedidor)
        {
            objetoM.estado = estado;
            objetoM.idmedidor = Convert.ToInt32(idmedidor);
        }

        public DataSet ConsultarDatosClienteC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoM.conecc = conexion;
                return objetoM.ConsultarDatosClienteM();
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
                objetoM.conecc = conexion;
                DataTable tabla = new DataTable();
                tabla = objetoM.Mostrar();
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conexion.CerrarConexion(); }
        }

        public void InsertarClienteC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoM.conecc = conexion;
                objetoM.InsertarClienteM();
            }
            catch (Exception e)
            {
                throw e;
               // MessageBox.Show("parte del controller no se que pasa");

            }
            finally { conexion.CerrarConexion(); }

        }


        public void ModificarClienteC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoM.conecc = conexion;
                objetoM.ModifcarClienteM();
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { conexion.CerrarConexion(); }

        }

        public void ModificarMedidorC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoM.conecc = conexion;
                objetoM.ModifcarEstadoMedidor();
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { conexion.CerrarConexion(); }

        }


        public void EliminarClienteC()
        {
            try
            {
                conexion.AbrirConexion();
                objetoM.conecc = conexion;
                objetoM.EliminarClienteM();
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { conexion.CerrarConexion(); }

        }


    }
}
