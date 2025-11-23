using System;

namespace WonderCircuits.UnitOf.Common
{
    /// <summary>
    /// Generic base class for most UnitOf measurement classes
    /// </summary>
    public abstract class UnitConverterBase
    {
        protected UnitConverterVaribles Varaibles { get; private set; } 

        /// <summary>
        /// Stores the needed values to do conversions of the measurement.
        /// This overload of the method is used in "From" methods in every measurement class other than Anything() and DataType().
        /// </summary>
        /// <param name="t">Class context of measurement passed (usually "this" is passed from caller).</param>
        /// <param name="value">User passed "From" value (double).</param>
        /// <param name="measumentValue">Struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <param name="ty">String value of the struct readonly constant value representing the "From" method of the measurement used.</param>
        /// <returns>class context passed in so variable like "UnitOf.Length len" can be used as the variable type</returns>
        protected void Store(double value, double measumentValue, string measumentName)
        {
            Varaibles = new UnitConverterVaribles(value, measumentValue, measumentName);
        }

        /// <summary>
        /// Used by every measurement class that converts just numbers (Anything() and DataType() do not apply here).
        /// Method performs the full conversion of taking the user defined "From" value and converting it into the user desired "To" value.
        /// </summary>
        /// <param name="to">Struct readonly constant value of "To" unit. Unit being converted into conversion constant value.</param>
        /// <param name="isMultiplyThenDivide">Multiply then divide conversion algorithm, false will divide then multiply when converting "To"</param>
        /// <returns>Finished conversion. "from" converted into "to" value.</returns>
        protected double Conversion(double to, bool isMultiplyThenDivide)
        {
            var fromValue = MultiplyOrDivide(Varaibles.Value, to, isMultiplyThenDivide);
            return MultiplyOrDivide(fromValue, Varaibles.MeasumentValue, !isMultiplyThenDivide);
        }

        /// <summary>
        /// All conversions use the following method to multiply or divide depending on how the measurement's units are defined (See struct readonly constants).
        /// </summary>
        static double MultiplyOrDivide(double n, double d, bool isMultiply)
        {
            return isMultiply ? (n * d) : (n / d);
        }
    }
}