using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab1.lab2;


namespace task3_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Calculate_area_success()
        {
            var trapezoid = new lab2_task3_controller(3, 4, 5, 6, 7);
            double expectedArea = 38.5;
            double actualArea = trapezoid.calculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Calculate_midline_success()
        {
            var trapezoid = new lab2_task3_controller(3, 4, 5, 6, 7);
            double expectedMidline = 5.5;
            double actualMidline = trapezoid.calculateMidline();
            Assert.AreEqual(expectedMidline, actualMidline);
        }

        [TestMethod]
        public void Check_isosceles_success()
        {
            var trapezoid = new lab2_task3_controller(5, 5, 6, 7, 8);
            bool expectedIsosceles = true;
            bool actualIsosceles = trapezoid.checkIsosceles();
            Assert.AreEqual(expectedIsosceles, actualIsosceles);
        }

    }
}
