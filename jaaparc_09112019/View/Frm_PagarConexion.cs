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
    public partial class Frm_PagarConexion : Form
    {

        private C_Comunidad objetoComunidadC = new C_Comunidad();
        private C_Cliente objetoClienteC = new C_Cliente();
        private C_AsignarMedidor ObjetoAsignarClienteC= new C_AsignarMedidor();
        private C_ConceptoPago ObjetoConceptoPagoC = new C_ConceptoPago();
        private C_Medidor ObjetoMedidorC = new C_Medidor();
        private int opcion = 0;
        private string idcliente = null;

        private string valorpagado = null;

        public Frm_PagarConexion()
        {
            InitializeComponent();
                //TxtIdClienteRegistrar.Enabled = false;
            //BtnGuardarAsignarCliente.Enabled = false;
            BtnFinalizarPago.Enabled = false;
            LblIdpagounicoo.Enabled = false;
          
           // TxtIdClienteAsignar.Enabled = false;


        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string idregistro = Convert.ToString(TablaInscripcion.CurrentRow.Cells[0].Value);
                string idcliente = Convert.ToString(TablaInscripcion.CurrentRow.Cells[11].Value);
                string idmedidor = Convert.ToString(TablaInscripcion.CurrentRow.Cells[12].Value);
                string idpago = Convert.ToString(TablaInscripcion.CurrentRow.Cells[13].Value);
                //objetoClienteC = new C_Cliente(TxtCedula.Text, TxtNombre.Text, TxtApellido.Text, CbxGenero.Text, Convert.ToInt32(CbxComunidad.SelectedValue), TxtTelefono.Text, TxtCelular.Text, TxtEmail.Text);
                ObjetoAsignarClienteC = new C_AsignarMedidor(idregistro, idcliente, idmedidor, idpago, TxtValoraPagar.Text);
                //objetoClienteC=new C_Cliente(TxtCedula.Text,TxtNombre,)
                return true;
            
            }
            else if (opcion == 2)
            {

               // ObjetoMedidorC = new C_Medidor("OC", idcliente);
                ObjetoAsignarClienteC = new C_AsignarMedidor(LblTotalpagadoFinalizar.Text, LblIdpagounicoo.Text);
                return true;

            }
            else if (opcion == 3)
            {
                objetoClienteC = new C_Cliente(idcliente);
                return true;
            }
            else if (opcion == 4)
            {
               
                return true;
            }
            else if (opcion == 5)
            {
                return true;
            }
            else if (opcion == 7)
            {
                objetoClienteC = new C_Cliente("OC", LblIdpagounicoo.Text);
                return true;
            }
            else
            {
                return true;
            }

        }

        public void LimpiarCamposRealizarPago()
        {
            LblIdRegistro.Text="...";
            LblIdCliente.Text = "...";
            LblIdMedidor.Text = "...";
            LblIdPago.Text = "..."; 
            TxtValoraPagar.Clear();
            LblIdpagounicoo.Text = "...";
            LblTotalpagadoFinalizar.Text = "...";
            LblValorCancelado.Text = ".";
            LblDeuda.Text = ".";
        }

        public void DeshabilitarCamposCliente()
        {
            //TxtCedula.Enabled = false;
            //TxtNombre.Enabled = false;
            //TxtApellido.Enabled = false;
            //CbxGenero.Enabled = false;
            //CbxComunidad.Enabled = false;
            //TxtTelefono.Enabled = false;
            //TxtCelular.Enabled = false;
            //TxtEmail.Enabled = false;
        }
        

        public void Calculos()
        {

            //ObjetoAsignarClienteC.BuscarValorPagadoC();
            LblIdpagounicoo.Text = LblIdRegistro.Text;
            ObjetoAsignarClienteC.BuscarValorPagadoC(Convert.ToInt32(LblIdpagounicoo));
            double val = Convert.ToDouble(TablaInscripcion.CurrentRow.Cells[7].Value);
            double valorapagar = Convert.ToDouble(TxtValoraPagar.Text);
            double suma = val + valorapagar;
            LblIdpagounicoo.Text = Convert.ToString(suma);
            BtnFinalizarPago.Enabled = true;

            double costo = Convert.ToDouble(TablaInscripcion.CurrentRow.Cells[4].Value);
            double excede = suma - costo;

            if (suma <= costo)
            {
                TabPanelPrincipal.SelectedTab = TabPanelActualizarValorPago;
            }
            else
            {
                MessageBox.Show("solo debe cancela el monto de :" + costo + "\n" + "Excede en " + excede);
            }
        }

        public void GuardarDetalle()
        {
            opcion = 1;
            if (ValidarDatos() == true)
            {
                try
                {

                    ObjetoAsignarClienteC.InsertarDetalleClienteC();
                    LblIdpagounicoo.Text = LblIdRegistro.Text;
                    PasarTextbox(Convert.ToInt32(LblIdpagounicoo.Text));
                    TabPanelPrincipal.SelectedTab = TabPanelActualizarValorPago;
                    BtnFinalizarPago.Enabled = true;

                }
                catch (Exception ef)
                {
                    MessageBox.Show("No se permite campos vacios ni minusculas");
                    
                }

            }

        }

        public void ModificarValorPagadoF()
        {
            opcion = 2;
            if (ValidarDatos() == true)
            {
                ObjetoAsignarClienteC.ModificarValorPagadoC();
                MessageBox.Show("Datos Actualizados");
                LimpiarCamposRealizarPago();
                TabPanelPrincipal.SelectedTab = TabPagePagar;
                CargarGrilla();
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
                GuardarDetalle();
              
            }
            catch (Exception ex)
            {
                //throw ex;

                MessageBox.Show("Revise los datos algo pasooo");
            }
        }


        public void CargarGrilla()
        {
            DataSet ds = new DataSet();
            ds = ObjetoAsignarClienteC.ConsultarDatosInscripcionC();
            if (ds.Tables[0].Rows.Count > 0)
            {
                TablaInscripcion.RowCount = ds.Tables[0].Rows.Count;
                for (int i = 0; i < TablaInscripcion.RowCount; i++)
                {
                    TablaInscripcion.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    TablaInscripcion.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    TablaInscripcion.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    TablaInscripcion.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    TablaInscripcion.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    TablaInscripcion.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                    TablaInscripcion.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    TablaInscripcion.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    TablaInscripcion.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    TablaInscripcion.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    TablaInscripcion.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i].ItemArray[10].ToString();
                   TablaInscripcion.Rows[i].Cells[11].Value = ds.Tables[0].Rows[i].ItemArray[11].ToString();
                    TablaInscripcion.Rows[i].Cells[12].Value = ds.Tables[0].Rows[i].ItemArray[12].ToString();
                    TablaInscripcion.Rows[i].Cells[13].Value = ds.Tables[0].Rows[i].ItemArray[13].ToString();


                }
            }
        }

       
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
              CargarGrilla();

             //TablaInscripcion.DataSource = ObjetoAsignarClienteC.ConsultarDatosCliente();
           
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
            
        }

        private void btnmodifi_Click(object sender, EventArgs e)
        {
            ModifcarAsignarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
            ModificarValorPagadoF();
          //  this.Close();
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

        public void BuscarValorPagado(int texto)
        {

            DataTable table = new DataTable();
            table = ObjetoAsignarClienteC.BuscarValorPagadoC(texto);
            if (table.Rows.Count > 0)
            {
                TablaInscripcion.Rows.Clear();
                TablaInscripcion.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //EL PRIMER NUMERO ES LA POSICION DE LA COLUMNA,
                    //EL SEGUNDO NUMERO ES EL NUMERO DE CONSULTA
                    TablaInscripcion[7, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                  



                }
            }

        }


       

        public void Busqueda(string texto)
        {
            DataTable table = new DataTable();
            table = ObjetoAsignarClienteC.BuscarClientesInscripcionC(texto);
            if (table.Rows.Count > 0)
            {
                TablaInscripcion.Rows.Clear();
                TablaInscripcion.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    TablaInscripcion[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    TablaInscripcion[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    TablaInscripcion[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    TablaInscripcion[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    TablaInscripcion[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    TablaInscripcion[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);

                    TablaInscripcion[6, i].Value = Convert.ToString(table.Rows[i].ItemArray[6]);
                    TablaInscripcion[7, i].Value = Convert.ToString(table.Rows[i].ItemArray[7]);
                    TablaInscripcion[8, i].Value = Convert.ToString(table.Rows[i].ItemArray[8]);
                    TablaInscripcion[9, i].Value = Convert.ToString(table.Rows[i].ItemArray[9]);
                    TablaInscripcion[10, i].Value = Convert.ToString(table.Rows[i].ItemArray[10]);
                    TablaInscripcion[11, i].Value = Convert.ToString(table.Rows[i].ItemArray[11]);
                    TablaInscripcion[12, i].Value = Convert.ToString(table.Rows[i].ItemArray[12]);
                    TablaInscripcion[13, i].Value = Convert.ToString(table.Rows[i].ItemArray[13]);


                }
            }
        }

        public void BusquedaBoton(string texto)
        {
            DataTable table = new DataTable();
            table = ObjetoAsignarClienteC.BuscarClientesInscripcionBuscarC(texto);
            if (table.Rows.Count > 0)
            {
                TablaInscripcion.Rows.Clear();
                TablaInscripcion.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    TablaInscripcion[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    TablaInscripcion[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    TablaInscripcion[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    TablaInscripcion[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    TablaInscripcion[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    TablaInscripcion[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);

                    TablaInscripcion[6, i].Value = Convert.ToString(table.Rows[i].ItemArray[6]);
                    TablaInscripcion[7, i].Value = Convert.ToString(table.Rows[i].ItemArray[7]);
                    TablaInscripcion[8, i].Value = Convert.ToString(table.Rows[i].ItemArray[8]);
                    TablaInscripcion[9, i].Value = Convert.ToString(table.Rows[i].ItemArray[9]);
                    TablaInscripcion[10, i].Value = Convert.ToString(table.Rows[i].ItemArray[10]);
                    TablaInscripcion[11, i].Value = Convert.ToString(table.Rows[i].ItemArray[11]);
                    TablaInscripcion[12, i].Value = Convert.ToString(table.Rows[i].ItemArray[12]);
                    TablaInscripcion[13, i].Value = Convert.ToString(table.Rows[i].ItemArray[13]);


                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
           
            Busqueda(txtBuscar.Text);
        }

   
        private void TablaInscripcion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //idmedidor = TablaMedidor.CurrentRow.Cells[0].Value.ToString(); es lo mismo que el de abajo
            // idmedidor = Convert.ToString(TablaMedidor.CurrentRow.Cells[0].Value); //estamos guardando en una variable idmedidor
            //para poder actualizar , debido a que el id medidor no se encuentra en el formulario

            LblIdRegistro.Text = Convert.ToString(TablaInscripcion.CurrentRow.Cells[0].Value);

            LblIdCliente.Text = Convert.ToString(TablaInscripcion.CurrentRow.Cells[1].Value);
            LblIdMedidor.Text = Convert.ToString(TablaInscripcion.CurrentRow.Cells[2].Value);
            LblIdPago.Text = Convert.ToString(TablaInscripcion.CurrentRow.Cells[3].Value);



            LblValorCancelado.Text ="$" + Convert.ToString(TablaInscripcion.CurrentRow.Cells[7].Value);

            double costo = Convert.ToDouble(TablaInscripcion.CurrentRow.Cells[4].Value);
            double pagado = Convert.ToDouble(TablaInscripcion.CurrentRow.Cells[7].Value);
            double resul = costo - pagado;

            LblDeuda.Text = Convert.ToString("$" + resul);


        }

        private void BtnGuardarDetalle_Click(object sender, EventArgs e)
        {

            try
            {
                GuardarDetalle();
            }
            catch(Exception et)
            {
                MessageBox.Show("Ingrese el valor a pagar");
            }
        }


        private void contarcliente()
        {

           // LblIdPagoFinalizar.Text = ObjetoAsignarClienteC.meme(Convert.ToInt32(LblIdRegistro.Text), LblIdPagoFinalizar.Text);
        }


        NpgsqlDataAdapter DA;
        DataTable DT;
        DataRow DR;
        private string consulta;
        private M_Conexion conexion = new M_Conexion();
        public void Grafico()
        {
            //consulta = "select * from log_login";
            //DA = new NpgsqlDataAdapter(consulta, conexion.AbrirConexion());
            //DT = new DataTable();
            //DA.Fill(DT);
            //chartGrafico.Palette = ChartColorPalette.SeaGreen;
            //chartGrafico.Titles.Add("Nombresss");
            //if (DT.Rows.Count > 0)
            //{
            //    for (int i = 0; i < DT.Rows.Count; i++)
            //    {
            //        DR = DT.Rows[i];
            //        Series series = chartGrafico.Series.Add(DR.ItemArray[1].ToString());
            //        series.Points.Add(Convert.ToDouble(DR.ItemArray[3]));
            //    }
            //}
        }

        public void PasarTextbox(int textoM)
        {
            conexion.AbrirConexion();
            string query = "SELECT SUM(valorpagado) as g FROM ins_detregistro WHERE idregistro = " + textoM + "";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion.AbrirConexion());
            NpgsqlDataReader rd = cmd.ExecuteReader();
          
            if (rd.Read() == true)
            {
                LblTotalpagadoFinalizar.Text = rd["g"].ToString();
            }
            conexion.CerrarConexion();
          //  return "Null";

        }

        private void button5_Click(object sender, EventArgs e)
        {
        //    this.LblIdPagoFinalizar.Text = LblIdRegistro.Text;

        //    TabPanelPrincipal.SelectedTab = TabPanelActualizarValorPago;
        //    PasarTextbox(Convert.ToInt32(this.LblIdPagoFinalizar.Text));

           

        }

      

        private void button8_Click(object sender, EventArgs e)
        {
           // TabPanelPrincipal.SelectedTab = TabPagePagar;
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // LblIdPagoFinalizar.Text = LblIdRegistro.Text;
            LblIdpagounicoo.Text = LblIdRegistro.Text;
            PasarTextbox(Convert.ToInt32(LblIdpagounicoo.Text));
            TabPanelPrincipal.SelectedTab = TabPanelActualizarValorPago;


            //double costo = Convert.ToDouble(TablaInscripcion.CurrentRow.Cells[4].Value);
            //double pagado = Convert.ToDouble(TablaInscripcion.CurrentRow.Cells[7].Value);
            //double resul = costo - pagado;
            //MessageBox.Show("Debe cancel la cantidad de : " + resul);


        }

        private void BtnBuscarConId_Click(object sender, EventArgs e)
        {
            BusquedaBoton(TxtBuscarConBoton.Text);
        }

        private void TablaInscripcion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.TablaInscripcion.Columns[e.ColumnIndex].Name == "Column8")
            {
                if(Convert.ToDouble(e.Value) < 300)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }
    }
}
