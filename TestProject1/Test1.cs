using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab1.lab2.task1;

namespace DivisionBy27_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Calculate_all_valid()
        {
            var controller = new lab2_task1_controller(27, 54, 81);
            int expected = 3;
            int actual = controller.checkDivisionBy27();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_some_valid()
        {
            var controller = new lab2_task1_controller(27, 10, 81);
            int expected = 2;
            int actual = controller.checkDivisionBy27();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_none_valid()
        {
            var controller = new lab2_task1_controller(10, 20, 30);
            int expected = 0;
            int actual = controller.checkDivisionBy27();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_negative_numbers()
        {
            var controller = new lab2_task1_controller(-27, -54, -81);
            int expected = 3;
            int actual = controller.checkDivisionBy27();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_mixed_numbers()
        {
            var controller = new lab2_task1_controller(-27, 10, 81);
            int expected = 2;
            int actual = controller.checkDivisionBy27();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_zero()
        {
            var controller = new lab2_task1_controller(0, 27, 54);
            int expected = 3;
            int actual = controller.checkDivisionBy27();
            Assert.AreEqual(expected, actual);
        }

    }
}
