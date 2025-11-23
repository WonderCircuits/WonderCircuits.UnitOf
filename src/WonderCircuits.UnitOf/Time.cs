namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Time()
    /// 
    /// Ex: double foo = new UnitOf.Time().FromMinutes(1.25).ToHours(); //One line conversion from 1.25 Minutes to Hours
    /// </summary>
    [Serializable]
    public class Time : ConverterBase{
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
        /// <summary>
        /// Method to perform all conversions within Time class.
        /// All "To" methods within Time use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Time foo = new UnitOf.Time().FromMinutes(1.25); //Variable "foo" will be able to convert 1.25 Minutes into any unit of Time
        /// </summary>
        public Time FromAttoseconds(double v){return s(this,v,AS,"AS");}
        public Time FromCenturies(double v){return s(this,v,C,"C");}
        public Time FromDays(double v){return s(this,v,D,"D");}
        public Time FromDecades(double v){return s(this,v,DE,"DE");}
        public Time FromFemtoseconds(double v){return s(this,v,FS,"FS");}
        public Time FromFortnights(double v){return s(this,v,FN,"FN");}
        public Time FromGregorianYears(double v){return s(this,v,GY,"GY");}
        public Time FromHours(double v){return s(this,v,H,"H");}
        public Time FromJulianYears(double v){return s(this,v,JY,"JY");}
        public Time FromLeapYears(double v){return s(this,v,LY,"LY");}
        public Time FromMicroseconds(double v){return s(this,v,MUS,"MUS");}
        public Time FromMillenniums(double v){return s(this,v,M,"M");}
        public Time FromMilliseconds(double v){return s(this,v,MS,"MS");}
        public Time FromMinutes(double v){return s(this,v,MIN,"MIN");}
        public Time FromMonths(double v){return s(this,v,MON,"MON");}
        public Time FromNanoseconds(double v){return s(this,v,NS,"NS");}
        public Time FromPicoseconds(double v){return s(this,v,PS,"PS");}
        public Time FromSeconds(double v){return s(this,v,S,"S");}
        public Time FromWeeks(double v){return s(this,v,WK,"WK");}
        public Time FromYears(double v){return s(this,v,Y,"Y");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToHours(); //Variable "bar" being of type UnitOf.Time with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Time().FromMinutes(1.25).ToHours(); //One line conversion from 1.25 Minutes to Hours
        /// </summary>
        public double ToAttoseconds(){return c(AS);}
        public double ToCenturies(){return c(C);}
        public double ToDays(){return c(D);}
        public double ToDecades(){return c(DE);}
        public double ToFemtoseconds(){return c(FS);}
        public double ToFortnights(){return c(FN);}
        public double ToGregorianYears(){return c(GY);}
        public double ToHours(){return c(H);}
        public double ToJulianYears(){return c(JY);}
        public double ToLeapYears(){return c(LY);}
        public double ToMicroseconds(){return c(MUS);}
        public double ToMillenniums(){return c(M);}
        public double ToMilliseconds(){return c(MS);}
        public double ToMinutes(){return c(MIN);}
        public double ToMonths(){return c(MON);}
        public double ToNanoseconds(){return c(NS);}
        public double ToPicoseconds(){return c(PS);}
        public double ToSeconds(){return c(S);}
        public double ToWeeks(){return c(WK);}
        public double ToYears(){return c(Y);}
    }
}