using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class CalcFreeDrop
    {
        public double[] distances = new double[1000];
        public int n = 0;
        private const double G = 9.81;

        public void Calculate(int t = 10)
        {
            for (int i = 1; i <= t; i++)
            {
                distances[i] = 0.5 * G * i * i;
            }
            n = t;
        }
    }
}
