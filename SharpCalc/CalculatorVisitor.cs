using Aesky.Calc.Parser;
using SharpCalc.DataTypes;

namespace SharpCalc
{
    internal class CalculatorVisitor : CalculatorBaseVisitor<IDataType>
    {
        public override IDataType VisitMulDiv(CalculatorParser.MulDivContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            return context.op.Type == CalculatorParser.MUL ? left.Multiply(right) : left.Divide(right);
        }

        public override IDataType VisitAddSub(CalculatorParser.AddSubContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            return context.op.Type == CalculatorParser.ADD ? left.Add(right) : left.Subtract(right);
        }

        public override IDataType VisitFloat(CalculatorParser.FloatContext context)
        {
            return new Float() {Value = float.Parse(context.FLOAT().GetText())};
        }

        public override IDataType VisitInt(CalculatorParser.IntContext context)
        {
            return new Integer() {Value = int.Parse(context.INT().GetText())};
        }

        public override IDataType VisitParens(CalculatorParser.ParensContext context)
        {
            return Visit(context.expr());
        }

        public override IDataType VisitOr(CalculatorParser.OrContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            return left.Or(right);
        }

        public override IDataType VisitBidirectional(CalculatorParser.BidirectionalContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            return left.BiDirectional(right);
        }

        public override IDataType VisitNegation(CalculatorParser.NegationContext context)
        {
            return Visit(context.expr()).Negation();
        }

        public override IDataType VisitBool(CalculatorParser.BoolContext context)
        {
            var text = context.BOOLEAN().GetText();
            text = (text == "t" || text == "T") ? "true" : (text == "f" || text == "F") ? "false" : text;
            return new Boolean() { Value = bool.Parse(text) };
        }

        public override IDataType VisitImplication(CalculatorParser.ImplicationContext context)
        {

            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            return left.Implication(right);
        }

        public override IDataType VisitNot(CalculatorParser.NotContext context)
        {
            return Visit(context.expr()).Not();
        }

        public override IDataType VisitAnd(CalculatorParser.AndContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));
            return left.And(right);
        }
    }
}