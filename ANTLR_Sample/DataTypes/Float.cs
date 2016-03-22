using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ANTLR_Sample.DataTypes
{
    internal class Float : IDataType
    {
        public float Value { get; set; }

        public Float()
        {
            type = DatatypeType.Float;
        }


        public override IDataType Add(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float() {Value = this.Value + (float) ((Integer) operand2).Value};
            }
            else
            {
                return new Float() {Value = this.Value + ((Float) operand2).Value};
            }
        }

        public override IDataType Subtract(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float() { Value = this.Value - (float)((Integer)operand2).Value };
            }
            else
            {
                return new Float() { Value = this.Value - ((Float)operand2).Value };
            }
        }

        public override IDataType Multiply(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float() { Value = this.Value * (float)((Integer)operand2).Value };
            }
            else
            {
                return new Float() { Value = this.Value * ((Float)operand2).Value };
            }
        }

        public override IDataType Divide(IDataType operand2)
        {
            if (operand2.type == DatatypeType.Integer)
            {
                return new Float() { Value = this.Value / (float)((Integer)operand2).Value };
            }
            else
            {
                return new Float() { Value = this.Value / ((Float)operand2).Value };
            }
        }

        public override string ValueAsString()
        {
            return Value.ToString();
        }
    }
}
