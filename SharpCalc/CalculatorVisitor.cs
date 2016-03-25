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
            return new Float {Value = float.Parse(context.FLOAT().GetText())};
        }

        public override IDataType VisitInt(CalculatorParser.IntContext context)
        {
            return new Float {Value = int.Parse(context.INT().GetText())};
        }

        public override IDataType VisitParens(CalculatorParser.ParensContext context)
        {
            return Visit(context.expr());
        }
    }
}