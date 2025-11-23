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
        /// <param name="value">User passed "From" value (double).</param>
        /// <param name="measumentValue">Struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <param name="measumentName">String value of struct readonly constant representing the "From" method of the measurement used.</param>
        public UnitConverterVaribles(double value, double measumentValue, string measumentName)
        {
            Value = value;
            MeasumentValue = measumentValue;
            MeasumentName = measumentName;
        }

        public double Value { get; private set; } //User passed "From" value (double). When this is the case, variable "o" is not used.
        public string MeasumentName { get; private set; } //String value of struct readonly constant representing the "From" method of the measurement used.
        public double MeasumentValue { get; private set; }  //Struct readonly constant value representing the "From" method of the measurement used.
    }
}

