using System;

namespace SyntaxSugarExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extra code added for user input instead of just 4 as variable
            Console.WriteLine("Give me a number.");

            //Excercise 1 has shortened from 11 lines of code to 3
            var answer = Convert.ToInt32(Console.ReadLine());
            var response = (answer < 9) ? " is less than nine" : " is greater than or equal to nine";
            Console.WriteLine($"If you're answer is {answer}, it{response}");
        }
    }
}
