﻿using System;

namespace ANTLR_Sample.DataTypes
{
    abstract class IDataType
    {
        public DatatypeType type;

        /// <summary>
        /// Defines how Datatype adds to an datatype
        /// </summary>
        /// <param name="operand2">Right side operand</param>
        /// <returns>Result</returns>
        public abstract IDataType Add(IDataType operand2);

        /// <summary>
        /// Defines how Datatype subs to an datatype
        /// </summary>
        /// <param name="operand2">Right side operand</param>
        /// <returns>Result</returns>
        public abstract IDataType Subtract(IDataType operand2);

        /// <summary>
        /// Defines how Datatype multiplied to an datatype
        /// </summary>
        /// <param name="operand2">Right side operand</param>
        /// <returns>Result</returns>
        public abstract IDataType Multiply(IDataType operand2);

        /// <summary>
        /// Defines how Datatype divided to an datatype
        /// </summary>
        /// <param name="operand2">Right side operand</param>
        /// <returns>Result</returns>
        public abstract IDataType Divide(IDataType operand2);

        public abstract string ValueAsString();
    }
}