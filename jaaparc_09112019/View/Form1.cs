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

        private string idComunidad = null;
        private bool editar = false;

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
            C_Comunidad objetoCActualizar = new C_Comunidad(); //ESTO ES PARA QUE ACTUALICE LOS REGISTROS EN EL DATA GRID...SI QUITAMPS ESTO LOS DATOS SE REFLEJAN DUPLICADOS
            tablaresul.DataSource = objetoCActualizar.MostarC();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (editar == false)
            {
                try
                {
                    objetoC.InsertarC(txtComu.Text);
                    MessageBox.Show("regisrro correcto");
                    MostrarComunidad();
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo por :" + ex);
                }
            }
            //EDITAR
            if (editar == true)
            {
                try
                {
                    objetoC.ActualizarC(txtComu.Text, idComunidad);
                    MessageBox.Show("se edito correctamente");
                    MostrarComunidad();
                    LimpiarCaja();
                    editar=false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaresul.SelectedRows.Count > 0)
            {
                editar = true;
                txtComu.Text = tablaresul.CurrentRow.Cells["com_nombre"].Value.ToString();
                idComunidad = tablaresul.CurrentRow.Cells["com_id"].Value.ToString();
                lblcomid.Text = tablaresul.CurrentRow.Cells["com_id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila");
            }
        }

        public void LimpiarCaja()
        {
            txtComu.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(tablaresul.SelectedRows.Count > 0)
            {
                idComunidad = tablaresul.CurrentRow.Cells["com_id"].Value.ToString();
                objetoC.EliminarC(idComunidad);
                MessageBox.Show("eliminado correctamente");
                MostrarComunidad();
            }
            else
            {
                MessageBox.Show("selecccione una fila por favor");
            }
        }
    }
}
