using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double congruentMethod(double a, double xn, double xi, double c, double n)
        {
            xn = ((a * xi) + c) % n;
            return xn;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            double N = Convert.ToDouble(textBoxN.Text);
            double C = Convert.ToDouble(textBoxC.Text);
            double A = Convert.ToDouble(textBoxA.Text);
            double[] arrayXn = new double[(int)N];
            double[] arrayU = new double[(int)N];
            arrayXn[0] = 100;
            double m = 20;

            for (int i = 1; i < N; i++)
            {
                arrayXn[i] = congruentMethod(A, arrayXn[i], arrayXn[i - 1], C, N);
                arrayU[i] = arrayXn[i] / N;
                arrayU[i] = Math.Round(arrayU[i], 4);
            }

            double[] arrayRandomValueU = arrayU.Distinct().ToArray();
            Array.Sort(arrayRandomValueU);
            double[] arrayQuantityRandomValueU = new double[arrayRandomValueU.Length];

            for (int i = 0; i < arrayU.Length; i++)
            {
                for (int j = 0; j < arrayRandomValueU.Length; j++)
                {
                    if (arrayU[i] == arrayRandomValueU[j])
                    {
                        arrayQuantityRandomValueU[j] += 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < arrayQuantityRandomValueU.Length; i++)
            {
                chartU1.Series["U"].Points.AddXY(arrayRandomValueU[i], arrayQuantityRandomValueU[i]);
            }

            double maxU = arrayU[0];
            double minU = arrayU[0];

            for (int i = 0; i < arrayU.Length; i++)
            {
                if (arrayU[i] > maxU)
                {
                    maxU = arrayU[i];
                }
                if (arrayU[i] < minU)
                {
                    minU = arrayU[i];
                }
            }

            double omega = maxU - minU;
            double h = omega / m;

            double[] leftBorder = new double[(int)m];
            double[] rightBorder = new double[(int)m];
            leftBorder[0] = minU;
            rightBorder[0] = minU + h;

            for (int i = 1; i < m; i++)
            {
                leftBorder[i] = leftBorder[i - 1] + h;
                leftBorder[i] = Math.Round(leftBorder[i], 2);
                rightBorder[i] = rightBorder[i - 1] + h;
                rightBorder[i] = Math.Round(rightBorder[i], 2);
            }

            double[] arrayN = new double[(int)m];

            for (int i = 0; i < arrayU.Length; i++)
            {
                for (int j = 0; j < leftBorder.Length; j++)
                {
                    if (arrayU[i] >= leftBorder[j] && arrayU[i] <= rightBorder[j])
                    {
                        arrayN[j] += 1;
                    }
                }
            }

            for (int i = 0; i < arrayN.Length; i++)
            {
                chartU2.Series["U"].Points.AddXY(i, arrayN[i]);
            }

            double hee = 0;
            double[] arrayPi = new double[(int)m];

            for (int i = 0; i < leftBorder.Length; i++)
            {
                arrayPi[i] = rightBorder[i] - leftBorder[i];
                hee = hee + ((Math.Pow(arrayN[i] / (N - arrayPi[i]), 2)) / arrayPi[i]);
                arrayPi[i] = Math.Round(arrayPi[i], 2);
                dataGridView.Rows.Add(leftBorder[i], rightBorder[i], arrayN[i], Math.Round((arrayN[i] / N), 4), arrayPi[i]);
            }

            textBoxHeeU.Text = Convert.ToString(Math.Round(hee, 4));
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            double N = Convert.ToDouble(textBoxN.Text);
            double C = Convert.ToDouble(textBoxC.Text);
            double A = Convert.ToDouble(textBoxA.Text);
            double lambda = Convert.ToDouble(textBoxLambda.Text);
            double[] arrayXn = new double[(int)N];
            double[] arrayU = new double[(int)N];
            double[] arrayX = new double[(int)N];
            arrayXn[0] = 100;
            double m = 20;

            for (int i = 1; i < N; i++)
            {
                arrayXn[i] = congruentMethod(A, arrayXn[i], arrayXn[i - 1], C, N);
                arrayU[i] = arrayXn[i] / N;
            }

            for (int i = 0; i < arrayU.Length; i++)
            {
                arrayX[i] = -lambda * Math.Log(arrayU[i]);
                arrayX[i] = Math.Round(arrayX[i], 2);
            }

            double[] arrayRandomValueX = arrayX.Distinct().ToArray();
            Array.Sort(arrayRandomValueX);
            Array.Resize(ref arrayRandomValueX, arrayRandomValueX.Length - 1);
            double[] arrayQuantityRandomValueX = new double[arrayRandomValueX.Length];

            for (int i = 0; i < arrayX.Length; i++)
            {
                for (int j = 0; j < arrayRandomValueX.Length; j++)
                {
                    if (arrayX[i] == arrayRandomValueX[j])
                    {
                        arrayQuantityRandomValueX[j] += 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < arrayQuantityRandomValueX.Length; i++)
            {
                chartX1.Series["X"].Points.AddXY(arrayRandomValueX[i], arrayQuantityRandomValueX[i]);
            }

            double maxX = arrayX[1];
            double minX = arrayX[1];

            for (int i = 0; i < arrayX.Length; i++)
            {
                if (arrayX[i] > maxX && arrayX[i] < 100)
                {
                    maxX = arrayX[i];
                }
                if (arrayX[i] < minX)
                {
                    minX = arrayX[i];
                }
            }

            double omega = maxX - minX;
            double h = omega / m;

            double[] leftBorder = new double[(int)m];
            double[] rightBorder = new double[(int)m];
            leftBorder[0] = Math.Round(minX, 2);
            rightBorder[0] = Math.Round(minX + h, 2);

            for (int i = 1; i < m; i++)
            {
                leftBorder[i] = leftBorder[i - 1] + h;
                leftBorder[i] = Math.Round(leftBorder[i], 2);
                rightBorder[i] = rightBorder[i - 1] + h;
                rightBorder[i] = Math.Round(rightBorder[i], 2);
            }

            double[] arrayN = new double[(int)m];

            for (int i = 0; i < arrayX.Length; i++)
            {
                for (int j = 0; j < leftBorder.Length; j++)
                {
                    if (arrayX[i] >= leftBorder[j] && arrayX[i] <= rightBorder[j])
                    {
                        arrayN[j] += 1;
                    }
                }
            }

            for (int i = 0; i < arrayN.Length; i++)
            {
                chartX2.Series["X"].Points.AddXY(i, arrayN[i]);
            }

            double hee = 0;
            double[] arrayPi = new double[(int)m];

            for (int i = 0; i < leftBorder.Length ; i++)
            {
                arrayPi[i] = Math.Exp(-lambda * leftBorder[i]) - Math.Exp(-lambda * rightBorder[i]);
                hee = hee + ((Math.Pow(arrayN[i] / (N - arrayPi[i]), 2)) / arrayPi[i]);
                arrayPi[i] = Math.Round(arrayPi[i], 2);
                dataGridView.Rows.Add(leftBorder[i], rightBorder[i], arrayN[i], Math.Round((arrayN[i] / N), 4), arrayPi[i]);
            }

            hee = Math.Round(hee, 4);
            textBoxHeeX.Text = Convert.ToString(hee);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            double N = Convert.ToDouble(textBoxN.Text);
            double C1 = Convert.ToDouble(textBoxC.Text);
            double C2 = 2767;
            double A = Convert.ToDouble(textBoxA.Text);
            double sigma = Convert.ToDouble(textBoxSigma.Text);
            double[] arrayXn1 = new double[(int)N];
            double[] arrayXn2 = new double[(int)N];
            double[] arrayU1 = new double[(int)N];
            double[] arrayU2 = new double[(int)N];
            double[] arrayV1 = new double[(int)N];
            double[] arrayV2 = new double[(int)N];
            arrayXn1[0] = 100;
            arrayXn2[0] = 100;
            double a = 2;
            double S;
            double m = 20;

            for (int i = 1; i < N; i++)
            {
                arrayXn1[i] = congruentMethod(A, arrayXn1[i], arrayXn1[i - 1], C1, N);
                arrayU1[i] = arrayXn1[i] / N;
                arrayU1[i] = Math.Round(arrayU1[i], 4);
                arrayXn2[i] = congruentMethod(A, arrayXn2[i], arrayXn2[i - 1], C2, N);
                arrayU2[i] = arrayXn2[i] / N;
                arrayU2[i] = Math.Round(arrayU2[i], 4);
            }

            for (int i = 0; i < arrayU1.Length; i++)
            {
                arrayV1[i] = (2 * arrayU1[i]) - 1;
                arrayV2[i] = (2 * arrayU2[i]) - 1;
            }

            int counter = 0;
            for (int i = 0; i < arrayV1.Length; i++)
            {
                S = Math.Pow(arrayV1[i], 2) + Math.Pow(arrayV2[i], 2);
                if (S < 1)
                {
                    counter++;
                }
            }

            double[] arrayX = new double[counter * 2];
            counter = 0;
            for (int i = 0; i < arrayV1.Length; i++)
            {
                S = Math.Pow(arrayV1[i], 2) + Math.Pow(arrayV2[i], 2);
                if (S < 1)
                {
                    arrayX[counter] = arrayV1[i] * (Math.Sqrt((-2 * Math.Log10(S)) / S));
                    counter++;
                    arrayX[counter] = arrayV2[i] * (Math.Sqrt((-2 * Math.Log10(S)) / S));
                    counter++;
                }
            }

            double[] arrayY = new double[arrayX.Length];
            for (int i = 0; i < arrayX.Length; i++)
            {
                arrayY[i] = (sigma * arrayX[i]) + a;
                arrayY[i] = Math.Round(arrayY[i], 2);
            }

            double[] arrayRandomValueY = arrayY.Distinct().ToArray();
            Array.Sort(arrayRandomValueY);
            double[] arrayQuantityRandomValueY = new double[arrayRandomValueY.Length];

            for (int i = 0; i < arrayY.Length; i++)
            {
                for (int j = 0; j < arrayRandomValueY.Length; j++)
                {
                    if (arrayY[i] == arrayRandomValueY[j])
                    {
                        arrayQuantityRandomValueY[j] += 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < arrayQuantityRandomValueY.Length; i++)
            {
                chartY1.Series["Y"].Points.AddXY(arrayRandomValueY[i], arrayQuantityRandomValueY[i]);
            }

            double maxY = arrayY[0];
            double minY = arrayY[0];

            for (int i = 0; i < arrayY.Length; i++)
            {
                if (arrayY[i] > maxY)
                {
                    maxY = arrayY[i];
                }
                if (arrayY[i] < minY)
                {
                    minY = arrayY[i];
                }
            }

            double omega = maxY - minY;
            double h = omega / m;

            double[] leftBorder = new double[(int)m];
            double[] rightBorder = new double[(int)m];
            leftBorder[0] = minY;
            rightBorder[0] = minY + h;

            for (int i = 1; i < m; i++)
            {
                leftBorder[i] = leftBorder[i - 1] + h;
                leftBorder[i] = Math.Round(leftBorder[i], 2);
                rightBorder[i] = rightBorder[i - 1] + h;
                rightBorder[i] = Math.Round(rightBorder[i], 2);
            }

            double[] arrayN = new double[(int)m];

            for (int i = 0; i < arrayY.Length; i++)
            {
                for (int j = 0; j < leftBorder.Length; j++)
                {
                    if (arrayY[i] >= leftBorder[j] && arrayY[i] <= rightBorder[j])
                    {
                        arrayN[j] += 1;
                    }
                }
            }

            for (int i = 0; i < arrayN.Length; i++)
            {
                chartY2.Series["Y"].Points.AddXY(i, arrayN[i]);
            }

            double hee = 0;
            double[] arrayPi = new double[(int)m];

            for (int i = 0; i < leftBorder.Length; i++)
            {
                arrayPi[i] = ((rightBorder[i] - a) / sigma) - ((leftBorder[i] - a) / sigma);
                hee = hee + ((Math.Pow(arrayN[i] / (N - arrayPi[i]), 2)) / arrayPi[i]);
                arrayPi[i] = Math.Round(arrayPi[i], 2);
                dataGridView.Rows.Add(leftBorder[i], rightBorder[i], arrayN[i], Math.Round((arrayN[i] / N), 4), arrayPi[i]);
            }

            textBoxHeeY.Text = Convert.ToString(Math.Round(hee, 4));
        }
    }
}
