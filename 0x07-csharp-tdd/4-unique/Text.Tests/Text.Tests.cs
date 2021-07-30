using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Str.UniqueChar("nnn"), -1);
            Assert.AreEqual(Str.UniqueChar("aabcc"), -1);
        }
    }
}