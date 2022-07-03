using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingCalculator.Tests
{
    [TestClass]
    public class BowlingCalculatorTests
    {
        [TestMethod]
        public void calculate_Throws_standartThrows()
        {
            List<int> throws = new List<int>() { 10, 7, 3, 7, 2, 9, 1, 10, 10, 10, 2, 3, 6, 4, 7, 3, 3 };
            List<int> expexted_result = new List<int>() { 10, 24, 30, 44, 46, 55, 56, 76, 96, 126, 132, 138, 144, 148, 162, 165, 168 };
            List<int> actual_result = new List<int>();

            Calculator calc = new Calculator();
            actual_result = calc.calculate_Throws(throws);

            CollectionAssert.AreEqual(expexted_result, actual_result);
        }
    }
}
