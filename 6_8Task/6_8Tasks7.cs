using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task61
{
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = false;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt;
                while (x <= ed)
                {
                    double y = (Math.Pow(x, 3)) / (1 + x);
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }                
            }
            if (radioButton2.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = false;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt + stp;
                while (x <= ed)
                {
                    double y = 1 / (x * Math.Sqrt(1 + x));
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }
            }
            if (radioButton3.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = true;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt + stp;
                while (x <= ed)
                {
                    double y = (1 - Math.Sin(x)) / x;
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }
                double y1 = (1 - Math.Sin(Math.PI/3)) / Math.PI/3;
                double y2 = (1 - Math.Sin(Math.PI/4)) / Math.PI/4;
                double y3 = (1 - Math.Sin((2*Math.PI)/3)) / (2*Math.PI)/3;
                double y4 = (1 - Math.Sin(Math.PI)) / Math.PI;
                label2.Text = Convert.ToString(y1);
                label3.Text = Convert.ToString(y2);
                label4.Text = Convert.ToString(y3);
                label5.Text = Convert.ToString(y4);

            }
            if (radioButton4.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = false;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt + stp;
                while (x <= ed)
                {
                    double y = Math.Exp(-(1 - x));
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }
            }
            if (radioButton5.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = true;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt + stp;
                while (x <= ed)
                {
                    double y = 1 / Math.Pow(Math.Sinh(x), 2);
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }
                double y1 = 1 / Math.Pow(Math.Sinh(Math.PI/3), 2);
                double y2 = 1 / Math.Pow(Math.Sinh(Math.PI / 4), 2);
                double y3 = 1 / Math.Pow(Math.Sinh((2 * Math.PI) / 3), 2);
                double y4 = 1 / Math.Pow(Math.Sinh(Math.PI) , 2);
                label2.Text = Convert.ToString(y1);
                label3.Text = Convert.ToString(y2);
                label4.Text = Convert.ToString(y3);
                label5.Text = Convert.ToString(y4);
            }
            if (radioButton6.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = false;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt + stp;
                while (x <= ed)
                {
                    double y = 1 / (x * Math.Log10((1 + x) / x));
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }
            }
            if (radioButton7.Checked == true)
            {
                dataGridView1.Rows.Clear();
                groupBox2.Visible = true;
                double strt = 0, ed = 3, stp = 0.1, x;
                int i = 0;
                x = strt;
                while (x <= ed)
                {
                    double y = Math.Sinh(Math.Sin(x));
                    dataGridView1.Rows.Add();
                    dataGridView1.Columns.Add("column" + i, " " + i);
                    dataGridView1.Rows[i].Cells[0].Value = x.ToString();
                    dataGridView1[1, i].Value = y.ToString();
                    x = x + stp;
                    i++;
                }
                double y1 = Math.Sinh(Math.Sin(Math.PI / 3));
                double y2 = Math.Sinh(Math.Sin(Math.PI / 4));
                double y3 = Math.Sinh(Math.Sin((2 * Math.PI) / 3));
                double y4 = Math.Sinh(Math.Sin(Math.PI));
                label2.Text = Convert.ToString(y1);
                label3.Text = Convert.ToString(y2);
                label4.Text = Convert.ToString(y3);
                label5.Text = Convert.ToString(y4);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void radioButton1_CheckedChanged(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e){this.Close();}
        private void Task7_Load(object sender, EventArgs e){}
        private void pictureBox7_Click(object sender, EventArgs e){}
        private void pictureBox4_Click(object sender, EventArgs e){}
        private void groupBox2_Enter(object sender, EventArgs e){}
    }
}
