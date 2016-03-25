using System;
using Aesky.Calc.Parser;
using Antlr4.Runtime;

namespace SharpCalc
{
    public class Evaluator
    {
        private static CalculatorParser GetParser(string expression)
        {
            var stream = new AntlrInputStream(expression);
            var lexer = new CalculatorLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new CalculatorParser(tokens);
            return parser;
        }

        public static string Evaluate(string expression)
        {
            var parser = GetParser(expression);
            var tree = parser.prog();
            var visitor = new CalculatorVisitor();
            var result = visitor.Visit(tree);
            if (result == null) throw new Exception("Unable to visit nodes.");
            return visitor.Visit(tree).ValueAsString();
        }

        public static string Parse(string expression)
        {
            var parser = GetParser(expression);
            var tree = parser.prog();
            return tree.ToStringTree(parser);
        }
    }
}