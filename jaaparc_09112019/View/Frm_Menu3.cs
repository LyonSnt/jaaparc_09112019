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
    public partial class Frm_Menu3 : Form
    {
        private bool EsColapzado;
        public Frm_Menu3()
        {
            InitializeComponent();
            //ColapzarRegistro.Start();
        }

        private void ColapzarRegistro_Tick(object sender, EventArgs e)
        {
            if (EsColapzado)
            {
                PanelSubDashboard.Height += 10;
                if (PanelSubDashboard.Size == PanelSubDashboard.MaximumSize)
                {
                    ColapzarRegistro.Stop();
                    EsColapzado = false;
                }
            }
            else
            {
                PanelSubDashboard.Height -= 10;
                if(PanelSubDashboard.Size == PanelSubDashboard.MinimumSize)
                {
                    ColapzarRegistro.Stop();
                    EsColapzado = true;
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ColapzarRegistro.Start();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            Form12 b = new Form12();
            b.Show();
           // openChildForm(new Frm_Load_TDS());
            //hideSubMenu();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}
