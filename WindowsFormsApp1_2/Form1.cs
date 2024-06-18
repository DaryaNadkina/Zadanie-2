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

namespace WindowsFormsApp1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            double angle = Convert.ToDouble(angleTB.Text) * Math.PI / 180;
            double v = Convert.ToDouble(velocityTB.Text);
           double dt = Convert.ToDouble(stepTB.Text);
            double vx = v * Math.Cos(angle);
            double vy = v * Math.Sin(angle);
            double x1 = 0, y1 = 0;
            double g = 9.8, dx = 0.01, y = 0;
            Series series1 = new Series();
            Series series2 = new Series();
            double L = v * v / g * Math.Sin(2 * angle);
            for (double x = 0; x <= L; x += dx)
            {
                y = x * Math.Tan(angle) - x * x * g / (2 * v * v * Math.Cos(angle) * Math.Cos(angle));
                series2.Points.AddXY(x, y);
            }
            do
            {
                series1.Points.AddXY(x1, y1);
                vy = -dt * g + vy;
                x1 = x1 + dt * vx;
                y1 = y1 + dt * vy;
            }
            while (y1 > 0);
            y = L * Math.Tan(angle) - L * L * g / (2 * v * v * Math.Cos(angle) * Math.Cos(angle));
            series2.Points.AddXY(L, y);


            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

            series1.ChartType = SeriesChartType.Spline;
            series2.ChartType = SeriesChartType.Spline;

            chart1.Series[0].LegendText = "Численно";
            chart1.Series[1].LegendText = "Аналитически";

            l1.Text = "Дальность полета численным методом: " + Math.Round(Convert.ToDouble(x1), 3);
            l2.Text = "Дальность полета формулой: " + Math.Round(Convert.ToDouble(L), 3);

        }

        private void stepTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }
    }
}
