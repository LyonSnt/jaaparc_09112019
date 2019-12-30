using Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class Form12 : Form
    {
      
        public Form12()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  MostrarComunidad();
        }

        public void MostrarComunidad()
        {
          //  C_Comunidad objetoCActualizar = new C_Comunidad(); //ESTO ES PARA QUE ACTUALICE LOS REGISTROS EN EL DATA GRID...SI QUITAMPS ESTO LOS DATOS SE REFLEJAN DUPLICADOS
            //tablaresul.DataSource = objetoCActualizar.MostarC();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }

        public void LimpiarCaja()
        {
           // txtComu.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void tablaresul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }


 
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
