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
    public partial class Task2 : Form
    {
        public Task2(){InitializeComponent();}
        private int[,]_array;
        private int[] _arx;
        private int[] _ary;
        private void button7_Click(object sender, EventArgs e)
        {
            double v = 1, u = 1;
            int a = Convert.ToInt32(textBox1.Text);
            for (int k = 1; k < a; k++) {
			v += _array[k,k] * _ary[k];
		}
		for (int i = 1; i < a; i++) {u += _arx[i] * v;}
		int m = _arx[0];
		for (int i = 0; i < a; i++) {
			if (_arx[i] > m) {m = _arx[i];}
		}
		double b = m * u;
            label14.Text = Convert.ToString(b);           
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text==string.Empty) { MessageBox.Show("Введите значение");}
            else { 
             int a = Convert.ToInt32(textBox1.Text);
             if (a < 0 || a > 6){MessageBox.Show("Выход за границы");}
            }
        }       
        private void button2_Click_1(object sender, EventArgs e)
        { int a = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == string.Empty) { MessageBox.Show("Введите значение"); }
            else
            { if (a == 0)
                { MessageBox.Show("Введите значение"); }
                else { 
                if (radioButton1.Checked)
                {                    
                    _arx = new int[a];
                    Random rand = new Random();
                    for (int i = 0; i < _arx.Length; i++)
                    {
                        _arx[i] = rand.Next(-20, 20);
                        label11.Text += Convert.ToString(_arx[i]) + "  ";
                    }
                }
                else{button10.Visible=true; button8.Visible = true;label4.Visible = true;textBox4.Visible = true;}
            }}
        }
        private void button3_Click_1(object sender, EventArgs e)
        { int a = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == string.Empty) { MessageBox.Show("Введите значение"); }
            else
            {
                if (a == 0)
                { MessageBox.Show("Введите значение"); }
                else
                {
                    if (radioButton4.Checked)
                    {                      
                        _ary = new int[a];
                        Random rand = new Random();
                        for (int i = 0; i < _ary.Length; i++)
                        {
                            _ary[i] = rand.Next(-20, 20);
                            label12.Text += Convert.ToString(_ary[i]) + "  ";
                        }
                    }
                    else { button11.Visible = true; button4.Visible = true; label2.Visible = true; textBox2.Visible = true; }
                }
            }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {int a = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == string.Empty) { MessageBox.Show("Введите значение"); }
            else
            {
                if (a == 0)
                { MessageBox.Show("Введите значение"); }
                else
                {
                    if (radioButton6.Checked)
                    {
                        _array = new int[a, a];
                        Random rand = new Random();
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < a; j++)
                            {
                                _array[i, j] = rand.Next(-20, 20);
                                label13.Text += Convert.ToString(_array[i, j]) + "    ";
                            }
                            label13.Text += "\n";
                        }
                    }
                    else { button12.Visible = true; button5.Visible = true; label3.Visible = true; textBox3.Visible = true; }
                }
            }
        } 
        private void button10_Click(object sender, EventArgs e)//баттон х
        {
            int a = Convert.ToInt32(textBox1.Text);
            string[] sNums = textBox4.Text.Split(' ');
            if (a > sNums.Length){MessageBox.Show("Длина массива не соответсвует введенному!");}
            _arx = new int[a];
            for (int i = 0; i < a; i++){
                _arx[i] = int.Parse(sNums[i]);
                label11.Text += Convert.ToString(sNums[i]) + "  ";
            }

        }
        private void button11_Click(object sender, EventArgs e)//баттон у
        {
            int a = Convert.ToInt32(textBox1.Text);
            string[] sNums = textBox2.Text.Split(' ');
            if (a > sNums.Length) { MessageBox.Show("Длина массива не соответсвует введенному!"); }
            _ary = new int[a];
            for (int i = 0; i < a; i++)
            {
                _ary[i] = int.Parse(sNums[i]);
                label12.Text += Convert.ToString(sNums[i]) + "  ";
            }
        }
        private void button12_Click(object sender, EventArgs e)//матрица а
        {
            int a = Convert.ToInt32(textBox1.Text);
            string[] numbers = textBox3.Text.Split(' ');
            
                if (a*a > numbers.Length) { MessageBox.Show("Длина массива не соответсвует введенному!"); }
            _array = new int[a,a];
            for (int i = 0; i < numbers.Length; i++)
            {

                _array[i / a, i % a] = int.Parse(numbers[i]);
                label13.Text += numbers[i] + "  ";
            }
            label13.Text += "\n";
        }
        private void button6_Click(object sender, EventArgs e){this.Close();}
        private void button8_Click(object sender, EventArgs e){this.textBox4.Clear();}
        private void textBox4_TextChanged(object sender, EventArgs e){}
        private void button4_Click(object sender, EventArgs e){this.textBox2.Clear();}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void button5_Click(object sender, EventArgs e){this.textBox3.Clear();}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void textBox5_TextChanged(object sender, EventArgs e){}

        private void button13_Click(object sender, EventArgs e)
        {
            label11.Text = null;
            label12.Text = null;
            label13.Text = null;
            label14.Text = null;
        }
    }
