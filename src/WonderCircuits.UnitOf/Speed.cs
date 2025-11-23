using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Speed()
    /// 
    /// Ex: double foo = new UnitOf.Speed().FromMilesPerHour(1.25).ToKilometersPerHour(); //One line conversion from 1.25 MilesPerHour to KilometersPerHour
    /// </summary>
    public class Speed : UnitConverterBase
    {
        #region Constants
        internal static readonly double CMH = 1/36e4;             //Centimeter per Hour
        internal static readonly double CMM = 1/6e3;              //Centimeter per Minute
        internal static readonly double CMS = 1/1e2;              //Centimeter per Second 
        internal static readonly double EV = 29765;               //Earths Velocity
        internal static readonly double FTH = 1/11811.02362205;   //Feet per Hour
        internal static readonly double FTM = 0.00508;            //Feet per Minute
        internal static readonly double FTS = 0.3048;             //Feet per Second
        internal static readonly double CV1 = 7900;               //Cosmic Velocity First
        internal static readonly double INH = 7.0555555555e-6;    //Inch per Hour
        internal static readonly double INM = 4.2333333333e-4;    //Inch per Minute
        internal static readonly double INS = 0.0254;             //Inch per Second
        internal static readonly double KMH = 1/3.6;              //Kilometer per Hour
        internal static readonly double KMM = 1/6e-2;             //Kilometer per Minute
        internal static readonly double KMS = 1e3;                //Kilometer per Second
        internal static readonly double KN = 1/1.943844492441;    //Knot
        internal static readonly double C = 299792458;            //Light
        internal static readonly double MA = 295.0464000003;      //Mach SI Standard
        internal static readonly double MH = 1/36e2;              //Meters per Hour
        internal static readonly double MM = 1/60.0;              //Meters per Minute
        internal static readonly double MS = 1;                   //Meters per Second
        internal static readonly double MIH = 0.44704;            //Miles per Hour
        internal static readonly double MIM = 26.8224;            //Miles per Minute
        internal static readonly double MIS = 1609.344;           //Miles per Second
        internal static readonly double MMH = 1/36e5;             //Millimeter per Hour
        internal static readonly double MMM = 1/6e4;              //Millimeter per Minute
        internal static readonly double MMS = 1/1e3;              //Millimeter per Second   
        internal static readonly double CV2 = 11200;              //Cosmic Velocity Second
        internal static readonly double SA = 344;                 //Speed of Sound in Air
        internal static readonly double SW = 1482.7;              //Speed of Sound in Water
        internal static readonly double CV3 = 16670;              //Cosmic Velocity Third
        internal static readonly double YH = 0.000254;            //Yard per Hour
        internal static readonly double YM = 0.01524;             //Yard per Minute
        internal static readonly double YS = 0.9144;              //Yard per Second

        #endregion

        #region From Methods
        public Speed FromCentimetersPerHour(double v) { return From(v, CMH, "CMH"); }
        public Speed FromCentimetersPerMinute(double v) { return From(v, CMM, "CMM"); }
        public Speed FromCentimetersPerSecond(double v) { return From(v, CMS, "CMS"); }
        public Speed FromEarthsVelocity(double v) { return From(v, EV, "EV"); }
        public Speed FromFeetPerHour(double v) { return From(v, FTH, "FTH"); }
        public Speed FromFeetPerMinute(double v) { return From(v, FTM, "FTM"); }
        public Speed FromFeetPerSecond(double v) { return From(v, FTS, "FTS"); }
        public Speed FromFirstCosmicVelocity(double v) { return From(v, CV1, "CV1"); }
        public Speed FromInchesPerHour(double v) { return From(v, INH, "INH"); }
        public Speed FromInchesPerMinute(double v) { return From(v, INM, "INM"); }
        public Speed FromInchesPerSecond(double v) { return From(v, INS, "INS"); }
        public Speed FromKilometersPerHour(double v) { return From(v, KMH, "KMH"); }
        public Speed FromKilometersPerMinute(double v) { return From(v, KMM, "KMM"); }
        public Speed FromKilometersPerSecond(double v) { return From(v, KMS, "KMS"); }
        public Speed FromKnots(double v) { return From(v, KN, "KN"); }
        public Speed FromLight(double v) { return From(v, C, "C"); }
        public Speed FromMach(double v) { return From(v, MA, "MA"); }
        public Speed FromMetersPerHour(double v) { return From(v, MH, "MH"); }
        public Speed FromMetersPerMinute(double v) { return From(v, MM, "MM"); }
        public Speed FromMetersPerSecond(double v) { return From(v, MS, "MS"); }
        public Speed FromMilesPerHour(double v) { return From(v, MIH, "MIH"); }
        public Speed FromMilesPerMinute(double v) { return From(v, MIM, "MIM"); }
        public Speed FromMilesPerSecond(double v) { return From(v, MIS, "MIS"); }
        public Speed FromMillimetersPerHour(double v) { return From(v, MMH, "MMH"); }
        public Speed FromMillimetersPerMinute(double v) { return From(v, MMM, "MMM"); }
        public Speed FromMillimetersPerSecond(double v) { return From(v, MMS, "MMS"); }
        public Speed FromSecondCosmicVelocity(double v) { return From(v, CV2, "CV2"); }
        public Speed FromSoundsInAir(double v) { return From(v, SA, "SA"); }
        public Speed FromSoundsInWater(double v) { return From(v, SW, "SW"); }
        public Speed FromThirdCosmicVelocity(double v) { return From(v, CV3, "CV3"); }
        public Speed FromYardsPerHour(double v) { return From(v, YH, "YH"); }
        public Speed FromYardsPerMinute(double v) { return From(v, YM, "YM"); }
        public Speed FromYardsPerSecond(double v) { return From(v, YS, "YS"); }

        private Speed From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToCentimetersPerHour() { return To(CMH); }
        public double ToCentimetersPerMinute() { return To(CMM); }
        public double ToCentimetersPerSecond() { return To(CMS); }
        public double ToEarthsVelocity() { return To(EV); }
        public double ToFeetPerHour() { return To(FTH); }
        public double ToFeetPerMinute() { return To(FTM); }
        public double ToFeetPerSecond() { return To(FTS); }
        public double ToFirstCosmicVelocity() { return To(CV1); }
        public double ToInchesPerHour() { return To(INH); }
        public double ToInchesPerMinute() { return To(INM); }
        public double ToInchesPerSecond() { return To(INS); }
        public double ToKilometersPerHour() { return To(KMH); }
        public double ToKilometersPerMinute() { return To(KMM); }
        public double ToKilometersPerSecond() { return To(KMS); }
        public double ToKnots() { return To(KN); }
        public double ToLight() { return To(C); }
        public double ToMach() { return To(MA); }
        public double ToMetersPerHour() { return To(MH); }
        public double ToMetersPerMinute() { return To(MM); }
        public double ToMetersPerSecond() { return To(MS); }
        public double ToMilesPerHour() { return To(MIH); }
        public double ToMilesPerMinute() { return To(MIM); }
        public double ToMilesPerSecond() { return To(MIS); }
        public double ToMillimetersPerHour() { return To(MMH); }
        public double ToMillimetersPerMinute() { return To(MMM); }
        public double ToMillimetersPerSecond() { return To(MMS); }
        public double ToSecondCosmicVelocity() { return To(CV2); }
        public double ToSoundsInAir() { return To(SA); }
        public double ToSoundsInWater() { return To(SW); }
        public double ToThirdCosmicVelocity() { return To(CV3); }
        public double ToYardsPerHour() { return To(YH); }
        public double ToYardsPerMinute() { return To(YM); }
        public double ToYardsPerSecond() { return To(YS); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant, false);
        }

        #endregion
    }

}