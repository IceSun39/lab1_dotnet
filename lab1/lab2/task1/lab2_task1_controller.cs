using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab2.task1
{
    public class lab2_task1_controller
    {
        private int num1;
        private int num2;
        private int num3;
        public int count = 0;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public int Num3
        {
            get { return num3; }
            set { num3 = value; }
        }

        public lab2_task1_controller(int num1, int num2, int num3)
        {   
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public lab2_task1_controller()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
        }

        public lab2_task1_controller(int num)
        {
            num1 = num;
            num2 = num;
            num3 = num;
        }

        public int checkDivisionBy27()
        {
            count = 0;
            if (num1 % 27 == 0)
            {
                count++;
            }
            if (num2 % 27 == 0)
            {
                count++;
            }
            if (num3 % 27 == 0)
            {
                count++;
            }
            return count;
        }
    }
}
