using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandcoditionalstatement
{
    class Switchcase2
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of input1 and inpit2");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2= Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("enter the operaion");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    {
                        result = input1 + input2;
                        Console.WriteLine("addtion is {0}", result);
                        break;
                    }
                case "-":
                    {
                        result = input1 - input2;
                        Console.WriteLine("subtraction is {0}", result);
                        break;
                    }
                case "*":
                    {
                        result = input1 * input2;
                        Console.WriteLine("multiplication is {0}", result);
                        break;
                    }
                case "/":
                    {
                        result = input1 / input2;
                        Console.WriteLine("division is {0}", result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("out of allowed operations range");
                        break;
                    }
            }
                            
            Console.Read();
        }
    }
}
