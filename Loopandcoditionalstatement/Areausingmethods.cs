using System;

namespace Loopandcoditionalstatement
{
    class Areausingmethods
    {
        int side1, side2, squarearea, rectangulararea;
        void squareA()
        {
            squarearea = side1 * side1;
            Console.WriteLine("area of square is: {0}", squarearea);
        }
        void rectangulara()
        {
            rectangulararea = side1 * side2;
            Console.WriteLine("area of rectangule is {0}", rectangulararea);
        }
        static void Main()
        {
            
            Areausingmethods objarea = new Areausingmethods();
            Console.WriteLine("enter side1");
            objarea.side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ener side 2");
            objarea.side2 = Convert.ToInt32(Console.ReadLine());
            objarea.squareA();
            objarea.rectangulara();
            Console.ReadKey();



        }
    }
}
