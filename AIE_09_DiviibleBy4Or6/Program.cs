using System;

namespace AIE_09_DiviibleBy4Or6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 4;

<<<<<<< HEAD
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
=======
            if ((sum % 6 == 0) || (sum % 6 == 0))
            {
                Console.WriteLine("Divisble by 4 Or 6");
            }



            else
            {
                Console.WriteLine("Not Divisable by 6");
            }
     }
        
>>>>>>> e515a7f3496349ec0a41bb6d55b8d5eed4071a07
}
