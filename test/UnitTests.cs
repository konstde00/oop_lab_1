using Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        
        [TestMethod]
        public void EvaluateTestBinaryOperations()
        {
            Assert.AreEqual(200, Calculator.Evaluate("100+100"));
            Assert.AreEqual(0, Calculator.Evaluate("100-100"));
            Assert.AreEqual(1, Calculator.Evaluate("100/100"));
            Assert.AreEqual(10000, Calculator.Evaluate("100*100"));
        }
        

        [TestMethod]
        public void EvaluateTestUnaryMinus()
        {
            Assert.AreEqual(-100, Calculator.Evaluate("-100"));
            Assert.AreEqual(100, Calculator.Evaluate("--100"));
            Assert.AreEqual(-100, Calculator.Evaluate("---100"));
            Assert.AreEqual(0, Calculator.Evaluate("100+-100"));
            Assert.AreEqual(200, Calculator.Evaluate("100+--100"));
        }

        [TestMethod]
        public void EvaluateTestPow()
        {
            Assert.AreEqual(243, Calculator.Evaluate("3^5"));
            Assert.AreEqual(729, Calculator.Evaluate("3^3^2"));
            Assert.AreEqual(7625597484987, Calculator.Evaluate("3^(3^3)"));
            Assert.AreEqual(6561, Calculator.Evaluate("3^2^(2+2)"));
        }
    }
}
