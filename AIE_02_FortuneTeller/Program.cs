using System;

namespace AIE_02_FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned int (only posative values)
            uint numberOfChildren = 10;
            string partnersName = "Bob";
            string geographicLocation = "Sydney";
            string jobTitle = "Forklift Driver";

            string output = string.Format(
                "You will be an {0} in {1}, and married to {2} with {3} kids",
                jobTitle, geographicLocation, partnersName, numberOfChildren);

            Console.WriteLine(output);
        }
    }
}
