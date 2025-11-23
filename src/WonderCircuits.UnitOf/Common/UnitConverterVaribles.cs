using System;

namespace WonderCircuits.UnitOf.Common
{
    /// <summary>
    /// Instantiated variables from new UnitOf instance (Only used in class B).
    /// </summary>
    public struct UnitConverterVaribles
    {
        /// <summary>
        /// Only used in class B.cs when measurement "From" method only converts numbers.
        /// All measurements other than DataType use this constructor.
        /// </summary>
        /// <param name="w">User passed "From" value (double).</param>
        /// <param name="s">Struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <param name="z">String value of struct readonly constant representing the "From" method of the measurement used.</param>
        public UnitConverterVaribles(double w, double s, string z)
        {
            Value = w;
            FromConstant = s;
            FromType = z;
        }

        public double Value { get; private set; } //User passed "From" value (double). When this is the case, variable "o" is not used.
        public double FromConstant { get; private set; }  //Struct readonly constant value representing the "From" method of the measurement used.
        public string FromType { get; private set; } //String value of struct readonly constant representing the "From" method of the measurement used.
    }
}

