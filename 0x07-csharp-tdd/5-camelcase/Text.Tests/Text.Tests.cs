using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Str.CamelCase(""), 0);
            Assert.AreEqual(Str.CamelCase(null), 0);
            Assert.AreEqual(Str.CamelCase("nnn"), 1);
            Assert.AreEqual(Str.CamelCase("nN"), 2);
            Assert.AreEqual(Str.CamelCase("nNN"), 3);
        }
    }
}