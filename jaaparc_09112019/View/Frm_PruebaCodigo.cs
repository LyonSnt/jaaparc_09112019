using Controller;
using Modelo;
using Npgsql;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace View
{
    public partial class Frm_PruebaCodigo : Form
    {
        private Conexion con = new Conexion();
        private M_Conexion conexion = new M_Conexion();
        private M_Metodos metodo = new M_Metodos();
        private C_Dashboard ObjetoDashboardC = new C_Dashboard();

        public Frm_PruebaCodigo()
        {
            InitializeComponent();


            //Grafico();
            //txtBase.Text = ObjetoDashboard.ConsultarDatosDashboardC();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(textBox3.Text);
            DateTime fechaInicial = DateTime.Parse(textBox1.Text);
            DateTime fechaFinal = DateTime.Parse(textBox2.Text);

            int diferencia = (num - fechaInicial.Month) + (12 * (num - fechaInicial.Year));
            MessageBox.Show(Convert.ToString(diferencia));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nume = Convert.ToInt32(textBox1.Text);
            DateTime fech = DateTime.Now;
            for (int ctr = 1; ctr <= nume; ctr++)
       MessageBox.Show(fech.AddMonths(ctr).ToString("d"));
        }

        private void button3_Click(object sender, EventArgs e)
        {


            DateTime d1 = new DateTime(2018, 04, 11);

            DateTime d2 = DateTime.Now;

            TimeSpan ts = d2 - d1;

            DateTime d = DateTime.MinValue + ts;

            int dias = d.Day - 1;

            int meses = d.Month - 1;

            int años = d.Year - 1;
            MessageBox.Show(

                string.Format("Han pasado: {0} años, {1} meses, {2} días",

                años.ToString(), meses.ToString(), dias.ToString()));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime fecharegistro = DateTime.Parse("04/05/2018 8:34:01"); //obtenemos este valor de una bbdd
            var horas = (DateTime.Now - fecharegistro).TotalHours;
            MessageBox.Show(Convert.ToString(horas));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double pagoconex = Convert.ToDouble(textBox4.Text);
            double abono = Convert.ToDouble(textBox5.Text);
            int numcuotas = Convert.ToInt32(textBox3.Text);
            DateTime d = DateTime.Now.AddMonths(numcuotas);
            string fecha = d.ToString("dd/MM/yyyy");

            textBox2.Text = fecha; //ESTAMOS ENVIANDO LA FECHA SEGUN EL NUMERO DE CUATAS AL CAMPO TEXTBOX2
                                   // textBox2.Text= string.Format("{0}-{1}", textBox1.Text, fecha); contatenar dos fecha en el mismo campo
            double saldo = pagoconex - abono;
            double saldores = saldo / numcuotas;
           // double res = Math.Round(saldores, 4);
           double res = metodo.multi(saldores, 4);
            double mulsal = res * 3;
            double total = Math.Ceiling(mulsal);

            MessageBox.Show(Convert.ToString(saldo));
            MessageBox.Show(Convert.ToString(res));
            MessageBox.Show(Convert.ToString(mulsal));
            MessageBox.Show(Convert.ToString(total));

        }

        public void contar()
           
        {

            // int numcuotas = Convert.ToInt32(textBox3.Text);
            
        }
      


        private void Frm_PruebaCodigo_Load(object sender, EventArgs e)
        {
           

            textBox1.Text = DateTime.Now.ToShortDateString();
          

            //  txtBase.Text = ObjetoDashboardC.contador();
            //   Grafico();
            //  garficarvertical();
            contarcliente();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //double value = 0.2544737373;
            //double num = metodo.multi(value, 4);
            //Console.WriteLine(num);

            double value = Math.Round(123.4467, 2); //"123.46"
            MessageBox.Show(Convert.ToString(value));
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string cedula = textBox5.Text;

            if(metodo.VerificaIdentificacion(cedula) == true)
            {
                MessageBox.Show("cedula correcta");
            }
            else
            {
                MessageBox.Show("cedula incorrecta");
            }
           // metodo.VerificaIdentificacion(cedula);

        }
        NpgsqlDataAdapter DA;
        DataTable DT;
        DataRow DR;
        private string consulta;

        public void Grafico()
        {
            consulta = "select * from log_login";
            DA = new NpgsqlDataAdapter(consulta, conexion.AbrirConexion());
            DT = new DataTable();
            DA.Fill(DT);
            chartGrafico.Palette = ChartColorPalette.SeaGreen;
            chartGrafico.Titles.Add("Nombresss");
            if (DT.Rows.Count > 0)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DR = DT.Rows[i];
                    Series series = chartGrafico.Series.Add(DR.ItemArray[1].ToString());
                    series.Points.Add(Convert.ToDouble(DR.ItemArray[3]));
                }
            }
        }

        public void garficarvertical()
        {
            ArrayList Cliente = new ArrayList();
            ArrayList cantidad = new ArrayList();

            //  con.Open();
            string query = "select * from ins_cliente";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion.AbrirConexion());
            NpgsqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                Cliente.Add(rd.GetString(2));
                cantidad.Add(rd.GetInt32(5));
            }

            chartveritval.Series[0].Points.DataBindXY(Cliente,cantidad);
            rd.Close();
            conexion.CerrarConexion();
          
        }
        private void button8_Click(object sender, EventArgs e)
        {

            Grafico();
           
        }

        private void contarcliente()
        {

           lblTotalcliente.Text=  ObjetoDashboardC.contador();
        }


        public void numcutos()
        {
            int numcuotas = Convert.ToInt32(textBox3.Text);
            DateTime d = DateTime.Now.AddMonths(numcuotas);
            string fecha = d.ToString("dd/MM/yyyy");
            textBox2.Text = fecha;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int numcuotas = Convert.ToInt32(textBox3.Text);
            DateTime d = DateTime.Now.AddMonths(numcuotas);
            string fecha = d.ToString("dd/MM/yyyy");
            textBox2.Text = fecha;
        }

        private void num(object sender, EventArgs e)
        {
            //try
            //{
            //    int numcuotas = Convert.ToInt32(textBox3.Text);
            //    DateTime d = DateTime.Now.AddMonths(numcuotas);
            //    string fecha = d.ToString("dd/MM/yyyy");
            //    textBox2.Text = fecha;
            //}catch(Exception ec)
            //{
            //    // throw ec;

            //    MessageBox.Show("no puede ser acio");
            //}
        }

        private void numerocam(object sender, KeyEventArgs e)
        {

            try
            {
                int numcuotas = Convert.ToInt32(textBox3.Text);

                if(numcuotas != 0)
                {
                    DateTime d = DateTime.Now.AddMonths(numcuotas);
                    string fecha = d.ToString("dd/MM/yyyy");
                    textBox2.Text = fecha;
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

        private void numrroo(object sender, KeyEventArgs e)
        {
           
        }

        private void mm(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
