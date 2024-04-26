using CompMathLab6.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompMathLab6
{
    public partial class Form1 : Form
    {
        private FuncXY _func = new FuncXY();
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(double x, double y,double xMax, IDiffEquationMethod method,int seriesIndex)
        {
            chart1.Series[seriesIndex].Points.Clear();
            chart1.Series[seriesIndex].Points.AddXY(x, y);
            while (xMax >= x)
            {
                y = method.UseMethod(x, y);
                x += method.Step;
                chart1.Series[seriesIndex].Points.AddXY(x, y);
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            ResizeChart();
            switch (comboBoxMethods.SelectedIndex)
            {
                case 0:
                    Draw((double)numericUpDownX0.Value, (double)numericUpDownY0.Value, (double)numericUpDownXn.Value,
                        new EulerDiffEquation((double)numericUpDownStep.Value, _func), 0);
                    break;
                case 1:
                    Draw((double)numericUpDownX0.Value, (double)numericUpDownY0.Value, (double)numericUpDownXn.Value,
                        new UpgradeEulerDiffEquation((double)numericUpDownStep.Value, _func), 1);
                    break;
                case 2:
                    Draw((double)numericUpDownX0.Value, (double)numericUpDownY0.Value, (double)numericUpDownXn.Value,
                        new RungeKuttyMersonDiffEquation((double)numericUpDownStep.Value, _func, (double)numericUpDownAccuracy.Value), 2);
                    break;
                case 3:
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach(var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void comboBoxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMethods.SelectedIndex == 2)
            {
                labelAccuracy.Visible = true;
                numericUpDownAccuracy.Visible = true;
            }
            else
            {
                labelAccuracy.Visible = false;
                numericUpDownAccuracy.Visible = false;
            }
        }
        private void ResizeChart()
        {
            chart1.ChartAreas[0].Axes[0].Maximum = (double)numericUpDownMaxX.Value;
            chart1.ChartAreas[0].Axes[0].Minimum = (double)numericUpDownMinX.Value;
            chart1.ChartAreas[0].Axes[1].Maximum = (double)numericUpDownMaxY.Value;
            chart1.ChartAreas[0].Axes[1].Minimum = (double)numericUpDownMinY.Value;
        }
    }
}
