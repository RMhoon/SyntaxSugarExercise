using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var anwser = 4;

            var response = anwser < 9 ? $"{anwser} is less than nine." : $"{anwser} is greater than or equal to nine.";

            Console.WriteLine(response);
        }
    }
}
