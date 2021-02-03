using System;

namespace AIE_15_IsAVowel
{
    class Program
    {
        static bool IsAVowel(char character) //bool outcome true or false
        {
            character = char.ToLower(character);

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                return true;

            return false;
        }


        static void Main(string[] args)
        { 
            Console.WriteLine(IsAVowel('A')); // should output true 
            Console.WriteLine(IsAVowel('a')); // should output true 
            Console.WriteLine(IsAVowel('b')); // should output false 
        }
    }
}
