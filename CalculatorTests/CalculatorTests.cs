using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

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
            Assert.AreEqual(9, calc.Add(a, b));
        }

        /* [TestMethod()]
         public void AddIntArrayTest()
         {
             Assert.AreEqual(14, calc.Add(c));
         }
         */
        [TestMethod()]
        public void DivideIntTest()
        {
            Assert.AreEqual(2, calc.Divide(a, b));
        }
    }
}