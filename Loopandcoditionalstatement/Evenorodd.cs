using System;


namespace Loopandcoditionalstatement
{
    class Evenorodd
    {
        static void Main()
        {
            int num1;
            Console.WriteLine("enter number");
            num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%2==0)
            {
                Console.WriteLine("num1 {0} is even", num1);
            }
            else
            {
                Console.WriteLine("num1 {0} is odd", num1);
            }
            Console.ReadLine();   
        }

          

    }
}
