using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            int result = Operations.Add(1,2);
            Assert.AreEqual(result, 3);
        }
    }
}