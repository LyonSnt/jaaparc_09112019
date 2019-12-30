using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Modelo;

namespace View
{
    public partial class Frm_Clientes : Form
    {

        private C_Comunidad objetoComunidadC = new C_Comunidad();
        private C_Cliente objetoClienteC = new C_Cliente();
        private C_AsignarMedidor ObjetoAsignarClienteC= new C_AsignarMedidor();
        private C_ConceptoPago ObjetoConceptoPagoC = new C_ConceptoPago();
        private C_Medidor ObjetoMedidorC = new C_Medidor();
        private int opcion = 0;
        private string idcliente = null;

        public Frm_Clientes()
        {
            InitializeComponent();
           
            CargarComboxComunidad();
            TxtIdClienteRegistrar.Enabled = false;
            BtnGuardarAsignarCliente.Enabled = false;
            BtnFinalizarRegistro.Enabled = false;
            TxtIdMedidorFinalizar.Enabled = false;
            TxtNumMedidorFinalizar.Enabled = false;
            TxtIdClienteAsignar.Enabled = false;

            ComboxGenero();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void CargarComboxComunidad()
        {
            CbxComunidad.DataSource = objetoComunidadC.ConsultarComboC();
            CbxComunidad.DisplayMember = "nomcomunidad";
            CbxComunidad.ValueMember = "idcomunidad";

        }


        public void CargarComboxConceptoPago()
        {
            CbxBasePagar.DataSource = ObjetoConceptoPagoC.ConsultarComboxConceptoPagoC();
            CbxBasePagar.DisplayMember = "descpago";
            CbxBasePagar.ValueMember = "idpago";

        }

        public void CargarComboxMedidor()
        {
            CbxNumeroMedidorAsignar.DataSource = ObjetoMedidorC.ConsultarComboxMedidorC();
            CbxNumeroMedidorAsignar.DisplayMember = "numero";  
            CbxNumeroMedidorAsignar.ValueMember = "idmedidor";


        }

        public void ComboxGenero()
        {
            CbxGenero.Items.Insert(0, "Seleccionar");
            CbxGenero.SelectedIndex = 0;
            CbxGenero.Items.Add("M");
            CbxGenero.Items.Add("F");

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Validar.SoloLetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar.SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar.NumerosDecimales(e);
        }

        public bool ValidarDatos()
        {
            if (opcion == 1)
            {
                objetoClienteC = new C_Cliente(TxtCedula.Text, TxtNombre.Text, TxtApellido.Text, CbxGenero.Text, Convert.ToInt32(CbxComunidad.SelectedValue), TxtTelefono.Text, TxtCelular.Text, TxtEmail.Text);

                //objetoClienteC=new C_Cliente(TxtCedula.Text,TxtNombre,)
                return true;
            
            }
            else if (opcion == 2)
            {

                ObjetoMedidorC = new C_Medidor("OC", idcliente);
                return true;

            }
            else if (opcion == 3)
            {
                objetoClienteC = new C_Cliente(idcliente);
                return true;
            }
            else if (opcion == 4)
            {
                DateTime FechaInstalacion = DateTime.Now;
                ObjetoAsignarClienteC = new C_AsignarMedidor(TxtIdClienteAsignar.Text, CbxNumeroMedidorAsignar.SelectedValue.ToString(), CbxBasePagar.SelectedValue.ToString(), TxtCostoRegistro.Text, TxtNumCuota.Text, FechaInstalacion, TxtFechaLimitePago.Text, TxtValorPagado.Text);

                return true;
            }
            else if (opcion == 5)
            {
                return true;
            }
            else if (opcion == 7)
            {
                objetoClienteC = new C_Cliente("OC", TxtIdMedidorFinalizar.Text);
                return true;
            }
            else
            {
                return true;
            }

        }

        public void LimpiarCamposCliente()
        {
            TxtCedula.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
           TxtTelefono.Clear();
            TxtTelefono.Clear();
            TxtCelular.Clear();
            TxtEmail.Clear();
        }

        public void DeshabilitarCamposCliente()
        {
            TxtCedula.Enabled = false;
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            CbxGenero.Enabled = false;
            CbxComunidad.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtCelular.Enabled = false;
            TxtEmail.Enabled = false;
        }

        public void DeshabilitarCamposAsignarCliente()
        {
            CbxNumeroMedidorAsignar.Enabled = false;
            CbxBasePagar.Enabled = false;
            TxtCostoRegistro.Enabled = false;
            TxtNumCuota.Enabled = false;
            TxtFechaInstalacion.Enabled = false;
            TxtFechaLimitePago.Enabled = false;
            TxtValorPagado.Enabled = false;
            TxtIntereses.Enabled = false;
        }



        public void CargarFechaInstalacion()
        {
           
            DateTime FechaInstalacion = DateTime.Now;
            TxtFechaInstalacion.Text = Convert.ToString(FechaInstalacion);
        }

        public void GuardarCliente()
        {
            opcion = 1;
            if (ValidarDatos() == true)
            {
                try
                {
                    
                    objetoClienteC.InsertarClienteC();
                    MessageBox.Show("datos guardamos");
                    UltimoRegistroClienteF();
                    CargarComboxMedidor();
                    CargarComboxConceptoPago();
                    CargarFechaInstalacion();
                    TxtCostoRegistro.Text = "350";
                    BtnGuardarClientes.Enabled = false;
                    BtnGuardarAsignarCliente.Enabled = true;
                    TabPanelPrincipal.SelectedTab = TabPanelAsignarMedidor;
                   

                   
                }
                catch (Exception ef)
                {
                    MessageBox.Show("No se permite campos vacios ni minusculas");
                    
                }

            }

        }

        public void ModifcarCliente()
        {
            opcion = 2;
            if (ValidarDatos() == true)
            {
                objetoClienteC.ModificarMedidorC();
                MessageBox.Show("Datos Actualizados");
                //TablaCliente.DataSource = objetoClienteC.ConsultarDatosCliente();

            }
        }

        public void ModifcarEstadoMed()
        {
            opcion = 7;
            if (ValidarDatos() == true)
            {
                objetoClienteC.ModificarMedidorC();
                MessageBox.Show("Datos Actualizados");
                //TablaCliente.DataSource = objetoClienteC.ConsultarDatosCliente();

            }
        }

        public void EliminarCliente()
        {
            opcion = 3;
            if (ValidarDatos() == true)
            {
                objetoClienteC.EliminarClienteC();
                MessageBox.Show("Datos Eliminados");
                //TablaCliente.DataSource = objetoClienteC.ConsultarDatosCliente();

            }
        }



        public void GuardarAsignarClienteF()
        {
            opcion = 4;
            if (ValidarDatos() == true)
            {
                ObjetoAsignarClienteC.InsertarAsignarClienteC();
                MessageBox.Show("Registro correctamente");
                TabPanelPrincipal.SelectedTab = TabPanelActualizaeEstado;

                TxtIdMedidorFinalizar.Text = CbxNumeroMedidorAsignar.SelectedValue.ToString(); //AQUI ESTOY ENVIANDO EL ID DEL MEDIDOR,
                                                                                               //DEACUERDO A LA SELECCION DEL COMBOX
                string NumeroMedidorAsignar = CbxNumeroMedidorAsignar.Text;
                TxtNumMedidorFinalizar.Text = NumeroMedidorAsignar; //AQUI ESTOY ENVIANDO EL NUMERO DE MEDIROR DE LA PARTE DE ASIGNAR A 
                                                                    //LA PARTE DE FINALIZAR PARA PODER ACTUALIZAR EL ESTADO DEL MEDIDOR

                BtnFinalizarRegistro.Enabled = true;
                BtnGuardarClientes.Enabled = false;
            }

        }

        public void ModifcarAsignarCliente()
        {
            opcion = 5;
            if (ValidarDatos() == true)
            {
                objetoClienteC.ModificarClienteC();
                MessageBox.Show("Datos Actualizados");
                //TablaCliente.DataSource = objetoClienteC.ConsultarDatosCliente();

            }
        }

        public void EliminarAsignarCliente()
        {
            opcion = 6;
            if (ValidarDatos() == true)
            {
                objetoClienteC.EliminarClienteC();
                MessageBox.Show("Datos Eliminados");
                //TablaCliente.DataSource = objetoClienteC.ConsultarDatosCliente();

            }
        }





        private void BtnGuardarClientes_Click(object sender, EventArgs e)
        {

            try
            {
                GuardarCliente();
              
            }
            catch (Exception ex)
            {
                //throw ex;

                MessageBox.Show("Revise los datos algo pasooo");
            }
        }

        private void UltimoRegistroClienteF()
        {

            TxtIdClienteAsignar.Text = objetoClienteC.UltimoRegistroClienteC();

           // LblNumCliente.Text = objetoClienteC.contadorCliente();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
          
        }


        public static int GetQuarter(DateTime date)
        {
            if (date.Month >= 4 && date.Month <= 6)
                return 1;
            else if (date.Month >= 7 && date.Month <= 9)
                return 2;
            else if (date.Month >= 10 && date.Month <= 12)
                return 3;
            else
                return 4;

        }
        private void button14_Click(object sender, EventArgs e)
        {
            string nom = TxtIdClienteRegistrar.Text;
            TxtIdClienteAsignar.Text = nom;
            TabPanelPrincipal.SelectedTab = TabPanelAsignarMedidor;

        
         
            TxtIdClienteRegistrar.Enabled = false;

           // DeshabilitarCamposCliente();

            BtnGuardarAsignarCliente.Enabled = true;
            CargarComboxMedidor();
            CargarComboxConceptoPago();
            DateTime FechaInstalacion = DateTime.Now;
            TxtFechaInstalacion.Text = Convert.ToString(FechaInstalacion);

            TxtCostoRegistro.Text = "350";
            //  contarcliente();
            TxtIntereses.Text = "0";
            BtnGuardarClientes.Enabled = false;
            // TabPanelAsignarMedidor.Dispose();

            // TabPageRegistrarCliente.Dispose();
            //  TxtCedula.Text = TxtNombre.Text;

            // var dat = new DateTime(2015, 12, 31);

            //string val = TxtApellido.Text;
            //int nume = Convert.ToInt32(TxtCedula.Text);
            //DateTime fech = DateTime.Now;
            //for (int ctr = 1; ctr <= nume; ctr++)

            //    MessageBox.Show(fech.AddMonths(ctr).ToString("d"));
            //}

            //DateTime fechaInicial = DateTime.Parse(TxtNombre.Text);

            //DateTime fechaFinal = DateTime.Parse(TxtApellido.Text);

            //int diferencia = (fechaFinal.Month - fechaInicial.Month) + (12 * (fechaFinal.Year - fechaInicial.Year));

            //MessageBox.Show(Convert.ToString(diferencia));

        }

        private void BtnGuardarAsignarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarAsignarClienteF();

               



            }
            catch (Exception ex)
            {
                // MessageBox.Show("error: " + ex);
                throw ex;
            }
        }

        private void NumeroCuota(object sender, KeyEventArgs e)
        {
            try
            {
                int numcuotas = Convert.ToInt32(TxtNumCuota.Text);

                if (numcuotas != 0)
                {
                    DateTime d = DateTime.Now.AddMonths(numcuotas);
                    string fecha = d.ToString("dd/MM/yyyy");
                    TxtFechaLimitePago.Text = fecha;
                }
                else
                {
                    MessageBox.Show("La cuota no puede ser cero");
                }

            }
            catch (Exception ec)
            {
                // MessageBox.Show("Debe ingresar el numero de cuotas");
            }
        }

        private void btnmodifi_Click(object sender, EventArgs e)
        {
            ModifcarAsignarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = CbxNumeroMedidorAsignar.Text;
            TxtIdMedidorFinalizar.Text = CbxNumeroMedidorAsignar.SelectedValue.ToString(); //DEBE IR EL ID

            TxtNumMedidorFinalizar.Text = nom;

            TabPanelPrincipal.SelectedTab = TabPanelActualizaeEstado;

            DeshabilitarCamposAsignarCliente();

            //button14.Enabled = false;
            //lblval.Enabled = true;

            //txtidcli.Enabled = false;

            //DeshabilitarCamposCliente();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ModifcarEstadoMed();
            this.Close();


        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnFinalizarRegistro_Click(object sender, EventArgs e)
        {
            ModifcarEstadoMed();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    objetoClienteC.InsertarClie(TxtCedula.Text, TxtNombre.Text, TxtApellido.Text, CbxGenero.Text, CbxComunidad.SelectedValue.ToString(), TxtTelefono.Text, TxtCelular.Text, TxtEmail.Text);
            //    MessageBox.Show("Guardador correctamente");
            //}
            //catch (Exception ex)
            //{
            //   // throw ed;
            //    MessageBox.Show("Los campos no pueden ser vacios/ó en minusculas"+ex);
            //}
        }
    }
}
