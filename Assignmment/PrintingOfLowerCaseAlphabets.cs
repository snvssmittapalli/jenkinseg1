using System;

namespace Assignmment
{
    class PrintingOfLowerCaseAlphabets
    {
        static void Main()
        {
            int n=0;
            while(n<=26)
            {
                Console.WriteLine(Convert.ToChar(n+(int)'a'));
                n = n + 1;

            }
            Console.ReadKey();
        }
    }
}
