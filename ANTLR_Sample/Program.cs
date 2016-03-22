using System;
using Aesky.Calc.Parser;
using Antlr4.Runtime;
using static System.Console;

namespace ANTLR_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = ReadLine();
            while (input != "exit")
            {
                var stream = new AntlrInputStream(input);
                var lexer = new CalculatorLexer(stream);
                var tokens = new CommonTokenStream(lexer);
                var parser = new CalculatorParser(tokens);
                var tree = parser.prog();
                WriteLine(tree.ToStringTree(parser));

                var visitor = new CalculatorVisitor();
                Console.WriteLine(visitor.Visit(tree).ValueAsString());

                input = ReadLine();
            }
        }
    }
}
