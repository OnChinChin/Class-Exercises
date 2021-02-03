using System;

namespace AIE_12_AllTimesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 12; n++)
            {
                for(int s=0; s <=12; s++)
                {
                    Console.WriteLine($"{n} * {s}: {n * s}");
                }
            }

                
        }
    }
}
