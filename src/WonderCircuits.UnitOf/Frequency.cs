using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Frequency()
    /// 
    /// Ex: double foo = new UnitOf.Frequency().FromHertz(1.25).ToCyclesPerSecond(); //One line conversion from 1.25 Hertz to CyclesPerSecond
    /// </summary>
    [Serializable]
    public class Frequency : UnitConverterBase
    {
        #region Constants
        internal static readonly double AHZ = 1e24;   //Attohertz 
        internal static readonly double CHZ = 1e8;    //Centihertz
        internal static readonly double CS = 1e6;     //Cycle per Second
        internal static readonly double DHZ = 1e7;    //Decihertz   
        internal static readonly double DAHZ = 1e5;   //Dekahertz   
        internal static readonly double EHZ = 1e-12;  //Exahertz
        internal static readonly double FHZ = 1e21;   //Femtohertz 
        internal static readonly double GHZ = 1e-3;   //Gigahertz
        internal static readonly double HHZ = 1e4;    //Hectohertz  
        internal static readonly double HZ = 1e6;     //Hertz
        internal static readonly double KHZ = 1e3;    //Kilohertz 
        internal static readonly double MHZ = 1;      //Megahertz
        internal static readonly double MUHZ = 1e12;  //Microhertz
        internal static readonly double MIHZ = 1e9;   //Millihertz
        internal static readonly double NHZ = 1e15;   //Nanohertz
        internal static readonly double PEHZ = 1e-9;  //Petahertz
        internal static readonly double PHZ = 1e18;   //Picohertz 
        internal static readonly double RD = 864e8;   //Revolution per Day 
        internal static readonly double RH = 36e8;    //Revolution per Hour
        internal static readonly double RM = 6e7;     //Revolution per Minute
        internal static readonly double RS = 1e6;     //Revolution per Second
        internal static readonly double THZ = 1e-6;   //Terahertz

        #endregion

        #region From Methods
        public Frequency FromAttohertz(double v) { return From(v, AHZ, "AHZ"); }
        public Frequency FromCentihertz(double v) { return From(v, CHZ, "CHZ"); }
        public Frequency FromCyclesPerSecond(double v) { return From(v, CS, "CS"); }
        public Frequency FromDecihertz(double v) { return From(v, DHZ, "DHZ"); }
        public Frequency FromDekahertz(double v) { return From(v, DAHZ, "DAHZ"); }
        public Frequency FromExahertz(double v) { return From(v, EHZ, "EHZ"); }
        public Frequency FromFemtohertz(double v) { return From(v, FHZ, "FHZ"); }
        public Frequency FromGigahertz(double v) { return From(v, GHZ, "GHZ"); }
        public Frequency FromHectohertz(double v) { return From(v, HHZ, "HHZ"); }
        public Frequency FromHertz(double v) { return From(v, HZ, "HZ"); }
        public Frequency FromKilohertz(double v) { return From(v, KHZ, "KHZ"); }
        public Frequency FromMegahertz(double v) { return From(v, MHZ, "MHZ"); }
        public Frequency FromMicrohertz(double v) { return From(v, MUHZ, "MUHZ"); }
        public Frequency FromMillihertz(double v) { return From(v, MIHZ, "MIHZ"); }
        public Frequency FromNanohertz(double v) { return From(v, NHZ, "NHZ"); }
        public Frequency FromPetahertz(double v) { return From(v, PEHZ, "PEHZ"); }
        public Frequency FromPicohertz(double v) { return From(v, PHZ, "PHZ"); }
        public Frequency FromRevolutionsPerDay(double v) { return From(v, RD, "RD"); }
        public Frequency FromRevolutionsPerHour(double v) { return From(v, RH, "RH"); }
        public Frequency FromRevolutionsPerMinute(double v) { return From(v, RM, "RM"); }
        public Frequency FromRevolutionsPerSecond(double v) { return From(v, RS, "RS"); }
        public Frequency FromTerahertz(double v) { return From(v, THZ, "THZ"); }

        private Frequency From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAttohertz() { return To(AHZ); }
        public double ToCentihertz() { return To(CHZ); }
        public double ToCyclesPerSecond() { return To(CS); }
        public double ToDecihertz() { return To(DHZ); }
        public double ToDekahertz() { return To(DAHZ); }
        public double ToExahertz() { return To(EHZ); }
        public double ToFemtohertz() { return To(FHZ); }
        public double ToGigahertz() { return To(GHZ); }
        public double ToHectohertz() { return To(HHZ); }
        public double ToHertz() { return To(HZ); }
        public double ToKilohertz() { return To(KHZ); }
        public double ToMegahertz() { return To(MHZ); }
        public double ToMicrohertz() { return To(MUHZ); }
        public double ToMillihertz() { return To(MIHZ); }
        public double ToNanohertz() { return To(NHZ); }
        public double ToPetahertz() { return To(PEHZ); }
        public double ToPicohertz() { return To(PHZ); }
        public double ToRevolutionsPerDay() { return To(RD); }
        public double ToRevolutionsPerHour() { return To(RH); }
        public double ToRevolutionsPerMinute() { return To(RM); }
        public double ToRevolutionsPerSecond() { return To(RS); }
        public double ToTerahertz() { return To(THZ); }

        /// <summary>
        /// Method to perform all conversions within Frequency class.
        /// All "To" methods within Frequency use this method.
        /// </summary>
        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }
        #endregion
    }
}