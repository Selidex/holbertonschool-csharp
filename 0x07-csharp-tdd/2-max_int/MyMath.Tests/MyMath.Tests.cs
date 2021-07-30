using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> newList = new List<int>();
            Assert.AreEqual(Operations.Max(newList), 0);
            newList.Add(-1);
            Assert.AreEqual(Operations.Max(newList), -1);
            Assert.AreEqual(Operations.Max(null), 0);
            newList.Add(2);
            Assert.AreEqual(Operations.Max(newList), 2);
            Assert.Pass();
        }
    }
}