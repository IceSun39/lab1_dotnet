using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab2
{
    public class lab2_task3_controller
    {
        private int leftSide, rightSide;
        private int upperBase, lowerBase;
        private int height;
        public double area { get; private set; }
        public double midline { get; private set; }
        public bool isIsosceles { get; private set; }

        public lab2_task3_controller()
        {
            leftSide = 0;
            rightSide = 0;
            upperBase= 0;
            lowerBase = 0;
            height = 0;
        }

        public lab2_task3_controller(int leftSide, int rightSide, int upperBase, int lowerBase, int height)
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
            this.upperBase = upperBase;
            this.lowerBase = lowerBase;
            this.height = height;
        }

        public lab2_task3_controller(int sides, int upperBase, int lowerBase, int height)
        {
            this.leftSide = sides;
            this.rightSide = sides;
            this.upperBase = upperBase;
            this.lowerBase = lowerBase;
            this.height = 0;
        }

        public double calculateArea()
        {
            area = (upperBase + lowerBase) * height / 2.0;
            return area;
        }

        public double calculateMidline()
        {
            midline = (upperBase + lowerBase) / 2.0;
            return midline;
        }

        public bool checkIsosceles()
        {
            isIsosceles = leftSide == rightSide;
            return isIsosceles;
        }
    }
}
