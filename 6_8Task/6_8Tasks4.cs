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
using System.IO;
using System.Runtime.CompilerServices;

namespace Task61
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0, product = 1, sumOfSquares = 0, 
                   lastNum=0,squaresOfProduct=0, moduleOfSum=0;                   
            string filename = textBox1.Text;
            FileStream file_1 = new FileStream(filename, FileMode.Create);
            StreamWriter writer = new StreamWriter(file_1);
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(-10,10);
                writer.WriteLine(x);
            }
            writer.Close();
            FileStream file_2 = new FileStream(filename, FileMode.Open);
            StreamReader reader = new StreamReader(file_2);
            for (int i = 0; i < 10; i++)
            {
                string temp = reader.ReadLine();
                double y = Convert.ToDouble(temp);
                sum+= y;
                product *= y;
                sumOfSquares += Math.Pow(y, 2);
                moduleOfSum =Math.Abs(sum);
                squaresOfProduct =Math.Pow(product,2);
                if (i == 9)
                {
                    lastNum = y;
                }
            }
            label3.Text = "Сумма: "+Convert.ToString(sum)+"\n";
            label4.Text = "Произведение: " + Convert.ToString(product) + "\n";
            label5.Text = "Сумма квадратов: " + Convert.ToString(sumOfSquares) + "\n";
            label6.Text = "Модуль суммы и квадрат произведения: " + Convert.ToString(moduleOfSum) +"  "+Convert.ToString(squaresOfProduct)+ "\n";
            label7.Text = "Последний элемент: " + Convert.ToString(lastNum) + "\n";

            reader.Close();
        }
    }
}
