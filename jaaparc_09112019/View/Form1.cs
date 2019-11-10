using Controller;
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
    public partial class Form1 : Form
    {
        C_Comunidad objetoC = new C_Comunidad();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarComunidad();
        }

        public void MostrarComunidad()
        {
            tablaresul.DataSource = objetoC.MostarC();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                objetoC.InsertarC(27,txtComu.Text);
                MessageBox.Show("regisrro correcto");
                MostrarComunidad();
            }catch(Exception ex)
            {
                MessageBox.Show("no se pudo por :" +ex);
            }

            
        }
    }
}
