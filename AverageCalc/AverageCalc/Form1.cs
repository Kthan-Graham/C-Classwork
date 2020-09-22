using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            float g1, g2, g3, g4, g5, total, Avg;
            g1 = float.Parse(Grade1.Text);
            g2 = float.Parse(Grade2.Text);
            g3 = float.Parse(Grade3.Text);
            g4 = float.Parse(Grade4.Text);
            g5 = float.Parse(Grade5.Text);
            total = g1 + g2 + g3 + g4 + g5;
            Avg = total / 5;
            String.Format("{0:0.00}", Avg);
            Results.Text = "" + Avg;
        }
    }
}
