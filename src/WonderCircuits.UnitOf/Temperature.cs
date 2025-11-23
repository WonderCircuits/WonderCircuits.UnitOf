using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Temperature()
    /// 
    /// Ex: double foo = new UnitOf.Temperature().FromCelsius(1.25).ToFahrenheit(); //One line conversion from 1.25 Celsius to Fahrenheit
    /// </summary>
    [Serializable]
    public class Temperature : UnitConverterBase
    {
        #region Constants
        internal const int C = 1; //Celsius 
        internal const int F = 2; //Fahrenheit 
        internal const int K = 3; //kelvin 
        internal const int R = 4; //Rankine 
        internal const int RE = 5;//Reaumur
        #endregion


        #region From Methods
        public Temperature FromCelsius(double v) { return From(v, C, "C"); }
        public Temperature FromFahrenheit(double v) { return From(v, F, "F"); }
        public Temperature FromKelvin(double v) { return From(v, K, "K"); }
        public Temperature FromRankine(double v) { return From(v, R, "R"); }
        public Temperature FromReaumur(double v) { return From(v, RE, "RE"); }

        private Temperature From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToCelsius() { return c(C); }
        public double ToFahrenheit() { return c(F); }
        public double ToKelvin() { return c(K); }
        public double ToRankine() { return c(R); }
        public double ToReaumur() { return c(RE); }

        private double ToCelsius(double v, double t)
        {
            switch ((int)t)
            {
                case F: return (v-32) / 1.8;
                case K: return v - 273.15;
                case R: return (v - 491.67) * (5.0 / 9.0);
                case RE: return v * 1.25;
                default: return v;
            }
        }

        private double FromCelsiusToType(double v, double t)
        {
            switch ((int)t)
            {
                case F: return (v * 1.8) + 32;
                case K: return v + 273.15;
                case R: return (v + 273.15) * 1.8;
                case RE: return v * 0.8;
                default: return v;
            }
        }

        private double c(double t)
        {
            return FromCelsiusToType(ToCelsius(Varaibles.Value, Varaibles.FromConstant), t);
        }
        #endregion
    }
}