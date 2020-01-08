using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly int d = 0;

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(2, Division.Quotient(a, b));
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(a, d));
        }
    }
}

namespace CalculatorTests
{
    internal class DivisionTests
    {
    }
}