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
using Npgsql;

namespace View
{
    public partial class Frm_Emision : Form
    {

        private C_Comunidad objetoComunidadC = new C_Comunidad();
        private C_Cliente objetoClienteC = new C_Cliente();

        private C_Emision c_Emision = new C_Emision();

        private C_AsignarMedidor ObjetoAsignarClienteC= new C_AsignarMedidor();
        private C_ConceptoPago ObjetoConceptoPagoC = new C_ConceptoPago();
        private C_Medidor ObjetoMedidorC = new C_Medidor();
        private int opcion = 0;
        private string idcliente = null;

        public Frm_Emision()
        {
            InitializeComponent();
           
            CargarComboxComunidad();
            TxtIdEmision.Enabled = false;
            BtnGuardarAsignarCliente.Enabled = false;
            BtnFinalizarRegistro.Enabled = false;
            TxtIdMedidorFinalizar.Enabled = false;
            TxtNumMedidorFinalizar.Enabled = false;
            // TxtIdClienteAsignar.Enabled = false;

            button2.Enabled = false;

            ComboxGenero();

           

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void CargarComboxComunidad()
        {
            //CbxComunidad.DataSource = objetoComunidadC.ConsultarComboC();
            //CbxComunidad.DisplayMember = "nomcomunidad";
            //CbxComunidad.ValueMember = "idcomunidad";

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

                c_Emision = new C_Emision(TxtDescripcion.Text, TxtMes.Text, TxtAnio.Text, TxtRecaudacion.Text);
              //  objetoClienteC = new C_Cliente(TxtDescripcion.Text, TxtNombre.Text, TxtApellido.Text, CbxGenero.Text, Convert.ToInt32(CbxComunidad.SelectedValue), TxtTelefono.Text, TxtCelular.Text, TxtEmail.Text);

                //objetoClienteC=new C_Cliente(TxtCedula.Text,TxtNombre,)
                return true;
            
            }
            else if (opcion == 2)
            {


                string idfacturacion = Convert.ToString(tablames.CurrentRow.Cells[0].Value);

                string idregistro = Convert.ToString(TablaEmision.CurrentRow.Cells[7].Value);
                string idcliente = Convert.ToString(TablaEmision.CurrentRow.Cells[8].Value);
                string idmedidor = Convert.ToString(TablaEmision.CurrentRow.Cells[9].Value);

                string lecturaanterior = Convert.ToString(TablaEmision.CurrentRow.Cells[2].Value);
                string lecturaactual = Convert.ToString(TablaEmision.CurrentRow.Cells[3].Value);
                string consumom3 = Convert.ToString(TablaEmision.CurrentRow.Cells[4].Value);
                string valortarifa = Convert.ToString(TablaEmision.CurrentRow.Cells[5].Value);
                string total = Convert.ToString(TablaEmision.CurrentRow.Cells[6].Value);


                c_Emision = new C_Emision(idfacturacion, idregistro, idcliente, idmedidor, lecturaanterior, lecturaactual, consumom3, valortarifa, total);
                return true;

            }
            else if (opcion == 3)
            {
                // objetoClienteC = new C_Cliente(idcliente);
                c_Emision = new C_Emision(TxtIdClienteAsignar.Text);
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
            TxtDescripcion.Clear();
            TxtMes.Clear();
            TxtAnio.Clear();
           TxtRecaudacion.Clear();
            TxtRecaudacion.Clear();
            TxtCelular.Clear();
          
        }

        public void DeshabilitarCamposCliente()
        {
            TxtDescripcion.Enabled = false;
            TxtMes.Enabled = false;
            TxtAnio.Enabled = false;
            CbxGenero.Enabled = false;
           
            TxtRecaudacion.Enabled = false;
            TxtCelular.Enabled = false;
          
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

        public void GuardarEmisionF()
        {
            opcion = 1;
            if (ValidarDatos() == true)
            {
                try
                {

                    c_Emision.InsertarEmisionC();
                    MessageBox.Show("guadra correctamente");
                    tablames.Rows.Add(c_Emision.UltimoRegistroEmisionC());
                    //MessageBox.Show("datos guardamos");
                    //UltimoRegistroClienteF();
                    //CargarComboxMedidor();
                    //CargarComboxConceptoPago();
                    //CargarFechaInstalacion();
                    //TxtCostoRegistro.Text = "350";
                    //BtnGuardarClientes.Enabled = false;
                    //BtnGuardarAsignarCliente.Enabled = true;
                    //TabPanelPrincipal.SelectedTab = TabPanelAsignarMedidor;



                }
                catch (Exception ef)
                {
                    MessageBox.Show("No se permite campos vacios ni minusculas"+ef);
                    
                }

            }

        }

        public void InsertarDetalleEmisionF()
        {
            opcion = 2;
            if (ValidarDatos() == true)
            {
                try
                {
                    c_Emision.InsertarDetalleEmisionC();
                    MessageBox.Show("guadra correctamente");
                }
                catch(Exception ef)
                {
                    MessageBox.Show("no se que passa: " + ef);
                }

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

        public void ConsultarDatosEmisionF2()
        {
            opcion = 3;
            if (ValidarDatos() == true)
            {
                // objetoClienteC.EliminarClienteC();

                try
                {
                    c_Emision.ConsultarDatosEmision2C();
                  

                }
                catch(Exception rt)
                {
                    MessageBox.Show("Datos no se que era"+rt);
                }
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
                TabPanelPrincipal.SelectedTab = TabPanelActualizarMedidor;

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
                GuardarEmisionF();
              
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

        public void DeshabilitarColumnasTablaEmision()
        {
            TablaEmision.Columns["column1"].ReadOnly = true;
            TablaEmision.Columns["column2"].ReadOnly = true;
            TablaEmision.Columns["column3"].ReadOnly = true;
            TablaEmision.Columns["column4"].ReadOnly = true;
            TablaEmision.Columns["column6"].ReadOnly = true;
            TablaEmision.Columns["column7"].ReadOnly = true;
            TablaEmision.Columns["column8"].ReadOnly = true;
            TablaEmision.Columns["column9"].ReadOnly = true;
            TablaEmision.Columns["column10"].ReadOnly = true;

        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            // TablaEmision.DataSource = c_Emision.ConsultarDatosEmision2C();
            DeshabilitarColumnasTablaEmision();
         //  ConsultarDatosEmisionF();

         // TablaEmision.AllowUserToAddRows = false;

          //  TxtIdEmision.Text = c_Emision.UltimoRegistroEmisionC();
           
        }

        //private void TablaEmision_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
        //    if (TablaEmision.CurrentCell.ColumnIndex == 5) //Desired Column 
        //    {
        //        TextBox tb = e.Control as TextBox;
        //        if (tb != null)
        //        {
        //            tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
        //        }
        //    }
        //}

       


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
            string nom = TxtIdEmision.Text;
            TxtIdClienteAsignar.Text = nom;
            TabPanelPrincipal.SelectedTab = TabPanelAsignarMedidor;

        
         
            TxtIdEmision.Enabled = false;

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

            TabPanelPrincipal.SelectedTab = TabPanelActualizarMedidor;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            TabPanelPrincipal.SelectedTab = TabPanelAsignarMedidor;
            // TxtIdEmision.Text = c_Emision.UltimoRegistroEmisionC();

            LblIdFacturacion.Text = c_Emision.UltimoRegistroEmisionC();

           // tablames.Rows.Add(c_Emision.UltimoRegistroEmisionC());


           
        }


        public void ConsultarDatosEmisionF(string idfactuta)
        {
            DataSet ds = new DataSet();
            ds = c_Emision.ConsultarDatosEmisionC(idfactuta);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TablaEmision.RowCount = ds.Tables[0].Rows.Count;
                for (int i = 0; i < TablaEmision.RowCount; i++)
                {
                    TablaEmision.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    TablaEmision.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    TablaEmision.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                    //EN ESTA PARTE LA COLUMNA DE LA LECTURA ANTERIOR TOMA EL VALOR DE LA COLUMNA DE LA LECTURA ACTUAL
                    TablaEmision.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                   // TablaEmision.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    TablaEmision.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                    TablaEmision.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    TablaEmision.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i].ItemArray[7].ToString();

                    TablaEmision.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    TablaEmision.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                  //  TablaEmision.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i].ItemArray[10].ToString();
                    //TablaEmision.Rows[i].Cells[11].Value = ds.Tables[0].Rows[i].ItemArray[11].ToString();
                    //TablaEmision.Rows[i].Cells[12].Value = ds.Tables[0].Rows[i].ItemArray[12].ToString();
                    //TablaEmision.Rows[i].Cells[13].Value = ds.Tables[0].Rows[i].ItemArray[13].ToString();


                }
            }
        }
        private M_Conexion conexion = new M_Conexion();
        private void button2_Click_1(object sender, EventArgs e)
        {
            //double val = Convert.ToDouble(TablaEmision.CurrentRow.Cells[1].Value);
            //MessageBox.Show("valor de la celda 1: " + val);

            // ConsultarDatosEmisionF();

            // TablaEmision.DataSource = c_Emision.ConsultarDatosEmisionC;

            // TablaEmision.DataSource = c_Emision.ConsultarDatosEmisionC();

            conexion.AbrirConexion();

            //int codigo = 14;

           // string idfacturacion = Convert.ToString(tablames.CurrentRow.Cells[0].Value);
            string idfacturacion2 = LblIdFacturacion.Text;

             NpgsqlCommand agregar = new NpgsqlCommand("insert into fct_detfacturacion values ('"+ idfacturacion2 + "',@idregistro,@idcliente,@idmedidor,@lecturaanterior,@lecturaactual,@consumom3,@valortarifa,@total)", conexion.AbrirConexion());
            // NpgsqlCommand agregar = new NpgsqlCommand("insert into hoy28 values ('"+ idfacturacion + "',@nombre,@apellido)", conexion.AbrirConexion());

          

            try
            {
               
                foreach (DataGridViewRow row in TablaEmision.Rows)
                {
                    agregar.Parameters.Clear();

                    //agregar.Parameters.AddWithValue("@codigo", Convert.ToInt32(row.Cells["Column1"].Value));
                    //agregar.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["Column2"].Value));
                    //agregar.Parameters.AddWithValue("@apellido", Convert.ToString(row.Cells["Column3"].Value));

                    //// agregar.Parameters.AddWithValue("iddetfacturacion", Convert.ToString(row.Cells["Column1"].Value));
                   // agregar.Parameters.AddWithValue("@idfacturacion", Convert.ToInt32(row.Cells["Column1"].Value));
                    agregar.Parameters.AddWithValue("@idregistro", Convert.ToInt32(row.Cells["Column1"].Value));
                    agregar.Parameters.AddWithValue("@idcliente", Convert.ToInt32(row.Cells["Column9"].Value));
                    agregar.Parameters.AddWithValue("@idmedidor", Convert.ToInt32(row.Cells["Column10"].Value));
                    agregar.Parameters.AddWithValue("@lecturaanterior", Convert.ToDouble(row.Cells["Column4"].Value));
                    agregar.Parameters.AddWithValue("@lecturaactual", Convert.ToDouble(row.Cells["Column5"].Value));
                    agregar.Parameters.AddWithValue("@consumom3", Convert.ToDouble(row.Cells["Column6"].Value));
                    agregar.Parameters.AddWithValue("@valortarifa", Convert.ToDouble(row.Cells["Column7"].Value));
                    agregar.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells["Column8"].Value));
                  

                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("agregado");
            }
            catch(Exception tr)
            {

                MessageBox.Show("eroor:"+tr);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //foreach(DataGridViewRow row in TablaEmision.Rows)
            //{
                InsertarDetalleEmisionF();
           // }

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TablaEmision.AllowUserToAddRows = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TablaEmision.ReadOnly = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TablaEmision.ReadOnly = false;
        }

        private void TablaEmision_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.TablaEmision.Columns[e.ColumnIndex].Name == "Column5")
            {
                if (Convert.ToDouble(e.Value) < 3000)
                {
                   // e.CellStyle.ForeColor = Color.Gray;
                    e.CellStyle.BackColor = Color.Gray;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

           // TxtIdClienteAsignar.Text = "2";
            ConsultarDatosEmisionF(TxtIdClienteAsignar.Text);
            

        }

        private void TablaEmision_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Lecturaanterior,Lecturaactual,consumom3;
            double valortarifa, total;

            Lecturaanterior = Convert.ToInt32(TablaEmision.Rows[e.RowIndex].Cells["Column4"].Value);
            Lecturaactual = Convert.ToInt32(TablaEmision.Rows[e.RowIndex].Cells["Column5"].Value);

            if(Lecturaactual >= Lecturaanterior)
            {
                consumom3 = Lecturaactual - Lecturaanterior;
                TablaEmision.Rows[e.RowIndex].Cells["Column6"].Value = consumom3;

                valortarifa = Convert.ToDouble(TablaEmision.Rows[e.RowIndex].Cells["Column7"].Value);
                total = consumom3 * valortarifa;
                TablaEmision.Rows[e.RowIndex].Cells["Column8"].Value = total;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("La lectura actual debe ser mayor o igual a la lectura anterior");
                button2.Enabled = false;

            }

           




        }

        private void button10_Click(object sender, EventArgs e)
        {
            TabPanelPrincipal.SelectedTab = TabPanelActualizarMedidor;
            //TablaEditarMedidor.Rows.Add(new string[] {
            //    Convert.ToString(TablaEmision[9, TablaEmision.CurrentRow.Index].Value),
            //    Convert.ToString(TablaEmision[2, TablaEmision.CurrentRow.Index].Value)
            //});

            foreach (DataGridViewRow v in TablaEmision.Rows)
            {
                TablaEditarMedidor.Rows.Add(new string[] {
            v.Cells[9].Value.ToString(),
            v.Cells[2].Value.ToString(),
             v.Cells[4].Value.ToString(),

        });
            }

            //    try
            //    {
            //        int Lecturaanterior, Lecturaactual;


            //        Lecturaanterior = Convert.ToInt32(TablaEmision.Rows[0].Cells["Column4"].Value);
            //        Lecturaactual = Convert.ToInt32(TablaEmision.Rows[0].Cells["Column5"].Value);

            //        if (Lecturaactual >= Lecturaanterior)
            //        {
            //            MessageBox.Show("Correcto");
            //        }
            //        else
            //        {
            //            MessageBox.Show("La lectura actual debe ser mayor o igual a la lectura anterior");


            //        }
            //    }catch(Exception rt)
            //    {
            //        MessageBox.Show("nooo"+rt);

            //    }
        }


        // INICIO DE LA VALIDACION DE SOLO NUMEROS EN LA COLUMAN DE LECTURA ACTUAL
        private void Column4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TablaEmision_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column4_KeyPress);
            if (TablaEmision.CurrentCell.ColumnIndex == 4) //COLUMA DE LA LECTURA ACTUAL..EN ESTE CASO ES EL 4..PORQUE ESTA CONTANDO DESDE EL 0
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column4_KeyPress);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TablaEditarMedidor.AllowUserToAddRows = false;
        }

       
      
        private void button13_Click_1(object sender, EventArgs e)
        {
            conexion.AbrirConexion();

            //int codigo = 14;

            string idfacturacion = Convert.ToString(TablaEditarMedidor.CurrentRow.Cells[2].Value);
            string idmedidor = Convert.ToString(TablaEditarMedidor.CurrentRow.Cells[0].Value);


            //.....
            NpgsqlCommand agregar = new NpgsqlCommand("update ins_medidor set @lecturaactual = ('"+idfacturacion+ "') where @idmedidor ='" + idmedidor + "'", conexion.AbrirConexion());
           // update ins_medidor set lecturaactual = 12 where idmedidor = 1

            // NpgsqlCommand agregar = new NpgsqlCommand("insert into hoy28 values ('"+ idfacturacion + "',@nombre,@apellido)", conexion.AbrirConexion());
              NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(agregar);
              NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(adapter);

          //  UpdateComma


            try
            {

                foreach (DataGridViewRow row in TablaEditarMedidor.Rows)
                {
                    agregar.Parameters.Clear();

                    //agregar.Parameters.AddWithValue("@codigo", Convert.ToInt32(row.Cells["Column1"].Value));
                    //agregar.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["Column2"].Value));
                    //agregar.Parameters.AddWithValue("@apellido", Convert.ToString(row.Cells["Column3"].Value));

                    //// agregar.Parameters.AddWithValue("iddetfacturacion", Convert.ToString(row.Cells["Column1"].Value));
                    // agregar.Parameters.AddWithValue("@idfacturacion", Convert.ToInt32(row.Cells["Column1"].Value));
                    agregar.Parameters.AddWithValue("@lecturaactual", Convert.ToInt32(row.Cells["Column13"].Value));
                    //agregar.Parameters.AddWithValue("@idcliente", Convert.ToInt32(row.Cells["Column9"].Value));
                    //agregar.Parameters.AddWithValue("@idmedidor", Convert.ToInt32(row.Cells["Column10"].Value));
                    //agregar.Parameters.AddWithValue("@lecturaanterior", Convert.ToDouble(row.Cells["Column4"].Value));
                    //agregar.Parameters.AddWithValue("@lecturaactual", Convert.ToDouble(row.Cells["Column5"].Value));
                    //agregar.Parameters.AddWithValue("@consumom3", Convert.ToDouble(row.Cells["Column6"].Value));
                    //agregar.Parameters.AddWithValue("@valortarifa", Convert.ToDouble(row.Cells["Column7"].Value));
                    //agregar.Parameters.AddWithValue("@total", Convert.ToDouble(row.Cells["Column8"].Value));


                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("agregado");
            }
            catch (Exception tr)
            {

                MessageBox.Show("eroor:" + tr);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // FIN DE LA VALIDACION DE SOLO NUMEROS EN LA COLUMAN DE LECTURA ACTUAL
    }
}
