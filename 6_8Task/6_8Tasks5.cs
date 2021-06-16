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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task7 newForm7 = new Task7();
            newForm7.ShowDialog();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task8 newForm8 = new Task8();
            newForm8.ShowDialog();
        }
    }
}
