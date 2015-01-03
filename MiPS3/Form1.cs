using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meta.Numerics.Statistics.Distributions;

namespace MiPS3
{
    public partial class Form1 : Form
    {
        double[,] arr;
        double[] breaktime;
        double[] NA;
        ExponentialDistribution ED;
        int m, n;
        Random RNG = new Random();
        double over; // Full break

        public Form1()
        {
            InitializeComponent();
        }

        private void Modules_ValueChanged(object sender, EventArgs e)
        {
            MaxBroken.Maximum = Modules.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = (int)Modules.Value;
            n = (int)Functions.Value;

            arr = new double[m, n];
            breaktime = new double[m];
            NA = new double[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    ED = new ExponentialDistribution(Convert.ToDouble(textBox1.Lines[i]));
                }
                catch (Exception ex)
                {
                    ED = new ExponentialDistribution();
                }

                for (int j = 0; j < m; j++)
                {
                    arr[j, i] = ED.GetRandomValue(RNG);
                    if (NA[i] < arr[j, i])
                        NA[i] = arr[j, i];
                    if (breaktime[j] < arr[j, i])
                        breaktime[j] = arr[j, i];
                }
            }

            over = NA.Min();
        }
    }
}
