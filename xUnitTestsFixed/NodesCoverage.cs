using TriangleCore3;
using TriangleCoreFixed;
using Xunit;

namespace xUnitTests
{
    public class NodesCoverage
    {
        [Fact]
        public void test1() {
            int[] testArr = {3, 4, 5};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal("Разносторонний", testTr.TypeOfTriangle(testArr));
        }
    }
}