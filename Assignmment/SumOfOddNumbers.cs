using System;


namespace Assignmment
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for(int i=0;i<=num;i++)
            {
                if(i%2 !=0)
                {
                    
                    total = total + i;
                                       
                }
                
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
