using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCore3;

namespace TestProject1
{
    [TestClass]
    public class NodesCoverage
    {
        [TestMethod]
        public void test1()
        {
            int[] testArr = {3, 4, 5};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Разносторонний", testTr.TypeOfTriangle(testArr));
        }
    }
}