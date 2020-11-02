using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexample
{
    class Addition
    {
        static void Main()
        {
            int num1 = 30, num2 = 40, result, subtraction;
            result = num1 + num2;
            Console.WriteLine("result of addition : {0}", result);
            ///////// subtraction////////////
            subtraction = num1 - num2;
            Console.WriteLine("result of subtraction: {0}", subtraction);
            Console.WriteLine(" result of addition is {0} and subtraction is {1}:", result, subtraction);
            Console.ReadKey();


        }
    }
}
