using System;

namespace AIE_01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "     Hello There!     ";
            //Console.WriteLine($"[{greeting}]");

            string trimmedgreeting = greeting.TrimStart();
            //Console.WriteLine($"[{trimmedgreeting}]");
            //Will trim the start printing [Hello There!     ]

            trimmedgreeting = greeting.TrimEnd();
            //Console.WriteLine($"[{trimmedgreeting}]");
            //will trim the end printing [    Hello There!]

            trimmedgreeting = greeting.Trim();
            Console.WriteLine($"" +
                $"{trimmedgreeting}");
            //This will trim both the start and the end


        }
    }
}
