using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void AddTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var sum = calcRef.Add(1, 1);
            Assert.AreEqual(2, sum);
        }

        [TestMethod]
        public void AddNegativesTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var sum = calcRef.Add(-1, -1);
            Assert.AreEqual(-2, sum);
        }

        [TestMethod]
        public void SubtractTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var diff = calcRef.Subtrct(1, 1);
            Assert.AreEqual(0, diff);
        }

        [TestMethod]
        public void SubtractNegativesTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var diff = calcRef.Subtrct(-1, -1);
            Assert.AreEqual(0, diff);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var product = calcRef.Multiply(2, 1);
            Assert.AreEqual(2, product);
        }

        [TestMethod]
        public void MultiplyNegativesTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var product = calcRef.Multiply(-2, -1);
            Assert.AreEqual(2, product);
        }

        [TestMethod]
        public void DivideTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var quotient = calcRef.Divide(25, 5);
            Assert.AreEqual(5, quotient);
        }


        [TestMethod]
        public void DivideByZeroTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var div = calcRef.Divide(25, 0);
            Assert.AreEqual(div, double.NaN);
        }

        [TestMethod]
        public void SquareRootTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var squareRoot = calcRef.SquareRoot(25);
            Assert.AreEqual(5, squareRoot);
        }

        [TestMethod]
        public void HalveTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var half = calcRef.Halve(100);
            Assert.AreEqual(50, half);
        }

        [TestMethod]
        public void QuarterTest()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var quarter = calcRef.Quarter(100);
            Assert.AreEqual(25, quarter);
        }
    }
}
