namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Speed()
    /// 
    /// Ex: double foo = new UnitOf.Speed().FromMilesPerHour(1.25).ToKilometersPerHour(); //One line conversion from 1.25 MilesPerHour to KilometersPerHour
    /// </summary>
    [Serializable]
    public class Speed : ConverterBase{
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
        /// <summary>
        /// Method to perform all conversions within Speed class.
        /// All "To" methods within Speed use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t,false);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Speed foo = new UnitOf.Speed().FromMilesPerHour(1.25); //Variable "foo" will be able to convert 1.25 MilesPerHour into any unit of Speed
        /// </summary>
        public Speed FromCentimetersPerHour(double v){return s(this,v,CMH,"CMH");}
        public Speed FromCentimetersPerMinute(double v){return s(this,v,CMM,"CMM");}
        public Speed FromCentimetersPerSecond(double v){return s(this,v,CMS,"CMS");}
        public Speed FromEarthsVelocity(double v){return s(this,v,EV,"EV");}
        public Speed FromFeetPerHour(double v){return s(this,v,FTH,"FTH");}
        public Speed FromFeetPerMinute(double v){return s(this,v,FTM,"FTM");}
        public Speed FromFeetPerSecond(double v){return s(this,v,FTS,"FTS");}
        public Speed FromFirstCosmicVelocity(double v){return s(this, v, CV1, "CV1");}
        public Speed FromInchesPerHour(double v){return s(this,v,INH,"INH");}
        public Speed FromInchesPerMinute(double v){return s(this,v,INM,"INM");}
        public Speed FromInchesPerSecond(double v){return s(this,v,INS,"INS");}
        public Speed FromKilometersPerHour(double v){return s(this,v,KMH,"KMH");}
        public Speed FromKilometersPerMinute(double v){return s(this,v,KMM,"KMM");}
        public Speed FromKilometersPerSecond(double v){return s(this,v,KMS,"KMS");}
        public Speed FromKnots(double v){return s(this,v,KN,"KN");}
        public Speed FromLight(double v){return s(this,v,C,"C");}
        public Speed FromMach(double v){return s(this,v,MA,"MA");}
        public Speed FromMetersPerHour(double v){return s(this,v,MH,"MH");}
        public Speed FromMetersPerMinute(double v){return s(this,v,MM,"MM");}
        public Speed FromMetersPerSecond(double v){return s(this,v,MS,"MS");}
        public Speed FromMilesPerHour(double v){return s(this,v,MIH,"MIH");}
        public Speed FromMilesPerMinute(double v){return s(this,v,MIM,"MIM");}
        public Speed FromMilesPerSecond(double v){return s(this,v,MIS,"MIS");}
        public Speed FromMillimetersPerHour(double v){return s(this,v,MMH,"MMH");}
        public Speed FromMillimetersPerMinute(double v){return s(this,v,MMM,"MMM");}
        public Speed FromMillimetersPerSecond(double v){return s(this,v,MMS,"MMS");}
        public Speed FromSecondCosmicVelocity(double v){return s(this,v,CV2,"CV2");}
        public Speed FromSoundsInAir(double v){return s(this, v, SA, "SA");}
        public Speed FromSoundsInWater(double v){return s(this, v, SW, "SW");}
        public Speed FromThirdCosmicVelocity(double v){return s(this, v, CV3, "CV3");}
        public Speed FromYardsPerHour(double v){return s(this,v,YH,"YH");}
        public Speed FromYardsPerMinute(double v){return s(this,v,YM,"YM");}
        public Speed FromYardsPerSecond(double v){return s(this,v,YS,"YS");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToKilometersPerHour(); //Variable "bar" being of type UnitOf.Speed with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Speed().FromMilesPerHour(1.25).ToKilometersPerHour(); //One line conversion from 1.25 MilesPerHour to KilometersPerHour
        /// </summary>
        public double ToCentimetersPerHour(){return c(CMH);}
        public double ToCentimetersPerMinute(){return c(CMM);}
        public double ToCentimetersPerSecond(){return c(CMS);}
        public double ToEarthsVelocity(){return c(EV);}
        public double ToFeetPerHour(){return c(FTH);}
        public double ToFeetPerMinute(){return c(FTM);}
        public double ToFeetPerSecond(){return c(FTS);}
        public double ToFirstCosmicVelocity(){return c(CV1);}
        public double ToInchesPerHour(){return c(INH);}
        public double ToInchesPerMinute(){return c(INM);}
        public double ToInchesPerSecond(){return c(INS);}
        public double ToKilometersPerHour(){return c(KMH);}
        public double ToKilometersPerMinute(){return c(KMM);}
        public double ToKilometersPerSecond(){return c(KMS);}
        public double ToKnots(){return c(KN);}
        public double ToLight(){return c(C);}
        public double ToMach(){return c(MA);}
        public double ToMetersPerHour(){return c(MH);}
        public double ToMetersPerMinute(){return c(MM);}
        public double ToMetersPerSecond(){return c(MS);}
        public double ToMilesPerHour(){return c(MIH);}
        public double ToMilesPerMinute(){return c(MIM);}
        public double ToMilesPerSecond(){return c(MIS);}
        public double ToMillimetersPerHour(){return c(MMH);}
        public double ToMillimetersPerMinute(){return c(MMM);}
        public double ToMillimetersPerSecond(){return c(MMS);}
        public double ToSecondCosmicVelocity(){return c(CV2);}
        public double ToSoundsInAir(){return c(SA);}
        public double ToSoundsInWater(){return c(SW);}
        public double ToThirdCosmicVelocity(){return c(CV3);}
        public double ToYardsPerHour(){return c(YH);}
        public double ToYardsPerMinute(){return c(YM);}
        public double ToYardsPerSecond(){return c(YS);}
    }

}