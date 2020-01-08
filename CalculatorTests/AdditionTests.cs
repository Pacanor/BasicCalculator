using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 3;
        private readonly int b = 6;
        //private readonly int[] c = { 2, 3, 4, 5 };

        [TestMethod()]
        public void SumIntTest()
        {
            Assert.AreEqual(9, Addition.Sum(a, b));
        }
        /*
        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(14, Addition.Sum(c));
        }
        */
    }
}

namespace CalculatorTests
{
    class AdditionTests
    {
    }
}
