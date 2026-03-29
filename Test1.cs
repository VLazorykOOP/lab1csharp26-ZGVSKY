using Microsoft.VisualStudio.TestTools.UnitTesting;

using Lab1; 

namespace Lab1CSharp.Tests
{
    [TestClass]
    public class Task5Tests
    {
        [TestMethod]
        public void Multiply_ReturnsCorrectProduct()
        {
            double a = 5.5;
            double b = 2.0;
            double expected = 11.0;

            double result = Task5.Multiply(a, b);

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}