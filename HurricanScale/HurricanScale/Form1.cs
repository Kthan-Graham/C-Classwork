using System;
using System.Windows.Forms;

namespace HurricanScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void windSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            int Ws, input;
            Ws = 0;
            input = 0;
            Ws = Convert.ToInt32(windSpeed.Text);

            if (Ws >= 157)
            {
                input = 5;
                Output.Text = "Category " + input + ".";
            }
            else if (Ws >= 130)
            {
                input = 4;
                Output.Text = "Category " + input + ".";
            }
            else if (Ws >= 111)
            {
                input = 3;
                Output.Text = "Category " + input + ".";
            }
            else if (Ws >= 96)
            {
                input = 2;
                Output.Text = "Category " + input + ".";
            }
            else if (Ws >= 74)
            {
                input = 1;
                Output.Text = "Category " + input + ".";
            }
            else if (Ws >= -1)
            {
                Output.Text = "With this Wind Speed this is not considered a Hurrican.";
            }

            notificationText 
        }
    }
}

