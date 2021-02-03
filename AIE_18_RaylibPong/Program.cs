using System;

namespace AIE_18_RaylibPong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
    }
}
