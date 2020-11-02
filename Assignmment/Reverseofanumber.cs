using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment
{
    class Reverseofanumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, remainder;
            int input = number;
            while(number!=0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
                    }

            Console.WriteLine("enter reverse of entered number {0} is {1}", input, reverse);
            Console.ReadLine();


        }
    }
}
