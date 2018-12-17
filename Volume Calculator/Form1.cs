using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                double UserInput = double.Parse(textBox1.Text);
                double Answer = 4.0 / 3.0 * Math.PI * UserInput * UserInput * UserInput;
                label7.Text = Answer.ToString();

            }

            catch
            {
                MessageBox.Show("Enter an integer please.");
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                double UserInput2 = double.Parse(textBox2.Text);
                double Answer2 = UserInput2 * UserInput2 * UserInput2;
                label10.Text = Answer2.ToString();

            }

            catch
            {
                MessageBox.Show("Enter an integer please.");
            }

        }
    }
}
