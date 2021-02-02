using System;

namespace AIE_03_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint currentyear = 2021;
            uint birthyear = 2000;

            uint age = currentyear - birthyear;

            Console.WriteLine("You are: " + age + " years old");


        }
    }
}
