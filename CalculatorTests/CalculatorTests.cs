using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly Calculator calc = new Calculator();
        private readonly int a = 6;
        private readonly int b = 3;
        //private readonly int[] c = { 2, 3, 4, 5 };
        //private readonly int[] f = { 100, 4, 5 };

        [TestMethod()]
        public void AddIntTest()
        {
            Calculator calc = new Calculator();
            int c = calc.Add(a, b);
            Assert.AreEqual(c, calc.result);

        }

        [TestMethod()]
        public void DivideIntTest()
        {
            Calculator calc = new Calculator();
            int c = calc.Divide(a, b);
            Assert.AreEqual(c, calc.result);
        }
    }
}