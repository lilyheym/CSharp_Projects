using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsignment
{
    class Program
    {
        static void Main(string[] args)
        
        {
            // Part One

            string[] numArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };


            // User Input

            Console.WriteLine("Please write something below:");
            string numArrayUser = Console.ReadLine();

            // did one loop instead of two, thank you instructors

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] += numArrayUser;
                Console.WriteLine(numArray[i]);
            }
            Console.ReadLine();

            // Part Two

            var x = true;

            while (x)
            {
                Console.WriteLine("Keep the change, ya filthy animal!");
                break;   // Inifinite Loop fixed by adding break
            }
            Console.ReadLine();

            // Part Three

            // less than operator

            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 25)
            {
                Console.WriteLine("This number is not too old for Leonardo DiCaprio.");
            }
            else
            {
                Console.WriteLine("This number is too old for Leonardo DiCaprio.");
            }
            Console.ReadLine();

            // less than or equals to operator

            Console.WriteLine("Please enter another number (no more DiCaprio jokes I promise).");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            if (userInput2 <= 25)
            {
                Console.WriteLine("This number is less than or equal to 25");
            }
            else
            {
                Console.WriteLine("This number is larger than 25");
            }
            Console.ReadLine();

            // Part Four

            List<string> fruit = new List<string>
            {
                "apple",
                "banana",
                "watermelon",
                "pomegranate",
                "orange",
                "mango",
                "peach",
                "plum",
                "pear",
                "lychee",
                "strawberry",
                "blueberry",
                "grapefuit",
                "cantelope",
                "cherry",
                "pineapple",
                "grape",
            };

            Console.WriteLine("Please enter a fruit (lower case).");
            string fruitInput = Console.ReadLine();

            if (fruit.Contains(fruitInput))
            {
                Console.WriteLine(fruit.IndexOf(fruitInput));
            }
            else
            {
                Console.WriteLine("Sorry, that fruit is not in the catelog.");
            }
            Console.ReadLine();

            // Part Five

            List<string> colors = new List<string>
            {
                "black",
                "white",
                "red",
                "yellow",
                "orange",
                "blue",
                "brown",
                "purple",
                "green",
                "brown",
                "gold",
                "silver",
            };

            Console.WriteLine("Please enter a color (lower case).");
            string colorsInput = Console.ReadLine();
            bool colorGuess = false;

            for (int index = 0; index < colors.Count; index++)
            {
                if (colors[index] == colorsInput)
                {
                    colorGuess = true;
                    Console.WriteLine(index);
                }
            }
            if (colorGuess == false)
            {
                Console.WriteLine("Sorry, this color is not in the list.");
            }
            Console.ReadLine();


            // Part Six

            List<string> famousRappers = new List<string>
            {
                "Tupac",
                "The Notorious B.I.G",
                "Eminem",
                "Kanye West",
                "Nicki Manaj",
                "Dr. Dre",
                "Queen Latifa",
                "Tupac",
                "Kendrick Lamar",
                "Lil Wayne",
                "Snoop Dogg",
                "Future",
                "Ice-T",
                "Missy Elliot",
                "Jay-Z",
                "Cardi B",
                "Gucci Mane",
                "Wiz Khalifa",
                "Post Malone"
            };

            var distList = famousRappers.Distinct().ToList();
            var Repeateditemlist = new List<string>();
                                                                                            // gets the District elements and then iterates over them and checks their count in the list
            foreach (var item in distList)                                                  // if their count is > 1, it means the item appears more than once, and is therefore added to 
            {                                                                               // Repeateditemlist
                if (famousRappers.Count(e => e == item) > 1)
                {
                    Repeateditemlist.Add(item);
                    Console.WriteLine(item + " is a duplicate name in the list.");
                }
                else
                {
                    Console.WriteLine(item + " is a unique name in the list.");
                }

            }
          
            Console.ReadLine();

            

          
        }
    }
}
