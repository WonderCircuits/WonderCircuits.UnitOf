namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.FuelEconomy()
    /// 
    /// Ex: double foo = new UnitOf.FuelEconomy().FromMetersPerCubicMeter(1.25).ToMetersPerLiter(); //One line conversion from 1.25 MetersPerCubicMeter to MetersPerLiter
    /// </summary>
    [Serializable]
    public class FuelEconomy : ConverterBase{

        #region Constants
        internal static readonly double CML = 1e5;                //Centimeter per Liter
        internal static readonly double DAML = 1e2;               //Dekameter per Liter
        internal static readonly double EML = 1e-15;              //Exameter per Liter
        internal static readonly double GML = 1e-6;               //Gigameter per Liter
        internal static readonly double HML = 1e1;                //Hectometer per Liter
        internal static readonly double KMGALUK = 4.546099293921; //Kilometer per Gallon (UK)
        internal static readonly double KMGALUS = 3.7854117834;   //Kilometer per Gallon (US)
        internal static readonly double KML = 1;                  //Kilometer per Liter
        internal static readonly double MML = 1e-3;               //Megameter per Liter
        internal static readonly double MCM = 1;                  //Meter per Cubic Centimeter
        internal static readonly double MFT = 28316.84659319;     //Meter per Cubic Foot
        internal static readonly double MIN = 16.38706400127;     //Meter per Cubic Inch
        internal static readonly double MM = 1e6;                 //Meter per Cubic Meter
        internal static readonly double MYD = 764554.8581679;     //Meter per Cubic Yard
        internal static readonly double MCUPUK = 284.1312059185;  //Meter per Cup (UK)
        internal static readonly double MCUPUS = 236.5882364849;  //Meter per Cup (US)
        internal static readonly double MFOZUK = 28.41312059185;  //Meter per Fluid Ounce (UK)
        internal static readonly double MFOZUS = 29.57352956411;  //Meter per Fluid Ounce (US)
        internal static readonly double MGALUK = 4546.099293921;  //Meter per Gallon (UK)
        internal static readonly double MGALUS = 3785.4117834;    //Meter per Gallon (US)
        internal static readonly double ML = 1e3;                 //Meter per Liter
        internal static readonly double MPTUK = 568.2624116755;   //Meter per Pint (UK)
        internal static readonly double MPTUS = 473.1764729698;   //Meter per Pint (US)
        internal static readonly double MQTUK = 1136.524822963;   //Meter per Quart (UK)
        internal static readonly double MQTUS = 946.3529463874;   //Meter per Quart (US)
        internal static readonly double MIGALUK = 2.824809362797; //Mile per Gallon (UK)
        internal static readonly double MIGALUS = 2.352145832948; //Mile per Gallon (US)
        internal static readonly double MIL = 1/1.609344;         //Mile per Liter (US)
        internal static readonly double NMIGAL = 1/0.4895755247;  //Nautical Mile per Gallon (US)   
        internal static readonly double NMIL = 1/1.85324496;      //Nautical Mile per Liter
        internal static readonly double PML = 1e-12;              //Petameter per Liter
        internal static readonly double TML = 1e-9;               //Terameter per Liter   

        #endregion

        /// <summary>
        /// Method to perform all conversions within FuelEconomy class.
        /// All "To" methods within FuelEconomy use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.FuelEconomy foo = new UnitOf.FuelEconomy().FromMetersPerCubicMeter(1.25); //Variable "foo" will be able to convert 1.25 MetersPerCubicMeter into any unit of FuelEconomy
        /// </summary>
        public FuelEconomy FromCentimetersPerLiter(double v){return s(this,v,CML,"CML");}
        public FuelEconomy FromDekametersPerLiter(double v){return s(this,v,DAML,"DAML");}
        public FuelEconomy FromExametersPerLiter(double v){return s(this,v,EML,"EML");}
        public FuelEconomy FromGigametersPerLiter(double v){return s(this,v,GML,"GML");}
        public FuelEconomy FromHectometersPerLiter(double v){return s(this,v,HML,"HML");}
        public FuelEconomy FromKilometersPerGallonUK(double v){return s(this, v, KMGALUK, "KMGALUK");}
        public FuelEconomy FromKilometersPerGallonUS(double v){return s(this,v,KMGALUS,"KMGALUS");}
        public FuelEconomy FromKilometersPerLiter(double v){return s(this,v,KML,"KML");}
        public FuelEconomy FromMegametersPerLiter(double v){return s(this,v,MML,"MML");}
        public FuelEconomy FromMetersPerCubicCentimeter(double v){return s(this, v, MCM, "MCM");}
        public FuelEconomy FromMetersPerCubicFoot(double v){return s(this, v, MFT, "MFT");}
        public FuelEconomy FromMetersPerCubicInch(double v){return s(this, v, MIN, "MIN");}
        public FuelEconomy FromMetersPerCubicMeter(double v){return s(this, v, MM, "MM");}
        public FuelEconomy FromMetersPerCubicYard(double v){return s(this, v, MYD, "MYD");}
        public FuelEconomy FromMetersPerCupUK(double v){return s(this,v,MCUPUK,"MCUPUK");}
        public FuelEconomy FromMetersPerCupUS(double v){return s(this,v,MCUPUS,"MCUPUS");}
        public FuelEconomy FromMetersPerFluidOunceUK(double v){return s(this,v,MFOZUK,"MFOZUK");}
        public FuelEconomy FromMetersPerFluidOunceUS(double v){return s(this,v,MFOZUS,"MFOZUS");}
        public FuelEconomy FromMetersPerGallonUK(double v){return s(this,v,MGALUK,"MGALUK");}
        public FuelEconomy FromMetersPerGallonUS(double v){return s(this, v, MGALUS, "MGALUS");}
        public FuelEconomy FromMetersPerLiter(double v){return s(this,v,ML,"ML");}
        public FuelEconomy FromMetersPerPintUK(double v){return s(this,v,MPTUK,"MPTUK");}
        public FuelEconomy FromMetersPerPintUS(double v){return s(this,v,MPTUS,"MPTUS");}
        public FuelEconomy FromMetersPerQuartUK(double v){return s(this,v,MQTUK,"MQTUK");}
        public FuelEconomy FromMetersPerQuartUS(double v){return s(this,v,MQTUS,"MQTUS");}
        public FuelEconomy FromMilesPerGallonUK(double v){return s(this,v,MIGALUK,"MIGALUK");}
        public FuelEconomy FromMilesPerGallonUS(double v){return s(this,v,MIGALUS,"MIGALUS");}
        public FuelEconomy FromMilesPerLiterUS(double v){return s(this,v,MIL,"MIL");}
        public FuelEconomy FromNauticalMilesPerGallonUS(double v){return s(this,v,NMIGAL,"NMIGAL");}
        public FuelEconomy FromNauticalMilesPerLiter(double v){return s(this,v,NMIL,"NMIL");}
        public FuelEconomy FromPetametersPerLiter(double v){return s(this,v,PML,"PML");}
        public FuelEconomy FromTerametersPerLiter(double v){return s(this,v,TML,"TML");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToMetersPerLiter(); //Variable "bar" being of type UnitOf.FuelEconomy with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.FuelEconomy().FromMetersPerCubicMeter(1.25).ToMetersPerLiter(); //One line conversion from 1.25 MetersPerCubicMeter to MetersPerLiter
        /// </summary>
        public double ToCentimetersPerLiter(){return c(CML);}
        public double ToDekametersPerLiter(){return c(DAML);}
        public double ToExametersPerLiter(){return c(EML);}
        public double ToGigametersPerLiter(){return c(GML);}
        public double ToHectometersPerLiter(){return c(HML);}
        public double ToKilometersPerGallonUK(){return c(KMGALUK);}
        public double ToKilometersPerGallonUS(){return c(KMGALUS);}
        public double ToKilometersPerLiter(){return c(KML);}
        public double ToMegametersPerLiter(){return c(MML);}
        public double ToMetersPerCubicCentimeter(){return c(MCM);}
        public double ToMetersPerCubicFoot(){return c(MFT);}
        public double ToMetersPerCubicInch(){return c(MIN);}
        public double ToMetersPerCubicMeter(){return c(MM);}
        public double ToMetersPerCubicYard(){return c(MYD);}
        public double ToMetersPerCupUK(){return c(MCUPUK);}
        public double ToMetersPerCupUS(){return c(MCUPUS);}
        public double ToMetersPerFluidOunceUK(){return c(MFOZUK);}
        public double ToMetersPerFluidOunceUS(){return c(MFOZUS);}
        public double ToMetersPerGallonUK(){return c(MGALUK);}
        public double ToMetersPerGallonUS(){return c(MGALUS);}
        public double ToMetersPerLiter(){return c(ML);}
        public double ToMetersPerPintUK(){return c(MPTUK);}
        public double ToMetersPerPintUS(){return c(MPTUS);}
        public double ToMetersPerQuartUK(){return c(MQTUK);}
        public double ToMetersPerQuartUS(){return c(MQTUS);}
        public double ToMilesPerGallonUK(){return c(MIGALUK);}
        public double ToMilesPerGallonUS(){return c(MIGALUS);}
        public double ToMilesPerLiterUS(){return c(MIL);}
        public double ToNauticalMilesPerGallonUS(){return c(NMIGAL);}
        public double ToNauticalMilesPerLiter(){return c(NMIL);}
        public double ToPetametersPerLiter(){return c(PML);}
        public double ToTerametersPerLiter(){return c(TML);}
    }
}