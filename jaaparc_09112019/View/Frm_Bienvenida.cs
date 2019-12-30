using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace View
{
    public partial class Frm_Bienvenida : Form
    {
        public Frm_Bienvenida()
        {
            InitializeComponent();
        }
      //  int cont = 0;

        private void TimeInicio_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            barraCircular.Value += 1;
            barraCircular.Text = barraCircular.Value.ToString();
            if (barraCircular.Value == 100)
            {
                TimeInicio.Stop();
                TimeFin.Start();
            }
        }

        private void TimeFin_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                TimeFin.Stop();
                this.Close();
            }
        }

        private void Frm_Bienvenida_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UserLoginCache.Nombre + "," + UserLoginCache.Email;
            this.Opacity = 0.0;
            barraCircular.Value = 0;
            barraCircular.Minimum = 0;
            barraCircular.Maximum = 100;
            TimeInicio.Start();

        }
    }
}
