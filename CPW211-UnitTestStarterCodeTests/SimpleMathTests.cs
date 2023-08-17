using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            //arrange
            double expected = num1 + num2;

            //act
            double actual = SimpleMath.Add(num1, num2);

            //assert
            Assert.AreEqual(expected: expected, actual, "num1:<{0}> num2:<{1}>", new object[] { num1, num2 });
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            //arrange
            double expected = num1 * num2;

            //act
            double actual = SimpleMath.Multiply(num1, num2);

            //assert
            Assert.AreEqual(expected: expected, actual, "num1:<{0}> num2:<{1}>", new object[] { num1, num2 });
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            //arrange
            string expectedMessage = "Denominator cannot be zero";

            //act
            var ex = Assert.ThrowsException<ArithmeticException>(() => SimpleMath.Divide(100, 0));
            
            //assert
            Assert.AreEqual(ex.Message, expectedMessage);
                
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(100, -10)]
        public void Divide_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            //arrange
            double expected = num1 / num2;

            //act
            double actual = SimpleMath.Divide(num1, num2);

            //assert
            Assert.AreEqual(expected: expected, actual, "num1:<{0}> num2:<{1}>", new object[] { num1, num2 });
        }
        
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(100, -10)]
        public void Subtract_TwoNumbers_ReturnsProduct(double num1, double num2)
        { 
            //arrange
            double expected = num1 - num2;

            //act
            double actual = SimpleMath.Subtract(num1, num2);

            //assert
            Assert.AreEqual(expected: expected, actual, "num1:<{0}> num2:<{1}>", new object[] { num1, num2 });
        }
    }
}