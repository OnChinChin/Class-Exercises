using System;
using System.Linq; 
namespace AIE_21_CalculateAverage
{
    class Program
    {
        static float CalculateAverage(int[] numbers)
        {
            return (float)numbers.Average();
        }
        static void Main(string[] args)
        {
            var numbers = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            Console.WriteLine(CalculateAverage(numbers));
        }
    }
}
