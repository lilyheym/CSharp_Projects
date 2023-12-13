using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please add a number between 0 and 10,000,000");
            //string timesFifty = Console.ReadLine();
            //int multByFifty = Convert.ToInt32(timesFifty);
            //int resultFifty = multByFifty * 50;
            //Console.WriteLine(multByFifty + " multiplied by 50 equals " + resultFifty + "!");
            //Console.ReadLine();

            //Console.WriteLine("Please write another number");
            //string addTwentyFive = Console.ReadLine();
            //int add25 = Convert.ToInt32(addTwentyFive);
            //int addingResult = add25 + 25;
            //Console.WriteLine(add25 + " plus 25 equals " + addingResult + "!");
            //Console.ReadLine();

            //Console.WriteLine("Please write another number");
            //string divideBy = Console.ReadLine();
            //double divByTwelve = Convert.ToDouble(divideBy);
            //double divQuotient = divByTwelve / 12.5;
            //Console.WriteLine(divByTwelve + " divided by 12.5 equals " + divQuotient + "!");
            //Console.ReadLine();

            //Console.WriteLine("Please write another number, we're going to check if it's greater than 50");
            //string greaterThan = Console.ReadLine();
            //int greaterFifty = Convert.ToInt32(greaterThan);
            //int fifty = 50;
            //bool testFifty = greaterFifty > fifty;
            //if (testFifty)
            //{
            //    Console.WriteLine("true");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //    Console.ReadLine();
            //}

            Console.WriteLine("Please write another number, we are going to divide it by 7 and give you the remainder");
            string giveRemainder = Console.ReadLine();
            int remainderSeven = Convert.ToInt32(giveRemainder);
            int remainder = remainderSeven % 7;
            Console.WriteLine("The remainder of " + remainderSeven + " and 7 is " + remainder);
            Console.ReadLine();


            



        }
    }
}
