using System;

namespace AIE_06_HiLow
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNumber = Console.ReadLine();
            int number = int.Parse(sNumber);

            if (number > 50 )
            {
                Console.WriteLine("The number is greater than 50");
            }
            else if (number < 50)
            {
                Console.WriteLine("The number is lower than 50");
            }
            else
            {
                Console.WriteLine("same");
            }


        }
    }
}
