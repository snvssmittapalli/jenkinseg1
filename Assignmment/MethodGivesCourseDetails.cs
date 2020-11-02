
using System;


namespace Assignmment
{
    class MethodGivesCourseDetails
    {
        void DisplayingCourseDetails(int Cid,string CName,int Feeamount)
        {
            Console.WriteLine("Cid is {0} || Cname is {1} || Feeamount is {2} ", Cid, CName, Feeamount);


        }
        static void Main()
        {
            int courseid, coursefee;
            string coursename;
            Console.WriteLine("enter course id");
            courseid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter course name");
            coursename = Console.ReadLine();
            Console.WriteLine("enter course fee amount");
            coursefee = Convert.ToInt32(Console.ReadLine());

            MethodGivesCourseDetails coursedetails = new MethodGivesCourseDetails();
            coursedetails.DisplayingCourseDetails(courseid, coursename, coursefee);
            Console.Read();





        }
    }
}
