using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[,] myMatrix = new int[,]{
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };
            Assert.AreEqual(Matrix.Divide(null, 5), null);
            Assert.AreEqual(Matrix.Divide(myMatrix, 0), null);
            Assert.AreEqual(Matrix.Divide(myMatrix, 2)[0,2], 1);
        }
    }
}