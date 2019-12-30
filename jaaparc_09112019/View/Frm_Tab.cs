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
    public partial class Frm_Tab : Form
    {
        public Frm_Tab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // TabControl1.SelectedTab = tabPage2;

            tabControl1.SelectedTab = tabPage2;
        }
    }
}
