using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandcoditionalstatement
{
    class Switchcase
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter the nmber");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    {
                        Console.WriteLine("monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("thursay");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("friay");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid number");
                        break;
                    }

                    Console.Read();



            }
        }
    }
}
