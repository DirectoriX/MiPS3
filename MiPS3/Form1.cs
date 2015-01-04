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
            over = 0;
            m = (int)Modules.Value;
            n = (int)Functions.Value;
            int mods = (int)Models.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

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

            for (int i = 0; i < mods; i++)
            {
                if (over < breaktime[i][m - 1])
                    over = breaktime[i][m - 1];
            }

            StudentDistribution st = new StudentDistribution(mods - 1);

            double pogr = st.InverseLeftProbability(1 - (double)Stud.Value / 200.0) * Math.Sqrt(sum / (mods - 1)) / Math.Sqrt(mods);

            ResLabel.Text = "Средняя наработка:\n"+avgbadservice.ToString() + "±" + pogr.ToString();

            double K;
            double P;
            double[] pm=new double[mods];
            double avgpm;

            for (double x = 0; x <= over/3; x += over / 300)
            {
                K=0;
                avgpm=0;
                for (int i = m-(int)MaxBroken.Value; i <= m; i++)
                {
                    P = 0;
                    for (int k = 0; k < mods; k++)
                    {
                        if (breaktime[k][m - i] > x)
                        {
                            P += 1.0 / mods;
                            pm[k] = (breaktime[k][m - i] - x) / (double)MaxBroken.Value;
                            avgpm += (1.0 * (breaktime[k][m - i] - x) / mods) / (double)MaxBroken.Value;
                        }
                    }
                    K += 1.0 * P * i / m;
                }

                double abasum = 0;

                for (int i = 0; i < mods; i++)
                {
                    abasum += Math.Pow((avgpm - pm[i]), 2);
                }

                pogr = st.InverseLeftProbability(1 - (double)Stud.Value / 200.0) * Math.Sqrt(abasum / (mods - 1)) / Math.Sqrt(mods);

                chart1.Series[0].Points.AddXY(x, K+pogr, K-pogr);
                chart1.Series[1].Points.AddXY(x, K);
            }
        }
    }
}
