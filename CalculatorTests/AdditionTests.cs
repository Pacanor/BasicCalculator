using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 3;
        private readonly int b = 6;
        private readonly double c = 3.5;
        private readonly double d = 6.6;


        [TestMethod()]
        public void SumIntTest()
        {
            Assert.AreEqual(9, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(10.1, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumHybridTest()
        {
            Assert.AreEqual(9.6, Addition.Sum(a, d));
        }
    }
}

namespace CalculatorTests
{
    internal class AdditionTests
    {
    }
}