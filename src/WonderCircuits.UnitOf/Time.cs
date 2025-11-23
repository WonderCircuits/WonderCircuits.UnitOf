using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Time()
    /// 
    /// Ex: double foo = new UnitOf.Time().FromMinutes(1.25).ToHours(); //One line conversion from 1.25 Minutes to Hours
    /// </summary>
    [Serializable]
    public class Time : UnitConverterBase
    {
        #region Constants
        internal static readonly double AS = 1e18;            //Attoseconds
        internal static readonly double C = 1/31536e5;        //Centuries
        internal static readonly double D = 1/864e2;          //Days
        internal static readonly double DE = 1/31536e4;       //Decades
        internal static readonly double FS = 1e15;            //Femtoseconds
        internal static readonly double FN = 1/1209600.0;     //Fortnight
        internal static readonly double GY = 1/31556952.00001;//Gregorian Years
        internal static readonly double H = 1/36e2;           //Hours
        internal static readonly double JY = 1/31557600.0;    //Yulian Years
        internal static readonly double LY = 1/31622400.0;    //Leap Years
        internal static readonly double MUS = 1e6;            //Microseconds
        internal static readonly double M = 1/31536e6;        //Millenniums
        internal static readonly double MS = 1e3;             //Milliseconds
        internal static readonly double MIN = 1/60.0;         //Minutes
        internal static readonly double MON = 1/2628000.0;    //Months
        internal static readonly double NS = 1e9;             //Nanoseconds
        internal static readonly double PS = 1e12;            //Picoseconds
        internal static readonly double S = 1;                //Seconds
        internal static readonly double WK = 1/604800.0;      //Weeks
        internal static readonly double Y = 1/31536e3;        //Years

        #endregion

        #region From Methods
        public Time FromAttoseconds(double v) { return From(v, AS, "AS"); }
        public Time FromCenturies(double v) { return From(v, C, "C"); }
        public Time FromDays(double v) { return From(v, D, "D"); }
        public Time FromDecades(double v) { return From(v, DE, "DE"); }
        public Time FromFemtoseconds(double v) { return From(v, FS, "FS"); }
        public Time FromFortnights(double v) { return From(v, FN, "FN"); }
        public Time FromGregorianYears(double v) { return From(v, GY, "GY"); }
        public Time FromHours(double v) { return From(v, H, "H"); }
        public Time FromJulianYears(double v) { return From(v, JY, "JY"); }
        public Time FromLeapYears(double v) { return From(v, LY, "LY"); }
        public Time FromMicroseconds(double v) { return From(v, MUS, "MUS"); }
        public Time FromMillenniums(double v) { return From(v, M, "M"); }
        public Time FromMilliseconds(double v) { return From(v, MS, "MS"); }
        public Time FromMinutes(double v) { return From(v, MIN, "MIN"); }
        public Time FromMonths(double v) { return From(v, MON, "MON"); }
        public Time FromNanoseconds(double v) { return From(v, NS, "NS"); }
        public Time FromPicoseconds(double v) { return From(v, PS, "PS"); }
        public Time FromSeconds(double v) { return From(v, S, "S"); }
        public Time FromWeeks(double v) { return From(v, WK, "WK"); }
        public Time FromYears(double v) { return From(v, Y, "Y"); }

        private Time From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods

        public double ToAttoseconds() { return To(AS); }
        public double ToCenturies() { return To(C); }
        public double ToDays() { return To(D); }
        public double ToDecades() { return To(DE); }
        public double ToFemtoseconds() { return To(FS); }
        public double ToFortnights() { return To(FN); }
        public double ToGregorianYears() { return To(GY); }
        public double ToHours() { return To(H); }
        public double ToJulianYears() { return To(JY); }
        public double ToLeapYears() { return To(LY); }
        public double ToMicroseconds() { return To(MUS); }
        public double ToMillenniums() { return To(M); }
        public double ToMilliseconds() { return To(MS); }
        public double ToMinutes() { return To(MIN); }
        public double ToMonths() { return To(MON); }
        public double ToNanoseconds() { return To(NS); }
        public double ToPicoseconds() { return To(PS); }
        public double ToSeconds() { return To(S); }
        public double ToWeeks() { return To(WK); }
        public double ToYears() { return To(Y); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }
        #endregion
    }
}