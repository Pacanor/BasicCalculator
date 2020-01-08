using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        //private readonly int[] c = { 100, 4, 5 };
        private readonly int d = 0;

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(2, Division.Quotient(a, b));
        }
        /*
        [TestMethod()]
        public void QuotientIntArrayTest()
        {
            Assert.AreEqual(5, Division.Quotient(c));
        }
        */
        [TestMethod()]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(a, d));
        }
    }
}

namespace CalculatorTests
{
    class DivisionTests
    {
    }
}
