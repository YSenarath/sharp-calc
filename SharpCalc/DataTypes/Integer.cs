namespace SharpCalc.DataTypes
{
    internal class Integer : IDataType
    {
        public Integer()
        {
            type = DatatypeType.Float;
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
    }
}