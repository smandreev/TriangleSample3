using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCore3;

namespace TestProject1
{
    [TestClass]
    public class BranchesCoverage
    {
        [TestMethod]
        public void test1()
        {
            int[] testArr = {3, 4, 5};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Разносторонний", testTr.TypeOfTriangle(testArr));
        }

        [TestMethod]
        public void test2()
        {
            int[] testArr = {2, 4, 4};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Равнобедренный", testTr.TypeOfTriangle(testArr));
        }

        [TestMethod]
        public void test3()
        {
            int[] testArr = {3, 3, 3};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Равносторонний", testTr.TypeOfTriangle(testArr));
        }

        [TestMethod]
        public void test4()
        {
            int[] testArr = {1, -1, 1};
            Triangle testTr = new Triangle();
            Assert.AreEqual("Треугольник не существует", testTr.TypeOfTriangle(testArr)); //, "Что-то пошло не так");
        }

        [TestMethod]
        public void test5()
        {
            int[] testArr = {2, 1, 1};
            Triangle testTr = new Triangle();
            Assert.AreEqual(testTr.TypeOfTriangle(testArr), "Равнобедренный"); //, "Что-то пошло не так");
        }
    }
}