using System;

namespace AIE_17_Calculator
{
    class Program
    {
        static int Calculate(int num1, int num2, string operation)
        {
            if(operation == "add")
            {
                return num1 + num2;
            }

            else if(operation == "sub")
            {
                return num1 - num2;
            }

            else if(operation == "exp")
            {
                return (int)Math.Pow(num1, num2);
            }
            throw new Exception($"The operation {operation} is not supported"); // will make it crash 


        }



        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(4, 3, "add")); // should output 7 
            Console.WriteLine(Calculate(4, 3, "sub")); // should output 1 
            Console.WriteLine(Calculate(4, 3, "exp")); // should output 64
        }
    }
}
