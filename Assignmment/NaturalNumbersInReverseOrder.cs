using System;

namespace Assignmment
{
    class NaturalNumbersInReverseOrder
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=number; i>=1;i--)
            {
                Console.WriteLine(i);
            }
          
            Console.ReadLine();
        }
    }
}
