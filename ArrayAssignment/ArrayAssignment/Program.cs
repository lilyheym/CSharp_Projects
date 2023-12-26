using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            // String Array

            string[] birds = { "Duck", "Pigeon", "Quail", "Goose", "Turkey", "Robin", "Chicken", "Parrot", "Mockingbird", "Bluejay", "Vulture" };

            Console.WriteLine("Please select a number between 0 and 10 to see the bird associated with it.");
            int birdUserSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(birds[birdUserSelect]);
            Console.ReadLine();

            // Int Array

            int[] intArray = { 342, 24, 987, 5789, 0, 11, 2466, 87654, 10, 4, 75 };

            Console.WriteLine("Please select a number between 0 and 10 see see it's associated integer.");
            int intUserSelect = Convert.ToInt32(Console.ReadLine());

            // Branching Statement for Int Array

            if (intUserSelect > 10 || intUserSelect < 0)
            {
                Console.WriteLine("Sorry, this index does not exist in the array, try again next time.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine(intArray[intUserSelect]);
                Console.ReadLine();
            }

            // List String

            List<string> snakesString = new List<string>
            {
                "Black Mamba",
                "King Cobra",
                "Ball Python",
                "Copperhead",
                "Coachwhip",
                "Burmese Python",
                "Amazon Tree Boa",
                "Anaconda",
                "Bloody Python",
                "Lancehead",
                "Asian Keelback"
            };

            Console.WriteLine("Please select a number between 0 and 10 to see it's corresponding snake.");
            int snakeUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(snakesString[snakeUserInput]);
            Console.ReadLine();

            // Sign-Off Because I'm Feeling Fancy

            Console.WriteLine("Thanks for Playing!");
            Console.ReadLine();

        }
    }
}
