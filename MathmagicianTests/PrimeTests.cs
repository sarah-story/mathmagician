using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateClassInstance()
        {
            PrimeNumbers prime = new PrimeNumbers();
            Assert.IsNotNull(prime);
        }

        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int expected = 1;
            int actual = prime.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 2;
            int expected = 3;
            int actual = prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintVariableSequenceOfNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 5, 7, 11, 13, 17 };
            int[] actual = prime.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimePrintSequenceOfNumbers()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int length = 7;
            string expected = "1 2 3 5 7 11 13";
            string actual = prime.ToString(prime.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
