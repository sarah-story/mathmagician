﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            EvenNumbers even = new EvenNumbers();
            Assert.IsNotNull(even);
        }
    }
}
