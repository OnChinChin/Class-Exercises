using System;

namespace AIE_20_NeedelInTheHaystack
{
    class Program
    {
        static int FindNeedle(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == "needle")
                    return i;
            }

            return 0;
        }
        static void Main(string[] args)
        {

            var strings = new string[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

            int needleLocation = FindNeedle(strings);
            if (needleLocation < 0)
            {
                Console.WriteLine(needleLocation);
            }
            else
            {
                Console.WriteLine("found needle at location: " + needleLocation);
            }
        }
        
    }
}