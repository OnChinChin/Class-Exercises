using System;

namespace AIE_04_CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Diameter = 8;
            double radius = 4;
            double circumnference = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius); //or double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The circumference is " + circumnference); 
            Console.WriteLine("The area is " + area);
        }
    }
}
