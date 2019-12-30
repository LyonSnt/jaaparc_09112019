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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            PanelSubMenu();
        }

        public void PanelSubMenu()
        {
            PanelSubRegistrar.Visible = false;
            PanelSubPagos.Visible = false;
        }

        public void OcularSubMenu()
        {
            if (PanelSubRegistrar.Visible == true)
            {
                PanelSubRegistrar.Visible = false;
            }if (PanelSubPagos.Visible == true)
            {
                PanelSubPagos.Visible = false;
            }
        }

        public void VisualizarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcularSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form ActivarFormulario = null;

        private void abrirFormulario(Form formularioHijo)
        {
            if (ActivarFormulario != null)
                ActivarFormulario.Close();
                ActivarFormulario = formularioHijo;
                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formularioHijo);
                PanelContenedor.Tag = formularioHijo;
                formularioHijo.BringToFront();
                formularioHijo.Show();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            VisualizarSubMenu(PanelSubRegistrar);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            abrirFormulario(new Frm_Clientes());
            OcularSubMenu();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Frm_Medidores());
            OcularSubMenu();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Frm_Dashboard());
            OcularSubMenu();
        }

        private void BtnSlider_Click(object sender, EventArgs e)
        {
            if(PanelLateralPrincipal.Width == 200)
            {
                PanelLateralPrincipal.Width = 50;
            }
            else
            {
                PanelLateralPrincipal.Width = 200;
            }
        }

        private void bBtnPagos_Click(object sender, EventArgs e)
        {
            VisualizarSubMenu(PanelSubPagos);
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Frm_PagarConexion());
            OcularSubMenu();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Frm_Emision());
            OcularSubMenu();
        }
    }
}
