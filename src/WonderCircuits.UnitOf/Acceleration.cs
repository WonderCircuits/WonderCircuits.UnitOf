namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Acceleration()
    /// 
    /// Ex: double foo = new UnitOf.Acceleration().FromGravity(1.25).ToGalileos(); //One line conversion from 1.25 Gravity to Galileos
    /// </summary>
    [Serializable]
    public class Acceleration : ConverterBase {

        #region Constants
        internal static readonly double AS = 1e-18;           //Attometer per Second Squared
        internal static readonly double CS = 1e-2;            //Centimeter per Second Squared
        internal static readonly double DS = 1e-1;            //Decimeter per Second Squared
        internal static readonly double DAS = 1e1;            //Dekameter per Second Squared
        internal static readonly double ES = 1e18;            //Exameter per Second Squared
        internal static readonly double FTHS = 0.000084666666666667;//Foot per Hour per Second
        internal static readonly double FTMS = 0.00508;       //Foot/Minute per Second
        internal static readonly double FTS = 0.3048;         //Foot per Second Squared
        internal static readonly double FS = 1e-15;           //Femtometer per Second Squared
        internal static readonly double GAL = 1/1e2;          //Galileo
        internal static readonly double GS = 1e9;             //Gigameter per Second Squared
        internal static readonly double G = 9.80665;          //Gravity
        internal static readonly double HS = 1e2;             //Hectometer per Second Squared
        internal static readonly double INMS = 0.0004233333;  //Inch per Minute per Second
        internal static readonly double INS = 0.0254;         //Inch per Second Squared
        internal static readonly double KHS = 1/3.6;          //Kilometers per Hour per Second
        internal static readonly double KH = 1/12960.0;       //Kilometers per Hour Squared
        internal static readonly double KS = 1e3;             //Kilometer per Second Squared
        internal static readonly double KNS = 0.514444444444; //Knot per Second
        internal static readonly double MGS = 1e6;            //Megameter per Second Squared
        internal static readonly double MS = 1;               //Meter per Second Squared
        internal static readonly double MUGAL = 1/1e8;        //Microgalileo
        internal static readonly double MUS = 1e-6;           //Micrometerper Second Squared
        internal static readonly double MIHS = 0.44704;       //Mile per Hour per Second
        internal static readonly double MIMS = 26.8224;       //Mile per Minute per Second
        internal static readonly double MIS = 1609.344;       //Mile per Second Squared
        internal static readonly double MILGAL = 1/1e5;       //Milligalileo
        internal static readonly double MILS = 1e-3;          //Millimeter per Second Squared
        internal static readonly double NS = 1e-9;            //Nanometer per Second Squared
        internal static readonly double PES = 1e15;           //Petameter per Second Squared
        internal static readonly double PS = 1e-12;           //Picometer per Second Squared
        internal static readonly double TS = 1e12;            //Terameter per Second Squared
        internal static readonly double YDS = 0.9144;         //Yard per Second Squared
        #endregion

        /// <summary>
        /// Method to perform all conversions within Acceleration class.
        /// All "To" methods within Acceleration use this metho
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t,false);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Acceleration foo = new UnitOf.Acceleration().FromGravity(1.25); //Variable "foo" will be able to convert 1.25 Gravity into any unit of Acceleration
        /// </summary>
        public Acceleration FromAttometersPerSecondSquared(double v){return s(this,v,AS,"AS");}
        public Acceleration FromCentimeterPerSecondSquared(double v){return s(this,v,CS,"CS");}
        public Acceleration FromDecimetersPerSecondSquared(double v){return s(this,v,DS,"DS");}
        public Acceleration FromDekametersPerSecondSquared(double v){return s(this,v,DAS,"DAS");}
        public Acceleration FromExametersPerSecondSquared(double v){return s(this,v,ES,"ES");}
        public Acceleration FromFeetPerHourPerSecond(double v){return s(this,v,FTHS,"FTHS");}
        public Acceleration FromFeetPerMinutePerSecond(double v){return s(this,v,FTMS,"FTMS");}
        public Acceleration FromFeetPerSecondSquared(double v){return s(this,v,FTS,"FTS");}
        public Acceleration FromFemtometersPerSecondSquared(double v){return s(this,v,FS,"FS");}
        public Acceleration FromGalileos(double v){return s(this,v,GAL,"GAL");}
        public Acceleration FromGigametersPerSecondSquared(double v){return s(this,v,GS,"GS");}
        public Acceleration FromGravity(double v){return s(this,v,G,"G");}
        public Acceleration FromHectometersPerSecondSquared(double v){return s(this,v,HS,"HS");}
        public Acceleration FromInchesPerMinutePerSecond(double v){return s(this,v,INMS,"INMS");}
        public Acceleration FromInchesPerSecondSquared(double v){return s(this,v,INS,"INS");}
        public Acceleration FromKilometersPerHourPerSecond(double v){return s(this,v,KHS,"KHS");}
        public Acceleration FromKilometersPerHourSquared(double v){return s(this,v,KH,"KH");}
        public Acceleration FromKilometersPerSecondSquared(double v){return s(this,v,KS,"KS");}
        public Acceleration FromKnotsPerSecond(double v){return s(this,v,KNS,"KNS");}
        public Acceleration FromMegametersPerSecondSquared(double v){return s(this,v,MGS,"MGS");}
        public Acceleration FromMetersPerSecondSquared(double v){return s(this,v,MS,"MS");}
        public Acceleration FromMicrogalileos(double v){return s(this,v,MUGAL,"MUGAL");}
        public Acceleration FromMicrometersPerSecondSquared(double v){return s(this,v,MUS,"MUS");}
        public Acceleration FromMilesPerHourPerSecond(double v){return s(this,v,MIHS,"MIHS");}
        public Acceleration FromMilesPerMinutePerSecond(double v){return s(this,v,MIMS,"MIMS");}
        public Acceleration FromMilesPerSecondSquared(double v){return s(this,v,MIS,"MIS");}
        public Acceleration FromMilligalileos(double v){return s(this,v,MILGAL,"MILGAL");}
        public Acceleration FromMillimetersPerSecondSquared(double v){return s(this,v,MILS,"MILS");}
        public Acceleration FromNanometersPerSecondSquared(double v){return s(this,v,NS,"NS");}
        public Acceleration FromPetametersPerSecondSquared(double v){return s(this,v,PES,"PES");}
        public Acceleration FromPicometersPerSecondSquared(double v){return s(this,v,PS,"PS");}
        public Acceleration FromTerametersPerSecondSquared(double v){return s(this,v,TS,"TS");}
        public Acceleration FromYardsPerSecondSquared(double v){return s(this,v,YDS,"YDS");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToGalileos(); //Variable "bar" being of type UnitOf.Acceleration with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Acceleration().FromGravity(1.25).ToGalileos(); //One line conversion from 1.25 Gravity to Galileos
        /// </summary>
        public double ToAttometersPerSecondSquared(){return c(AS);}
        public double ToCentimeterPerSecondSquared(){return c(CS);}
        public double ToDecimetersPerSecondSquared(){return c(DS);}
        public double ToDekametersPerSecondSquared(){return c(DAS);}
        public double ToExametersPerSecondSquared(){return c(ES);}
        public double ToFeetPerHourPerSecond(){return c(FTHS);}
        public double ToFeetPerMinutePerSecond(){return c(FTMS);}
        public double ToFeetPerSecondSquared(){return c(FTS);}
        public double ToFemtometersPerSecondSquared(){return c(FS);}
        public double ToGalileos(){return c(GAL);}
        public double ToGigametersPerSecondSquared(){return c(GS);}
        public double ToGravity(){return c(G);}
        public double ToHectometersPerSecondSquared(){return c(HS);}
        public double ToInchesPerMinutePerSecond(){return c(INMS);}
        public double ToInchesPerSecondSquared(){return c(INS);}
        public double ToKilometersPerHourPerSecond(){return c(KHS);} 
        public double ToKilometersPerHourSquared(){return c(KH);} 
        public double ToKilometersPerSecondSquared(){return c(KS);}
        public double ToKnotsPerSecond(){return c(KNS);}
        public double ToMegametersPerSecondSquared(){return c(MGS);}
        public double ToMetersPerSecondSquared(){return c(MS);}
        public double ToMicrogalileos(){return c(MUGAL);}
        public double ToMicrometersPerSecondSquared(){return c(MUS);}
        public double ToMilesPerHourPerSecond(){return c(MIHS);}
        public double ToMilesPerMinutePerSecond(){return c(MIMS);}
        public double ToMilesPerSecondSquared(){return c(MIS);} 
        public double ToMilligalileos(){return c(MILGAL);}
        public double ToMillimetersPerSecondSquared(){return c(MILS);}
        public double ToNanometersPerSecondSquared(){return c(NS);}
        public double ToPetametersPerSecondSquared(){return c(PES);}
        public double ToPicometersPerSecondSquared(){return c(PS);}
        public double ToTerametersPerSecondSquared(){return c(TS);}
        public double ToYardsPerSecondSquared(){return c(YDS);}
    }
}