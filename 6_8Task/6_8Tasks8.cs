using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task61
{
    public partial class Task8 : Form
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { 
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double strt=0, ed=3, stp=0.1, x;               
                    x = strt;
                    while (x <= ed)
                    {
                        double y = (Math.Pow(x, 3)) / (1 + x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }         
            }
            if (radioButton2.Checked == true)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;               
                    x = strt+stp;
                    while (x <= ed)
                    {
                        double y = 1/(x*Math.Sqrt(1+x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }                
            }
            if (radioButton3.Checked == true)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;              
                    x = strt+stp;
                    while (x <= ed)
                    {
                        double y =(1-Math.Sin(x))/x;
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }
            }
            if (radioButton4.Checked == true)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;
                    x = strt + stp;
                    while (x <= ed)
                    {
                        double y = Math.Exp(-(1-x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }
            }
            if (radioButton5.Checked == true)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;
                    x = strt + stp;
                    while (x <= ed)
                    {
                        double y = 1/Math.Pow(Math.Sinh(x),2);
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }
            }
            if (radioButton6.Checked == true)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;
                    x = strt+stp;
                    while (x <= ed)
                    {
                        double y = 1/(x*Math.Log10((1+x)/x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }
            }
            if (radioButton7.Checked == true)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;
                    x = strt;
                    while (x <= ed)
                    {
                        double y = Math.Sinh(Math.Sin(x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x = x + stp;
                    }                
            }
            if (radioButton8.Checked == true)
            {               
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Series series1 = new Series("series1");
                chart1.Series.Add(series1);
                chart1.Series[1].Points.Clear();
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Series series2 = new Series("series2");
                chart1.Series.Add(series2);
                chart1.Series[2].Points.Clear();
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Series series3 = new Series("series3");
                chart1.Series.Add(series3);
                chart1.Series[3].Points.Clear();
                chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Series series4 = new Series("series4");
                chart1.Series.Add(series4);
                chart1.Series[4].Points.Clear();
                chart1.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Series series5 = new Series("series5");
                chart1.Series.Add(series5);
                chart1.Series[5].Points.Clear();
                chart1.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Series series6 = new Series("series6");
                chart1.Series.Add(series6);
		   chart1.Series[6].Points.Clear();
                chart1.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                double strt = 0, ed = 3, stp = 0.1, x;              
                    x = strt+stp;
                    while (x <= ed)
                    {
                    double y = 1 / (x * Math.Sqrt(1 + x));
                    double y2 = 1 / ((x + stp) * Math.Sqrt(1 + (x + stp)));
                    double y3 = (1 - Math.Sin((x + stp))) / (x + stp);
                    double y4 = Math.Exp(-(1 - (x + stp)));
                    double y5 = 1 / Math.Pow(Math.Sinh((x + stp)), 2);
                    double y6 = 1 / (x * Math.Log10((1 + (x + stp)) / (x + stp)));
                    double y7 = Math.Sinh(Math.Sin(x));
                    chart1.Series[0].Points.AddXY(x, y);
                    chart1.Series[1].Points.AddXY(x, y);
                    chart1.Series[2].Points.AddXY(x, y);
                    chart1.Series[3].Points.AddXY(x, y);
                    chart1.Series[4].Points.AddXY(x, y);
                    chart1.Series[5].Points.AddXY(x, y);
			chart1.Series[6].Points.AddXY(x, y);
                    x = x + stp;
                    }               
            }
        }
        private void button1_Click(object sender, EventArgs e){this.Close();}
        private void radioButton8_CheckedChanged(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}
    }
}
