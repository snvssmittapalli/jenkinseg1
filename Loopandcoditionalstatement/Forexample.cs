using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandcoditionalstatement
{
    class Forexample
    {
        static void Main()
        {
            int num1, num2, num3, result;
            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("num1 is greater {0}", num1);
            }
            else if (num2>num1 && num2> num3)
            {
                Console.WriteLine("num2 is great {0}", num2);

            }
            else
            {
                Console.WriteLine("num3 is great {0}", num3);
            }

            Console.Read();



        }
    }
    
 }
