using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_top
{           
    public partial class Calculadora : Form
    {
        decimal C = 0;
        decimal A = 0;
        decimal B = 0;
       

        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             A = Convert.ToDecimal(textBox1.Text);
            //decimal B = Convert.ToDecimal(textBox2.Text);
             C = A;
            textBox1.Text = Convert.ToString(A);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             A = Convert.ToDecimal(textBox1.Text);
             B = Convert.ToDecimal(textBox2.Text);
             C = A * B;
            textBox3.Text = Convert.ToString(C);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             A = Convert.ToDecimal(textBox1.Text);
             B = Convert.ToDecimal(textBox2.Text);
             C = A + B;
            textBox3.Text = Convert.ToString(C);
        }

        private void button5_Click(object sender, EventArgs e)
        {
             A = Convert.ToDecimal(textBox1.Text);
             B = Convert.ToDecimal(textBox2.Text);
             C = A - B;
            textBox3.Text = Convert.ToString(C);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
             A = Convert.ToDecimal(textBox1.Text);
             B = Convert.ToDecimal(textBox2.Text);
             C = A / B;
            textBox3.Text = Convert.ToString(C);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int T = Convert.ToInt32(textBox1.Text);
            int R = T;
            textBox3.Text = Convert.ToString(Math.Sqrt(R));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
