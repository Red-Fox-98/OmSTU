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

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static double calculationKtt(double t1, double t2)
        {
            return Math.Exp(-Math.Abs(t1 - t2));
        }
        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            foreach (var series in chartKtt.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chartMi.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chartKij.Series)
            {
                series.Points.Clear();
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            double m = 1;
            double N = 1000;
            double n = 100;
            double h = 0.01;
            double[] arrayTi = new double[(int)n];
            double[] arrayDelta = new double[(int)n];
            double[,] arrayFij = new double[(int)n, (int)n];
            double[,] arrayKsi = new double[(int)N, (int)n];
            double[,] arrayXt = new double[(int)N, (int)n];
            double[] arrayMti = new double[(int)n];
            double[] arrayKtt = new double[(int)n];
            double[] arrayKij = new double[(int)n];
            double sumOfValue = 0;
            double sumOfValue1 = 0;
            double sumOfValue2 = 0;
            int counterValue = 0;
            int k = 0;
            //////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < arrayTi.Length; i++)
            {
                arrayTi[i] = h * i;
                arrayTi[i] = Math.Round(arrayTi[i], 2);
            }
            for (int i = 0; i < n; i++)
            {
                while (k < i)
                {
                    sumOfValue += Math.Pow(arrayFij[k, i], 2) * arrayDelta[k];
                    k++;
                }
                arrayDelta[i] = calculationKtt(arrayTi[i], arrayTi[i]) - sumOfValue;
                sumOfValue = 0;
                k = 0;
                for (int j = 0; j < arrayFij.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        arrayFij[i, j] = 1;
                        continue;
                    }
                    if (i > j)
                    {
                        arrayFij[i, j] = 0;
                        continue;
                    }
                    while (k < n)
                    {
                        sumOfValue += arrayFij[k, i] * arrayFij[k, j] * arrayDelta[k];
                        k++;
                    }
                    arrayFij[i, j] = (calculationKtt(arrayTi[i], arrayTi[j]) - sumOfValue) / arrayDelta[i];
                    arrayFij[i, j] = Math.Round(arrayFij[i, j], 6);
                    sumOfValue = 0;
                    k = 0;
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            ////вычисление случайной величины для кси
            double[] arrayDeltaN = new double[(int)n];
            for (int i = 0; i < arrayDeltaN.Length; i++)
            {
                arrayDeltaN[i] = Math.Sqrt(arrayDelta[i]);
            }
            for (int i = 0; i < arrayKsi.GetLength(0); i++)
            {
                for (int j = 0; j < arrayKsi.GetLength(1); j++)
                {
                    n = arrayDeltaN[j];
                    arrayKsi[i, j] = Normal.Sample(0, n);
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < arrayXt.GetLength(0); i++)
            {
                for (int j = 0; j < arrayXt.GetLength(1); j++)
                {
                    while (k <= j)
                    {
                        sumOfValue += (arrayKsi[i, k] * arrayFij[k, j]);
                        k++;
                    }
                    arrayXt[i, j] = m + sumOfValue;
                    sumOfValue = 0;
                    k = 0;
                }
                counterValue = 0;
            }
            for (int i = 0; i < arrayXt.GetLength(1); i++)
            {
                chartKtt.Series[0].Points.AddXY(arrayTi[i], arrayXt[0, i]);
                chartKtt.Series[1].Points.AddXY(arrayTi[i], arrayXt[1, i]);
                chartKtt.Series[2].Points.AddXY(arrayTi[i], arrayXt[2, i]);
                chartKtt.Series[3].Points.AddXY(arrayTi[i], arrayXt[3, i]); 
                chartKtt.Series[4].Points.AddXY(arrayTi[i], arrayXt[4, i]);
                chartKtt.Series[5].Points.AddXY(arrayTi[i], arrayXt[5, i]);
                chartKtt.Series[6].Points.AddXY(arrayTi[i], arrayXt[6, i]);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < arrayMti.Length; i++)
            {
                while (counterValue < N)
                {
                    sumOfValue += arrayXt[counterValue, i];
                    counterValue++;
                }
                arrayMti[i] = sumOfValue / N;
                counterValue = 0;
                sumOfValue = 0;
            }
            for (int i = 0; i < arrayXt.GetLength(1); i++)
            {
                chartMi.Series[0].Points.AddXY(arrayTi[i], m);
                chartMi.Series[1].Points.AddXY(arrayTi[i], arrayMti[i]);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < arrayKtt.Length; i++)
            {
                arrayKtt[i] = calculationKtt(arrayTi[0], arrayTi[i]);
            }
            for (int i = 0; i < arrayXt.GetLength(1); i++)
            {
                for (int j = 0; j < arrayXt.GetLength(0); j++)
                {
                    sumOfValue1 += (arrayXt[j, 0] * arrayXt[j, i]);
                    sumOfValue2 += arrayXt[j, i];
                }
                arrayKij[i] = (sumOfValue1 - arrayMti[0] * sumOfValue2) / (N - 1);
                sumOfValue1 = 0;
                sumOfValue2 = 0;
            }
            for (int i = 0; i < arrayXt.GetLength(1); i++)
            {
                chartKij.Series[0].Points.AddXY(arrayTi[i], arrayKtt[i]);
                chartKij.Series[1].Points.AddXY(arrayTi[i], arrayKij[i]);
            }
        }
    }
}