using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab1.lab2;

namespace task2_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Calculate_all_valid()
        {
            var controller = new lab2_task2_controller(1, 500);
            int expected = 1666;
            int actual = controller.calculate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_negative_numbers()
        {
            var controller = new lab2_task2_controller(-500, -1);
            int expected = -1666;
            int actual = controller.calculate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_first_boundary_greater()
        {
            Assert.ThrowsException<ArgumentException>(() => new lab2_task2_controller(500, 1));

        }
    }
}
