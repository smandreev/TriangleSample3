﻿using TriangleCore3;
 using TriangleCoreFixed;
 using Xunit;

namespace xUnitTests
{
    public class StatementsCoverage
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
            Triangle testTr = new Triangle();
            Assert.Equal("Равносторонний", testTr.TypeOfTriangle(testArr));
        }

        [Fact]
        public void test4()
        {
            int[] testArr = {1, -1, 1};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal("Треугольник не существует", testTr.TypeOfTriangle(testArr)); //"Что-то пошло не так");
        }

        [Fact]
        public void test5()
        {
            int[] testArr = {2, 1, 1};
            TriangleFixed testTr = new TriangleFixed();
            Assert.Equal(testTr.TypeOfTriangle(testArr), "Треугольник не треугольник"); //, "Что-то пошло не так");
        }
    }
}