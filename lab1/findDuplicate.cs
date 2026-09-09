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

        public void generateRandomArray()
        {
            array = new int[rows, cols];

            List<int> allNumbers = new List<int>();
            Random random = new Random();

            int totalNumbers = rows * cols;

            while (allNumbers.Count < totalNumbers - 1)
            {
                int randomNumber = random.Next(1, 100);

                if (!allNumbers.Contains(randomNumber))
                {
                    allNumbers.Add(randomNumber);
                }
            }

            // Додаємо дубль
            int duplicate = allNumbers[random.Next(allNumbers.Count)];
            allNumbers.Add(duplicate);

            
            int[] numbers = allNumbers.ToArray();
            random.Shuffle(numbers);

            // Заповнюємо матрицю
            int index = 0;

            foreach (int number in numbers)
            {
                array[index / cols, index % cols] = number;
                index++;
            }
        }

        public (int, int, int, int) findDuplicateInArray()
        {
            Hashtable seen = new Hashtable();

            int rows = this.array.GetLength(0);
            int cols = this.array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int currentValue = this.array[i, j];

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
