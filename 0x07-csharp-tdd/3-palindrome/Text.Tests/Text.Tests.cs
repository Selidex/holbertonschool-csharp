using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Str.IsPalindrome(""), true);
            Assert.AreEqual(Str.IsPalindrome("A man, a plan, a canal: Panama."), true);
            Assert.AreEqual(Str.IsPalindrome("bob"), true);
            Assert.AreEqual(Str.IsPalindrome("bill"), false);
            Assert.Pass();
        }
    }
}