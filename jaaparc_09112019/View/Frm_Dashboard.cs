using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
          //  label1.Text = DateTime.Now.ToLongDateString();

            // bunifuCustomLabel5.Text = DateTime.Now.ToLongDateString();
           // LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            //bunifuCustomLabel6.Text = DateTime.Now.ToShortDateString();
            // txtfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = DateTime.Now.ToLongDateString();
        }
    }
}
