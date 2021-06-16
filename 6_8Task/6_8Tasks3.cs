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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }
        private int[] _array;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            _array = new int[10];

            Random rand = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(-20, 20);

                label1.Text += _array[i] + Environment.NewLine;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int temp;

            for (int i = 0; i < _array.Length; i++)
            {
                int minValueIndex = i;

                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[j] < _array[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                temp = _array[i];

                _array[i] = _array[minValueIndex];

                _array[minValueIndex] = temp;

                label2.Text += _array[i] + Environment.NewLine;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
        }
    }
}
