using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignmment
{
    class StudentDetailsUsingArrays
    {

        int total(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];

            }
            return sum;
        }



        char calculategrade(int[] sum)
        {
            float avg = 0;
            char grade;
            for (int i = 0; i < 6; i++)
            {
                avg = avg + sum[i];
            }
            if (avg > 90)
            {
                grade = 'A';

            }
            else if (avg < 90)
            {
                grade = 'B';
            }
            else
            {
                grade = 'C';
            }
            return grade;

        }


        static void Main()
        {
            Console.WriteLine("enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[size];
            int[] age = new int[size];
            int[] sub1marks = new int[size];
            int[] sub2marks = new int[size];
            int[] sub3marks = new int[size];
            int[] sub4marks = new int[size];
            int[] sub5marks = new int[size];
           
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter the name in array");
                name[i] = Console.ReadLine();
                Console.WriteLine("enter the age in array");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the subejct 1 marks  in array");
                sub1marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the subejct 2  marks in array");
                sub2marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the subejct 3 marks  in array");
                sub3marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the subejct 4 marks  in array");
                sub4marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the subejct marks 5 in array");
                sub5marks[i] = Convert.ToInt32(Console.ReadLine());
                int[] totalmarks = new int[5] { sub1marks[i], sub2marks[i], sub3marks[i], sub4marks[i], sub5marks[i] };
                Console.WriteLine(totalmarks);


            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("name  {0}||age {1}|| subject1 {2}|| subject2  {3}|| subject3  {4}|| subject4  {5}|| subject5  {6}", name[i], age[i], sub1marks[i], sub2marks[i], sub3marks[i], sub4marks[i], sub5marks[i]);

                
            }
            


            StudentDetailsUsingArrays eg = new StudentDetailsUsingArrays();

            Console.ReadLine();


        }


























    }




}










