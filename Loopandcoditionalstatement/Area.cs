using System;

namespace Loopandcoditionalstatement
{
    class Area
    {
        static void Main()
        {
            int side1, side2;
            Console.WriteLine("enter the side1");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side2");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area of the square is {0}", (side1 * side1));
            Console.WriteLine("area of the rectangle is {0}", (side1 * side2));
            Console.ReadKey();



        }
    }
}
