using TriangleCore3;
using NUnit;
using NUnit.Framework;

namespace nUnitTests
{    
    [TestFixture]
    public class BranchesCoverage
    {
        [Test]
        public void test1()
        {
            int[] testArr = {3, 4, 5};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Разносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Test]
        public void test2()
        {
            int[] testArr = {2, 4, 4};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Равнобедренный", testTr.TypeOfTriangle(testArr));
        }

        [Test]
        public void test3()
        {
            int[] testArr = {3, 3, 3};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Равносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Test]
        public void test4()
        {
            int[] testArr = {1, -1, 1};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Треугольник не существует", testTr.TypeOfTriangle(testArr)); //, "Что-то пошло не так");
        }

        [Test]
        public void test5()
        {
            int[] testArr = {2, 1, 1};
            Triangle testTr = new Triangle();
            Assert.AreEqual(testTr.TypeOfTriangle(testArr), "Равнобедренный"); //, "Что-то пошло не так");
        }
    }
}