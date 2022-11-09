using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_sistema_etec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            double n1, n2, mf;

            n1=double.Parse(txt_v1.Text);
            n2 = double.Parse(txt_v2.Text);

            mf = (n1 + n2) / 2;

            lbl_mf.Text = mf.ToString();
        }
    }
}
