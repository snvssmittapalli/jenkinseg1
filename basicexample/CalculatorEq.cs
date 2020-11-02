using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexample
{
    class CalculatorEq
    {
        float num1 = 80, num2 = 25, result;
        ////method without return type
        void Add()
        {
            result = num1 + num2;
            Console.WriteLine("addition is :{0}", result);
            //anotherway
            Console.WriteLine("addition is :{0}", (num1 + num2));

        }
        //method with return type

           float Sub()
             {
            return (num1 - num2);
             
             }
        static void Main()
        {
            //object creation
            // syntax is classname object=new classname()
            //funcion+f9 to set breakpoint
            CalculatorEq objcalci = new CalculatorEq();
            objcalci.Add();
            float res = objcalci.Sub();
            Console.WriteLine("subtraction is :{0}", res);
            Console.WriteLine("subtraction is {0}", objcalci.Sub());
            Console.ReadKey();

        }
    }
}
