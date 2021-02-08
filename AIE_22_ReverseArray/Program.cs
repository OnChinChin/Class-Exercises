using System;

namespace AIE_22_ReverseArray
{
    class Program
    {
        static int[] ReverseArray(int[] numbers)
        {
            int[] rev = new int[numbers.Length];

            for(int i=0; i<numbers.Length; i++)
            {
                rev[numbers.Length - 1 - i] = numbers[i];
            }
            return rev;
        }
        


        static void Main(string[] args)
        {
            var numbers = new int[] { 10, 3, 6, 6, 4, 8, 1, 7 };
            var reversed = ReverseArray(numbers);

            for (int i = 0; i < numbers.Length; i++)
                Console.Write($"{numbers[i]}, ");

            Console.WriteLine("");

            for (int i = 0; i < reversed.Length; i++)
                Console.Write($"{reversed[i]}, ");
        }
    }
}
