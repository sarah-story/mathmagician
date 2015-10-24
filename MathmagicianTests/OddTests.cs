using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void OddEnsureICanCreateClassInstance()
        {
            OddNumbers odd = new mathmagician.OddNumbers();
            Assert.IsNotNull(odd);
        }

        [TestMethod]
        public void OddShouldPrintFirstNumber()
        {
            OddNumbers odd = new mathmagician.OddNumbers();
            int expected = 1;
            int actual = odd.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintNextNumber()
        {
            OddNumbers odd = new mathmagician.OddNumbers();
            int input = 3;
            int expected = 5;
            int actual = odd.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintVariableSequenceOfNumbers()
        {
            OddNumbers odd = new mathmagician.OddNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] actual = odd.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddPrintSequenceOfNumbers()
        {
            OddNumbers odd = new mathmagician.OddNumbers();
            int length = 7;
            string expected = "1 3 5 7 9 11 13";
            string actual = odd.ToString(odd.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
