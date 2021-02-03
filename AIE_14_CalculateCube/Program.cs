using System;

namespace AIE_14_CalculateCube
{
    class Program
    {
        static void Main(string[] args)
        {
            double cube(double a)
            {
                double value = Math.Pow(a, 3);
                return value;

            }
            Console.WriteLine(cube(5));
            Console.WriteLine(cube(10));


            //    int a = 5;
            //    int b = 10;

            //    Console.WriteLine(DoSomething(a, b));
            //    Console.WriteLine($"{a} + {b} = {DoSomething(a, b)}");
            //}

            //static int DoSomething(int a, int b)
            //{
            //    return a + b;
        }
    }
}
