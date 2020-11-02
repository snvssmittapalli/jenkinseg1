using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment
{
    class FrequencyofGivenElemenInArray
    {
        static void Main()
        {
            Console.WriteLine("enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int i = 0;
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("enter the value in array");
                array[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (i = 0; i < size; i++)
            {


                Console.WriteLine(array[i]);


            }
            int count = 0;
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter input");
            for (i = 0; i < size; i++)
            {
                if (array[i] == input)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("count is {0}", count);
            Console.ReadLine();
        }
    }   
}
    


