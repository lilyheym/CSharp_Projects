using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // string variables

            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Hi " + studentName + "!");
            Console.ReadLine();

            Console.WriteLine("What course are you one?");
            string courseName = Console.ReadLine();
            Console.WriteLine(courseName + ", that's great!");
            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            int numPage = Convert.ToInt32(pageNum);
            Console.WriteLine("Page " + numPage + ", good to go!");
            Console.ReadLine();

            // String and Bool variable

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string helpAnswer = Console.ReadLine();
            bool yesOrNo = Convert.ToBoolean(helpAnswer);

            // I thought a simple If/Else statement would just make the answers for the boolean cleaner

            if (yesOrNo == true)
            {
                Console.WriteLine("Please reach out to an instructor for help");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Okay, keep up the good work!");
                Console.ReadLine();
            }

            // In theory the answers saved in the strings here would be sent to an instructor, so these are just placeholders for that

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiencesAnswer = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackAnswer = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string hoursStudy = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudy);

            Console.WriteLine(studyHours + ", great job!");
            Console.ReadLine();

            // Final Line

            Console.WriteLine("Thank you for your answers! An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
