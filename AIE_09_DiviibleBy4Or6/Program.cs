using System;

namespace AIE_09_DiviibleBy4Or6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 4;

            if (sum % 4 == 0)
            {
                Console.WriteLine("This number is divisible by 4");
            }

            else if (sum % 6 == 0)
            {
                Console.WriteLine("This number is diviable by 6");
            }
        }
    }
}
