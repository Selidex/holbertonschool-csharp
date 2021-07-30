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
            Assert.AreEqual(Str.UniqueChar("aabcc"), 2);
            Assert.AreEqual(Str.UniqueChar("abbcc"), 0);
            Assert.AreEqual(Str.UniqueChar(""), -1);
            Assert.AreEqual(Str.UniqueChar("aabbc"), 4);
        }
    }
}