using System;

namespace SharpCalc.DataTypes
{
    internal class Float : IDataType
    {
        public Float()
        {
            type = DatatypeType.Float;
        }

        public float Value { get; set; }


        public override IDataType Add(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float {Value = Value + ((Integer) operand2).Value};
            }
            return new Float {Value = Value + ((Float) operand2).Value};
        }

        public override IDataType Subtract(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float {Value = Value - ((Integer) operand2).Value};
            }
            return new Float {Value = Value - ((Float) operand2).Value};
        }

        public override IDataType Multiply(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float {Value = Value*((Integer) operand2).Value};
            }
            return new Float {Value = Value*((Float) operand2).Value};
        }

        public override IDataType Divide(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float {Value = Value/((Integer) operand2).Value};
            }
            return new Float {Value = Value/((Float) operand2).Value};
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
            return new Float { Value = (-1) * Value };
        }
    }
}