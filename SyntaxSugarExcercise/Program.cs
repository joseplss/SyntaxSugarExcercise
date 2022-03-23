using System;

namespace SyntaxSugarExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extra code added for user input instead of just 9 as variable
            Console.WriteLine("Give me a number.");

            //Excercise 1 has shortened from 11 lines of code to 3
            var answer = Convert.ToInt32(Console.ReadLine());
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
