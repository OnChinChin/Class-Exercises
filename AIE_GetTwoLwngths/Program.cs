using System;

namespace AIE_GetTwoLwngths
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myInts = new int[10] { 0, 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            for (int i = 0; i < 10; i++)
            {
                // we can access the value at a specified location in the array
                // we use the [] subscript operator

                Console.WriteLine(myInts[i]);
            }

        }
    }
}
