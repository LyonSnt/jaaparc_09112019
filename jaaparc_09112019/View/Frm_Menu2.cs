using Common.Cache;
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
    public partial class Frm_Menu2 : Form
    {
        public Frm_Menu2()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere cerra?", "Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        public void LoadUserData()
        {
            lblUsuario.Text = UserLoginCache.Nombre;
        }

        private void btnComunidad_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
        }
    }
}
