using System;

namespace Assignmment
{
    class NoofDigitsInGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0, rem;
            while(num>0)
            {
                rem = num % 10;
                count = count + 1;
                num = num / 10;
            }
            Console.WriteLine("number of digits in given number is : {0}", count);
            Console.ReadLine();
        }
    }
}
