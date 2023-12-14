using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooelanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Questionare");
            Console.ReadLine();

            // Age over 15

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int ageInt = Convert.ToInt32(ageString);
            bool ageFifteen = ageInt > 15;
            

            // No DUIs

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool duiHowMany = Convert.ToBoolean(dui);
            bool duiQualify = duiHowMany == false;


            // Under 3 sppeding tickets

            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            int speedingTicket = Convert.ToInt32(speeding);
            bool ticketSpeeding = speedingTicket < 3;

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            Console.WriteLine(ageFifteen && duiQualify && ticketSpeeding);
            Console.ReadLine();









        }
    }
}
