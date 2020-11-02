using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexample
{
    class Inputfromuser
    {
        static void Main()
        {
            string name, city;
            int age;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your city");
            city = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");

            Console.WriteLine("name: {0) || city: {1}|| age: {2}", name, city, age);


            Console.Read();






        }

    }
}
