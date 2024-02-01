using System;


namespace StructAssignment
{
    class Program
    {
        public struct Number
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number myNumber = new Number();

            myNumber.Amount = 123.45m;

            Console.WriteLine("$Amount: {myNumber.Amount}");
            Console.ReadLine();
        }
    }
}
