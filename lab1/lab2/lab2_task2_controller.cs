using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab2
{
    public class lab2_task2_controller
    {
        private int num1;
        private int num2;
        public int sum;

        public lab2_task2_controller()
        {
            num1 = 0;
            num2 = 0;
        }

        public lab2_task2_controller(int num1, int num2)
        {
            if(num2 < num1)
            {
                throw new ArgumentException("Second number must be greater than or equal to first number.");
            }

            this.num1 = num1;
            this.num2 = num2;
        }

        public lab2_task2_controller(int num2)
        {
            this.num1 = 0;
            this.num2 = num2;
        }

        public int calculate()
        {
            sum = 0;
            int i = num1;

            // Шукаємо перше число, яке ділиться на 17 у межах діапазону
            while (i <= num2 && i % 17 != 0)
            {
                i++;
            }

            // Проходимо всі числа, кратні 17, і додаємо потрібні до суми
            for (; i <= num2; i += 17)
            {
                if (Math.Abs(i % 4) == 2)
                {
                    sum += i;
                }
            }

            return sum;
        }

    }
}
