using System;
using System.IO;

namespace Random
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                string writeText = "Hello World";
                File.WriteAllText("test.txt", writeText);

                string readText = File.ReadAllText("test.txt");
                Console.WriteLine(readText);
                
                
            }
        }


    }
}