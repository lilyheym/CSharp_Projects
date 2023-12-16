using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // While Loop: U.S. States

            Console.WriteLine("Guess a U.S. State:");
            string state = Console.ReadLine();
            bool stateGuessed = state == "Louisiana";

            while (!stateGuessed)
            {
                switch (state)
                {
                    case "Louisiana":
                        Console.WriteLine("Correct! Good guess!");
                        stateGuessed = true;
                        break;

                    case "Oregon":
                        Console.WriteLine("Oregon is incorrect, try again");
                        Console.WriteLine("Guess a U.S. State:");
                        state = Console.ReadLine();
                        break;

                    case "Florida":
                        Console.WriteLine("Florida is incorrect, try again");
                        Console.WriteLine("Guess a U.S. State:");
                        state = Console.ReadLine();
                        break;

                    case "California":
                        Console.WriteLine("California is incorrect, try again");
                        Console.WriteLine("Guess a U.S. State:");
                        state = Console.ReadLine();
                        break;

                    case "Montana":
                        Console.WriteLine("Montana is incorrect, try again");
                        Console.WriteLine("Guess a U.S. State:");
                        state = Console.ReadLine();
                        break;

                    case "New Jersey":
                        Console.WriteLine("New Jersey is incorrect, try again");
                        Console.WriteLine("Guess a U.S. State:");
                        state = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Wrong state, try again");
                        Console.WriteLine("Guess a U.S. State:");
                        state = Console.ReadLine();
                        break;
                }
            }

            Console.ReadLine();



            // Do While Loop, Colors


            Console.WriteLine("Guess a color:");
            string color = Console.ReadLine();
            bool colorGuessed = color == "gold";

            do
            {
                switch (color)
                {
                    case "gold":
                        Console.WriteLine("You guessed the color gold! Great job!");
                        colorGuessed = true;
                        break;

                    case "red":
                        Console.WriteLine("Sorry, you guessed red, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "blue":
                        Console.WriteLine("Sorry, you guessed blue, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "green":
                        Console.WriteLine("Sorry, you guessed green, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "yellow":
                        Console.WriteLine("Sorry, you guessed yellow, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "orange":
                        Console.WriteLine("Sorry, you guessed orange, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "black":
                        Console.WriteLine("Sorry, you guessed black, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "white":
                        Console.WriteLine("Sorry, you guessed white, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "silver":
                        Console.WriteLine("Sorry, you guessed silver, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    case "purple":
                        Console.WriteLine("Sorry, you guessed purple, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("You guessed the wrong color, try again");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!colorGuessed);

            Console.ReadLine();
        }
    }
}
