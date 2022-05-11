using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;

namespace LR8
{
    public partial class LR8 : Form
    {
        public LR8()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (var series in chartXTk.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chartDt.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chartRtk.Series)
            {
                series.Points.Clear();
            }

            int n = Convert.ToInt32(textBoxN.Text);
            double H = Convert.ToDouble(textBoxH.Text);
            double sigma0 = Convert.ToDouble(textBoxSigma0.Text);
            int sizeArray = (int)(Math.Pow(2, n));

            List<double> arrayTk = new List<double>();
            double[,] arrayX = new double[10000, (sizeArray + 1)];
            double[] arraySigma = new double[(n + 1)];
            double[] arrayKsi = new double[(sizeArray + 1)];
            int counterN = 1;
            int counter = 0;
            arrayTk.Add(0);
            arrayTk.Add(1);
            arraySigma[0] = sigma0;

            for (int i = 0; i < (sizeArray - 2);)
            {
                for (int l = 0; l < (Math.Pow(2, counter)); l++)
                {
                    arrayTk.Add((((2 * l) + 1) / (Math.Pow(2, counterN))));
                    i++;
                }
                counterN++;
                counter++;
            }
            arrayTk.Sort();

            int sizeArrayX = arrayX.GetLength(1) - 2;

            for (int t = 0; t < arrayX.GetLength(0); t++)
            {
                counterN = 1;
                int index = sizeArray;
                int step = sizeArray;
                arrayKsi[0] = Normal.Sample(0, 1);
                arrayX[t, sizeArray] = arrayKsi[0];

                while (counterN <= n)
                {
                    arraySigma[counterN] = (arraySigma[0] / (Math.Pow((Math.Pow(2, counterN)), (2 * H)))) * (1 - (Math.Pow(2, ((2 * H) - 2))));
                    counter = 0;

                    for (int i = 0; i < arrayKsi.Length; i++)
                    {
                        arrayKsi[i] = Normal.Sample(0, Math.Sqrt(arraySigma[counterN]));
                    }

                    index = index / 2;
                    if (index > 1)
                    {
                        step = index;
                    }

                    for (int x = index; x <= sizeArrayX; x += step)
                    {
                        if (arrayX[t, x] == 0)
                        {
                            arrayX[t, x] = (arrayX[t, (x - index)] + arrayX[t, (x + index)]) / 2 + arrayKsi[counter];
                            counter++;
                        }
                    }

                    counterN++;
                }
            }

            List<double> listMTk = new List<double>();
            List<double> listDTk = new List<double>();
            List<double> listTheorDTk = new List<double>();
            List<double> listRTk = new List<double>();
            List<double> listTheorRTk = new List<double>();
            int N = 10000;

            for (int i = 0; i < arrayTk.Count; i++)
            {
                double mTk = 0;
                counterN = 0;
                while(counterN < N)
                {
                    mTk += arrayX[counterN, i];
                    counterN++;
                }
                mTk /= N;
                listMTk.Add(mTk);
            }

            for (int i = 0; i < arrayTk.Count; i++)
            {
                double dTk = 0;
                counterN = 0;
                while (counterN < N)
                {
                    dTk += Math.Pow((arrayX[counterN, i] - listMTk[i]), 2);
                    counterN++;
                }
                dTk /= (N - 1);
                listDTk.Add(dTk);
                listTheorDTk.Add((arraySigma[0] * Math.Pow(arrayTk[i], (2 * H))));
            }

            int limitK = (int)Math.Pow(2, n) - 1;
            double resultRTk;

            int k = 20;

            for (int j = 1; j < (limitK - k); j++)
            {
                resultRTk = 0;
                for (int i = 0; i < N; i++)
                {
                    resultRTk += ((arrayX[i, k + 1] - arrayX[i, k]) * (arrayX[i, k + j + 1] - arrayX[i, k + j]));
                }
                resultRTk /= (N * (listDTk[1]));
                listRTk.Add(resultRTk);
                listTheorRTk.Add((((Math.Pow((j + 1), (2 * H))) - (2 * Math.Pow(j, (2 * H))) + (Math.Pow((j - 1), (2 * H)))) / 2.0));
                k += 1;
            }

            for (int i = 0; i < arrayTk.Count; i++)
            {
                chartXTk.Series[0].Points.AddXY(arrayTk[i], arrayX[0, i]);
                chartXTk.Series[1].Points.AddXY(arrayTk[i], arrayX[1, i]);
                chartXTk.Series[2].Points.AddXY(arrayTk[i], arrayX[2, i]);
                chartXTk.Series[3].Points.AddXY(arrayTk[i], arrayX[3, i]);
                chartXTk.Series[4].Points.AddXY(arrayTk[i], arrayX[4, i]);
                chartXTk.Series[5].Points.AddXY(arrayTk[i], arrayX[5, i]);
                chartXTk.Series[6].Points.AddXY(arrayTk[i], arrayX[6, i]);
                chartXTk.Series[7].Points.AddXY(arrayTk[i], arrayX[7, i]);
                chartXTk.Series[8].Points.AddXY(arrayTk[i], arrayX[8, i]);
                chartXTk.Series[9].Points.AddXY(arrayTk[i], arrayX[9, i]);
                chartDt.Series[0].Points.AddXY(arrayTk[i], listDTk[i]);
                chartDt.Series[1].Points.AddXY(arrayTk[i], listTheorDTk[i]);
            }

            for (int i = 0; i < listTheorRTk.Count; i++)
            {
                chartRtk.Series[0].Points.AddXY(arrayTk[(i + 1)], listRTk[i]);
                chartRtk.Series[1].Points.AddXY(arrayTk[(i + 1)],listTheorRTk[i]);
            }
        }
    }
}