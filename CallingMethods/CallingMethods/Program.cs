using System;


namespace CallingMethods
{
    class Program
    {
        public void Main(string[] args)
        {
            // prompt user to input number

            DoingMath obj = new DoingMath();
            Console.WriteLine("Enter a number to do math operations on.");


            int userInput = Convert.ToInt32(Console.ReadLine());
            int result;
            int result2;
            int result3;

            // calling methods

            result = obj.DoingAddition(userInput);
            result2 = obj.DoingSubtraction(userInput);
            result3 = obj.DoingMultiplication(userInput);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
            
        }
    }
}
