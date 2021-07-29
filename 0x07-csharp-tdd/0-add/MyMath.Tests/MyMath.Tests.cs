using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            result = Operations.Add(1,2);
            Assert.AreEqual(reult, 3);
        }
    }
}