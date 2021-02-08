using System;

namespace Random
{
    class Program
    { 
        static int[]
        static void Main(string[] args)
        {
            var numbers1 = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            var numbers2 = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            var numbers3 = new int[] { 10, 3, 6, 6, 6, 8, 1, 7 };

            Console.WriteLine(CheckArrayEquality(numbers1, numbers2)); // true
            Console.WriteLine(CheckArrayEquality(numbers1, numbers3)); // false        
        }
    }
}
