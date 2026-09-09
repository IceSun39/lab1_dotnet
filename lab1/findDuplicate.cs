using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class findDuplicate
    {
        private int rows = 3;
        private int cols = 5;
        public int[,] array;
        public int Rows
        {
            get { return rows; }
            set { rows = 0 <= value && value <= 3 ? value : rows; }
        }

        public int Cols
        {
            get { return cols; }
            set { cols = 0 <= value && value <= 15 ? value : cols; }
        }

        void generateRandomArray(int[,] array)
        {
            // Заповнюємо випадковими значеннями на одне числ менеше ніж потрібно
            HashSet<int> allNumbers = new HashSet<int>();
            Random random = new Random();
            int totalNumbers = rows * cols;
            while (allNumbers.Count < totalNumbers - 1)
            {
                int randomNumber = random.Next(1, 100);
                allNumbers.Add(randomNumber);
            }

            // Додаємо одне випадкове число, яке вже є в наборі
            allNumbers.Add(allNumbers.ElementAt(random.Next(0, allNumbers.Count)));
            random.Shuffle(allNumbers.ToArray());

            // Заповнюємо масив числами з набору
            int index = 0;
            foreach (int number in allNumbers)
            {
                array[index / cols, index % cols] = number;
                index++;
            }
        }

        (int, int, int, int) findDuplicateInArray(int[,] array)
        {
            Hashtable seen = new Hashtable();

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int currentValue = array[i, j];

                    if (seen.ContainsKey(currentValue))
                    {
                        (int, int) previousPosition = ((int, int))seen[currentValue];

                        return (i, j, previousPosition.Item1, previousPosition.Item2);
                    }
                    else
                    {
                        seen.Add(currentValue, (i, j));
                    }
                }
            }

            return (-1, -1, -1, -1);
        }
    }
}
