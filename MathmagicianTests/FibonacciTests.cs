using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            Assert.IsNotNull(fibonacci);
        }

        [TestMethod]
        public void FibShouldPrintFirstNumber()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            int expected = 1;
            int actual = fibonacci.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintNextNumber()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            int input = 1;
            int expected = 1;
            int actual = fibonacci.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintVariableSequenceOfNumbers()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21 };
            int[] actual = fibonacci.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibPrintSequenceOfNumbers()
        {
            FibonacciNumbers fibonacci = new FibonacciNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fibonacci.ToString(fibonacci.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
