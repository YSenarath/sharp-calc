using System;

namespace SharpCalc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "exit")
            {
                Console.WriteLine(Evaluator.Evaluate(input));
                input = Console.ReadLine();
            }
        }
    }
}