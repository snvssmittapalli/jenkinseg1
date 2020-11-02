using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandcoditionalstatement
{
    class Dowhile
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
            Console.WriteLine("enter the end number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while (initialvalue > endvalue)
            {
                Console.WriteLine("inside while");
            }
            Console.WriteLine("------------");
            do
            {
                Console.WriteLine("inside do while");
                Console.WriteLine("initial value is {0}", initialvalue);
                initialvalue++;
            }
            while (initialvalue > endvalue);



            Console.Read();


        }


    }
}
 
