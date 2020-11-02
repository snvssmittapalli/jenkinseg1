using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandcoditionalstatement
{
    class While
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
            Console.WriteLine("enter the end number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while(initialvalue<=endvalue)
            {
                Console.WriteLine("iniial value is  {0}", initialvalue);
                initialvalue++;
                if(initialvalue%2==0)
                {
                    Console.WriteLine("{0} is even number", initialvalue);
                    
                }
               

            }
            Console.ReadLine();
        }
    }
}
