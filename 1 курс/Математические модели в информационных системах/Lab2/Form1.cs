using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
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
            double N = Convert.ToDouble(NTextBox.Text);
            double C = Convert.ToDouble(CTextBox.Text);
            double A = Convert.ToDouble(ATextBox.Text);
            double[] arrayXn = new double[(int)N];
            double[] arrayU = new double[(int)N];
            arrayXn[0] = 100;

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
                chartU.Series["U"].Points.AddXY(arrayRandomValueU[i], arrayQuantityRandomValueU[i]);
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(NTextBox.Text);
            double C = Convert.ToDouble(CTextBox.Text);
            double A = Convert.ToDouble(ATextBox.Text);
            double lambda = Convert.ToDouble(LambdaTextBox.Text);
            double[] arrayXn = new double[(int)N];
            double[] arrayU = new double[(int)N];
            double[] arrayX = new double[(int)N];
            arrayXn[0] = 100;

            for (int i = 1; i < N; i++)
            {
                arrayXn[i] = congruentMethod(A, arrayXn[i], arrayXn[i - 1], C, N);
                arrayU[i] = arrayXn[i] / N;
                arrayU[i] = Math.Round(arrayU[i], 4);
            }

            for (int i = 0; i < arrayU.Length; i++)
            {
                arrayX[i] = -lambda * Math.Log10(arrayU[i]);
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
                chartX.Series["X"].Points.AddXY(arrayRandomValueX[i], arrayQuantityRandomValueX[i]);
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(NTextBox.Text);
            double C1 = Convert.ToDouble(CTextBox.Text);
            double C2 = 2767;
            double A = Convert.ToDouble(ATextBox.Text);
            double sigma = Convert.ToDouble(SigmaTextBox.Text);
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
                chartY.Series["Y"].Points.AddXY(arrayRandomValueY[i], arrayQuantityRandomValueY[i]);
            }
        }
    }
}