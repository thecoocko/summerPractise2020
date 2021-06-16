/*1*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Task61
{
    public partial class Task1 : Form
    {
        public Task1(){InitializeComponent();}
        public const double  e1 = 0.001;
        private void pictureBox5_Click(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            if (x < 0.1 || x > 1) { MessageBox.Show("Выход за границы"); }
            else
            {
                int count = 0;
                double sum = 1,
                a = 1;
                for (int i = 1; Math.Abs(a *= (x * Math.Log(3)) / i) >= e1; i++)
                {
                    sum += a;
                    count++;
                }
                double func = Math.Pow(3, x);
                double deviation = func - sum;
                label9.Text = sum.ToString();
                label10.Text = func.ToString();
                label11.Text = deviation.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}     
    }
}
