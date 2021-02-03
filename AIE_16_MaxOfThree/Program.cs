using System;

namespace AIE_16_MaxOfThree
{
    class Program
    {
        static int MaxOfThree(int a, int b, int c)
        {
            if (a >= b && a >= c) return a;
            else if (b >= c && b >= c) return b;
            else return c;
        }
            

        static void Main(string[] args)
        {
            Console.WriteLine(MaxOfThree(6, 9, 1)); // should output 9 
            Console.WriteLine(MaxOfThree(20, 20, 20)); // should output 20
            Console.WriteLine(MaxOfThree(6, 1, 6)); // should output 6
        }
    } 
}
