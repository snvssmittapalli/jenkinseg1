using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment
{
    class StudentDetails
    {
        static void Main()
        {
            string name, branch;
            int age, studentid;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your branch");
            branch = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your studentid");
            studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("studentid is : {0} || student name is : {1} || branch name is : {2}|| age: {3}", studentid, name, branch, age);

            Console.WriteLine("--------------------");
            Console.ReadKey();
        }


    }
}
