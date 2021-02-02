using System;

namespace AIE_07_MaxOfThreeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number: ");
            string snum1 = Console.ReadLine();
            Console.Write("Enter second Number: ");
            string snum2 = Console.ReadLine();
            Console.Write("Enter third Number: ");
            string snum3 = Console.ReadLine();

            int num1 = int.Parse(snum1);
            int num2 = int.Parse(snum2);
            int num3 = int.Parse(snum3);

            Console.WriteLine("The largest number is");

            if (num1 >= num2 && num1 >= num3) Console.WriteLine(num1);
            if (num2 >= num1 && num2 >= num3) Console.WriteLine(num2);
            if (num3 >= num2 && num3 >= num1) Console.WriteLine(num3);


        }
    }
}
