using TriangleCore3;
using TriangleCoreFixed;
using Xunit;

namespace xUnitTests
{
    public class BranchesCoverageFinal
    {
        [Fact]
        public void test1()
        {
            int[] testArr = {3, 4, 5};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal("Разносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void test2()
        {
            int[] testArr = {2, 4, 4};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal("Равнобедренный", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void test3()
        {
            int[] testArr = {3, 3, 3};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal("Равносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void test4()
        {
            int[] testArr = {1, -1, 1};
            TriangleFixed testTr = new TriangleFixed();
            Assert.NotEqual("Разносторонний", testTr.TypeOfTriangle(testArr)); //, "Что-то пошло не так");
        }

        [Fact]
        public void Test5()
        {
            int[] testArr = {2, 1, 1};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal(testTr.TypeOfTriangle(testArr), "Треугольник не треугольник"); //, "Что-то пошло не так");
        }
    }
}