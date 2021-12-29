using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculationXY_Click(object sender, EventArgs e)
        {
            foreach (var series in chartXY.Series)
            {
                series.Points.Clear();
            }

            double r = Convert.ToDouble(textBoxR.Text);
            double N = 1000;
            double mX = 3;
            double mY = 2;
            double sigmaX = 1;
            double sigmaY = 4;
            Random random = new Random();
            double[] arrayB = new double[6];
            double[] arrayA = new double[6];
            double[] arrayX = new double[(int)N];
            double[] arrayY = new double[(int)N];
            int i = 0;
            double sB, sA, mYX, sigmaYX;

            while (i < N)
            {
                for (int b = 0; b < arrayB.Length; b++)
                {
                    arrayB[b] = random.NextDouble();
                    arrayB[b] = Math.Round(arrayB[b], 3);
                }
                for (int a = 0; a < arrayB.Length; a++)
                {
                    arrayA[a] = random.NextDouble();
                    arrayA[a] = Math.Round(arrayA[a], 3);
                }
                sB = arrayB.Sum();
                arrayX[i] = Math.Sqrt(2) * sigmaX * (sB - 3) + mX;
                arrayX[i] = Math.Round(arrayX[i], 3);
                mYX = mY + r * (sigmaY / sigmaX) * (arrayX[i] - mX);
                sigmaYX = sigmaY * Math.Sqrt(1 - Math.Pow(r, 2));
                sA = arrayA.Sum();
                arrayY[i] = Math.Sqrt(2) * sigmaYX * (sA - 3) + mYX;
                arrayY[i] = Math.Round(arrayY[i], 3);
                i++;
            }

            for (int j = 0; j < arrayX.Length; j++)
            {
                chartXY.Series["XY"].Points.AddXY(arrayX[j], arrayY[j]);
            }
        }
    }
}