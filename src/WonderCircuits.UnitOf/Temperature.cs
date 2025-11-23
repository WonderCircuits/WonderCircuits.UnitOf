namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Temperature()
    /// 
    /// Ex: double foo = new UnitOf.Temperature().FromCelsius(1.25).ToFahrenheit(); //One line conversion from 1.25 Celsius to Fahrenheit
    /// </summary>
    [Serializable]
    public class Temperature : ConverterBase{

        #region Constants
        internal const int C = 1; //Celsius 
        internal const int F = 2; //Fahrenheit 
        internal const int K = 3; //kelvin 
        internal const int R = 4; //Rankine 
        internal const int RE = 5;//Reaumur
        #endregion

        /// <summary>
        /// Method to perform all conversions within Temperature class.
        /// All "To" methods within Temperature use this method.
        /// </summary>
        private double c(double t){
            return FromCelsiusToType(ToCelsius(me.v, me.t), t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Temperature foo = new UnitOf.Temperature().FromCelsius(1.25); //Variable "foo" will be able to convert 1.25 Celsius into any unit of Temperature
        /// </summary>
        public Temperature FromCelsius(double v){return s(this,v, C,"C");}
        public Temperature FromFahrenheit(double v){return s(this,v, F,"F");}
        public Temperature FromKelvin(double v){return s(this,v, K,"K");}
        public Temperature FromRankine(double v){return s(this,v, R,"R");}
        public Temperature FromReaumur(double v){return s(this,v, RE,"RE");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToFahrenheit(); //Variable "bar" being of type UnitOf.Temperature with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Temperature().FromCelsius(1.25).ToFahrenheit(); //One line conversion from 1.25 Celsius to Fahrenheit
        /// </summary>
        public double ToCelsius(){return c(C);}
        public double ToFahrenheit(){return c(F);}
        public double ToKelvin(){return c(K);}
        public double ToRankine(){return c(R);}
        public double ToReaumur(){return c(RE);}

        /// <summary>
        /// Only used in Temperature's conversion method.
        /// converts value passed of any Temperature unit into Celsius
        /// </summary>
        private double ToCelsius(double v, double t){
            switch((int)t){
                case F: return (v-32) / 1.8;
                case K: return v - 273.15;
                case R: return (v - 491.67) * (5.0 / 9.0);
                case RE: return v * 1.25;
                default: return v;
            }
        }

        /// <summary>
        /// Only used in Temperature's conversion method.
        /// Converts Celsius value passed into any Temperature unit.
        /// </summary>
        private double FromCelsiusToType(double v, double t){
            switch((int)t){
                case F: return (v * 1.8) + 32;
                case K: return v + 273.15;
                case R: return (v + 273.15) * 1.8;
                case RE: return v * 0.8;
                default: return v;
            }
        }
    }
}