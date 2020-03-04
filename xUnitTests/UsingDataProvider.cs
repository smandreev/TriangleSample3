using System.Collections.Generic;
using TriangleCore3;
using Xunit;

namespace xUnitTests
{
    public class UsingDataProvider
    {
        private static class DemoPropertyDataSource
        {
            private static readonly List<object[]> _data = new List<object[]>
            {
                new object[] {"Разносторонний", 3, 4, 5},
                new object[] {"Равнобедренный", 2, 4, 4},
                new object[] {"Равносторонний", 3, 3, 3},
                new object[] {"Треугольник не существует", 1, -1, 1},
                new object[] {"Треугольник не существует", 2, 1, 1}
            };

            public static IEnumerable<object[]> TestData
            {
                get { return _data; }
            }
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(DemoPropertyDataSource))]
        public void test(string res, int a, int b, int c)
        {
            int[] testArr = {a, b, c};
            Triangle testTr = new Triangle();
            Assert.Equal(res, testTr.TypeOfTriangle(testArr)); //, "Что-то пошло не так");
        }
    }
}