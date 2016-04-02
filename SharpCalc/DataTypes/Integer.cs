using System;

namespace SharpCalc.DataTypes
{
    internal class Integer : IDataType
    {
        public Integer()
        {
            type = DatatypeType.Integer;
        }

        public int Value { get; set; }

        public override IDataType Add(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Float)
            {
                return new Integer {Value = Value + (int) ((Float) operand2).Value};
            }
            return new Integer {Value = Value + ((Integer) operand2).Value};
        }

        public override IDataType Subtract(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Float)
            {
                return new Integer {Value = Value - (int) ((Float) operand2).Value};
            }
            return new Integer {Value = Value - ((Integer) operand2).Value};
        }

        public override IDataType Multiply(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Float)
            {
                return new Integer {Value = Value*(int) ((Float) operand2).Value};
            }
            return new Integer {Value = Value*((Integer) operand2).Value};
        }

        public override IDataType Divide(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Float)
            {
                return new Integer {Value = Value/(int) ((Float) operand2).Value};
            }
            return new Integer {Value = Value/((Integer) operand2).Value};
        }

        public override string ValueAsString()
        {
            return Value.ToString();
        }

        public override IDataType Or(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType BiDirectional(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType Implication(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType And(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType Not()
        {
            throw new InvalidOperationException();
        }

        public override IDataType Negation()
        {
            return new Integer() { Value = (-1) * Value };
        }
    }
}