using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPT1_18_Huynh_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);

            string ketqua = GiaiPT_18_Huynh.GiaiPT1(a, b);
            txtKQ.Text = ketqua;
        }

        private void btnPT2_18_Huynh_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            string ketqua = GiaiPT_18_Huynh.GiaiPT2(a, b, c);
            txtKQ.Text = ketqua;

        }

        private void btnRS_18_Huynh_Click(object sender, EventArgs e)
        {

        }
    }
}
