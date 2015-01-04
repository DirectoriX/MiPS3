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
        List<double> breaktime;
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
            MaxBroken.Maximum = Modules.Value - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = (int)Modules.Value;
            n = (int)Functions.Value;
            int mods = (int)Models.Value;

            List<double>[] breaktime = new List<double>[mods];

            double[] badservice = new double[mods];
            double avgbadservice = 0;

            for (int z = 0; z < mods; z++)
            {

                arr = new double[m, n];
                breaktime[z] = new List<double>();
                NA = new double[n];

                for (int i = 0; i < m; i++)
                    breaktime[z].Add(0);

                for (int i = 0; i < n; i++) // Filling
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
                        if (breaktime[z][j] < arr[j, i])
                            breaktime[z][j] = arr[j, i];
                    }
                }

                for (int i = 0; i < m; i++)
                    breaktime[z].Sort();

                avgbadservice += (badservice[z] = breaktime[z][(int)MaxBroken.Value]) / mods;

            }

            double sum = 0;
            for (int i = 0; i < mods; i++)
            {
                sum += Math.Pow((avgbadservice - badservice[i]), 2);
            }

            StudentDistribution st = new StudentDistribution(mods - 1);

            double pogr = st.InverseLeftProbability(1 - (double)Stud.Value / 200.0) * Math.Sqrt(sum / (mods - 1)) / Math.Sqrt(mods);

            this.Text = avgbadservice.ToString() + "±" + pogr.ToString();
        }
    }
}
