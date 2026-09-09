using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return Math.Abs(x) * Math.Sin(3 * x);
        }

        private double f2(double x)
        {
            return (x * x * x) * Math.Cos(x + 2);
        }

        private double f3(double x)
        {
            return Math.Sin(x * x) + Math.Pow(x, 0.25);
        }

        public void Tabulate(double Xn = -5.55, double Xk = 10.33, double h = 0.1, double a = 0.2)
        {
            double y = 0;
            int i = 0;

            for (double x = Xn; x <= Xk; x += h)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else if (x >= 0 && x < a)
                {
                    y = f2(x);
                }
                else
                {
                    y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                i++;
            }
            n = i;

        }
    }
}
