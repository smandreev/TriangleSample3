using NUnit.Framework;
using TriangleCore3;

namespace nUnitTests
{
    [TestFixture]
    public class NodesCoverage
    {
        [Test]
        public void test1()
        {
            int[] testArr = {3, 4, 5};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Разносторонний", testTr.TypeOfTriangle(testArr));
        }
    }
}