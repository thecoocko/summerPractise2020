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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 newForm = new Task1();
            newForm.ShowDialog(); 
        }  
        private void button2_Click(object sender, EventArgs e)
        {
            Task2 newForm2 = new Task2();
            newForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 newForm3 = new Task3();
            newForm3.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Task4 newForm4 = new Task4();
            newForm4.ShowDialog();
        } 
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Task5 newForm5 = new Task5();
            newForm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task7 newForm6 = new Task7();
            newForm6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Task7 newForm7 = new Task7();
            newForm7.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Task8 newForm8 = new Task8();
            newForm8.ShowDialog();
        }
    }
}
