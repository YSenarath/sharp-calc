using System;

namespace SharpCalc.DataTypes
{
    public class Boolean : IDataType
    {
        public Boolean()
        {
            type = DatatypeType.Boolean;
        }

        public bool Value { get; set; }

        public override IDataType Add(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType Divide(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType Multiply(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override IDataType Subtract(IDataType operand2)
        {
            throw new InvalidOperationException();
        }

        public override string ValueAsString()
        {
            return Value.ToString();
        }

        public override IDataType Or(IDataType operand2)
        {
            if (operand2.type != DatatypeType.Boolean) throw new ArithmeticException();
            return  new Boolean() {Value = Value || ((Boolean) operand2).Value};
        }

        public override IDataType BiDirectional(IDataType operand2)
        {
            if (operand2.type != DatatypeType.Boolean) throw new ArithmeticException();
            return new Boolean() { Value = (!Value || ((Boolean)operand2).Value) && (Value || !((Boolean)operand2).Value) };
        }

        internal override IDataType Compare(IDataType right, int type)
        {
            throw new InvalidOperationException();
        }

        public override IDataType Implication(IDataType operand2)
        {
            if (operand2.type != DatatypeType.Boolean) throw new ArithmeticException();
            return new Boolean() { Value = !Value || ((Boolean)operand2).Value };
        }

        public override IDataType And(IDataType operand2)
        {
            if (operand2.type != DatatypeType.Boolean) throw new ArithmeticException();
            return new Boolean() { Value = Value && ((Boolean)operand2).Value };
        }

        public override IDataType Not()
        {
            return new Boolean() { Value = ! Value };
        }

        public override IDataType Negation()
        {
            throw new InvalidOperationException();
        }
    }
}
