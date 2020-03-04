using System;

namespace TriangleCoreFixed
{
    public class TriangleFixed
    {
        public String TypeOfTriangle(int[] sides)
        {
            String result = "Треугольник не треугольник";
            var isTriangle = false;
            var a = sides[0];
            var b = sides[1];
            var c = sides[2];

            foreach (int side in sides)
            {
                if (side <= 0)
                {
                    result = "Треугольник не существует";
                    return result;
                }
            }

            if ((a < b + c) && (b < a + c) && (a < b + c))
            {
                isTriangle = true;
            }

            if (isTriangle)
            {
                if ((sides[0] == sides[1]) && (sides[1] == sides[2]))
                {
                    result = "Равносторонний";
                }
                else
                {
                    if ((sides[0] != sides[1]) && (sides[0] != sides[2]) && (sides[1] != sides[2]))
                    {
                        result = "Разносторонний";
                    }
                    else
                    {
                        result = "Равнобедренный";
                    }
                }
            }


            System.Console.WriteLine("Стороны: " + a + " | " + b + " | " + c);
            System.Console.WriteLine("Треугольник:" + result);

             return result;
        }
    }
}