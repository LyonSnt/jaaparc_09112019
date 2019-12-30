using Controller;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class Frm_Medidores : Form
    {

       private  C_Medidor objetoC = new C_Medidor();
       // private C_Medidor ObjetoMedidorC = new C_Medidor();
        private int opcion = 0;
        private string idmedidor = null;

        private NpgsqlTransaction transaction;

        public Frm_Medidores()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           try
           {
                Guardar();
            }
           catch(Exception ex)
            {
              MessageBox.Show("no se pudoo po:");
               
            } 

        }

        private void LimpiarCampos()
        {
            txtnumero.Clear();
            txtlecturaactual.Text = "";
            txtmarca.Clear();
        }

        public void CargarComboxMedidor()
        {
            ComboxMedidor.DataSource = objetoC.ConsultarComboxMedidorC();
            ComboxMedidor.DisplayMember = "numero";
            ComboxMedidor.ValueMember = "estado";


        }

        

        private void Frm_Medidores_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            CargarComboxMedidor();
           
        }

       

        public void CargarGrilla()
        {
            DataSet ds = new DataSet();
            ds = objetoC.ConsultarDatosC();
            if(ds.Tables[0].Rows.Count > 0)
            {
                TablaMedidor.RowCount = ds.Tables[0].Rows.Count;
                for(int i = 0; i < TablaMedidor.RowCount; i++)
                {
                    TablaMedidor.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    TablaMedidor.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    TablaMedidor.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    TablaMedidor.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    TablaMedidor.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    TablaMedidor.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                }
            }
        }

        private void horaTicker_Tick(object sender, EventArgs e)
        {
           // bunifuCustomLabel5.Text = DateTime.Now.ToLongDateString();
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            //bunifuCustomLabel6.Text = DateTime.Now.ToShortDateString();
           // txtfecha.Text = DateTime.Now.ToShortDateString();
        }

       
        public bool ValidarDatos()
        {
                if (opcion == 1)
                {

                    DateTime fechaa = DateTime.Now;
                    objetoC = new C_Medidor(txtnumero.Text, txtlecturaactual.Text, txtmarca.Text, fechaa);
                    return true;


                }
                else if (opcion == 2)
                {

                // objetoC = new C_Medidor(numero, txtmarca.Text);
                string seleccion = ComboxMedidor.SelectedValue.ToString();

              //  datos.Id_Tabla1 = GUID.Parse(seleccion);

                objetoC = new C_Medidor("OC", idmedidor);


                    return true;

                }
                else
                {
                    objetoC = new C_Medidor(txtnumero.Text);
                    return true;

                }
           
        }

        public void Guardar()
        {   opcion = 1;
            if (ValidarDatos() == true)
            {
                objetoC.InsertarC();
                MessageBox.Show("Registro correctamente");
                LimpiarCampos();
                CargarGrilla();
            }
            else {
                MessageBox.Show("nos e pieee");

            }
           
        }

        public void Modificar()
        {
            opcion = 2;
            if (ValidarDatos() == true)
            {
                objetoC.ModificarC();
                MessageBox.Show("Datos Actualizados");
                LimpiarCampos();
                CargarGrilla();
            }
        }

        public void Eliminar()
        {
            opcion = 3;
            if (ValidarDatos() == true)
            {
                objetoC.EliminarC();
                MessageBox.Show("Datos Eliminados");
                LimpiarCampos();
                CargarGrilla();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Busqueda(string texto)
        {
            DataTable table = new DataTable();
            table = objetoC.BuscarC(texto);
            if(table.Rows.Count > 0)
            {
                TablaMedidor.Rows.Clear();
                TablaMedidor.RowCount = table.Rows.Count;
                for(int i=0; i < table.Rows.Count; i++)
                {
                    TablaMedidor[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    TablaMedidor[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    TablaMedidor[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    TablaMedidor[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    TablaMedidor[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    TablaMedidor[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Busqueda(txtBuscar.Text);
        }

        private void TablaMedidor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //idmedidor = TablaMedidor.CurrentRow.Cells[0].Value.ToString(); es lo mismo que el de abajo
            idmedidor = Convert.ToString(TablaMedidor.CurrentRow.Cells[0].Value); //estamos guardando en una variable idmedidor
            //para poder actualizar , debido a que el id medidor no se encuentra en el formulario
            txtnumero.Text = Convert.ToString(TablaMedidor.CurrentRow.Cells[1].Value);
            txtlecturaactual.Text = Convert.ToString(TablaMedidor.CurrentRow.Cells[2].Value);
            txtmarca.Text = Convert.ToString(TablaMedidor.CurrentRow.Cells[3].Value);
        }

        private void TablaMedidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
