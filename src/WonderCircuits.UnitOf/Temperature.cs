using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Temperature()
    /// 
    /// Ex: double foo = new UnitOf.Temperature().FromCelsius(1.25).ToFahrenheit(); //One line conversion from 1.25 Celsius to Fahrenheit
    /// </summary>
    public class Temperature : UnitConverterBase
    {
        #region Constants
        internal const double C = 1; //Celsius 
        internal const double F = 2; //Fahrenheit 
        internal const double K = 3; //kelvin 
        internal const double R = 4; //Rankine 
        internal const double RE = 5;//Reaumur
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
        public double ToCelsius() { return To(C); }
        public double ToFahrenheit() { return To(F); }
        public double ToKelvin() { return To(K); }
        public double ToRankine() { return To(R); }
        public double ToReaumur() { return To(RE); }

        private double To(double t)
        {
            //1. 统一转换为Celsius单位。
            var cel = ToCelsius(Varaibles.Value, Varaibles.MeasumentValue);

            //2. 根据需要转换的单位进行换算。
            switch (t)
            {
                case F: return (cel * 1.8) + 32;
                case K: return cel + 273.15;
                case R: return (cel + 273.15) * 1.8;
                case RE: return cel * 0.8;
                default: return cel;
            }
        }
        private double ToCelsius(double v, double t)
        {
            switch (t)
            {
                case F: return (v-32) / 1.8;
                case K: return v - 273.15;
                case R: return (v - 491.67) * (5.0 / 9.0);
                case RE: return v * 1.25;
                default: return v;
            }
        }
        #endregion
    }
}