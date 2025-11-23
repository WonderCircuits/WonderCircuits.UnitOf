using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.FuelEconomy()
    /// 
    /// Ex: double foo = new UnitOf.FuelEconomy().FromMetersPerCubicMeter(1.25).ToMetersPerLiter(); //One line conversion from 1.25 MetersPerCubicMeter to MetersPerLiter
    /// </summary>
    public class FuelEconomy : UnitConverterBase
    {
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

        #region From Methods
        public FuelEconomy FromCentimetersPerLiter(double v) { return From(v, CML, "CML"); }
        public FuelEconomy FromDekametersPerLiter(double v) { return From(v, DAML, "DAML"); }
        public FuelEconomy FromExametersPerLiter(double v) { return From(v, EML, "EML"); }
        public FuelEconomy FromGigametersPerLiter(double v) { return From(v, GML, "GML"); }
        public FuelEconomy FromHectometersPerLiter(double v) { return From(v, HML, "HML"); }
        public FuelEconomy FromKilometersPerGallonUK(double v) { return From(v, KMGALUK, "KMGALUK"); }
        public FuelEconomy FromKilometersPerGallonUS(double v) { return From(v, KMGALUS, "KMGALUS"); }
        public FuelEconomy FromKilometersPerLiter(double v) { return From(v, KML, "KML"); }
        public FuelEconomy FromMegametersPerLiter(double v) { return From(v, MML, "MML"); }
        public FuelEconomy FromMetersPerCubicCentimeter(double v) { return From(v, MCM, "MCM"); }
        public FuelEconomy FromMetersPerCubicFoot(double v) { return From(v, MFT, "MFT"); }
        public FuelEconomy FromMetersPerCubicInch(double v) { return From(v, MIN, "MIN"); }
        public FuelEconomy FromMetersPerCubicMeter(double v) { return From(v, MM, "MM"); }
        public FuelEconomy FromMetersPerCubicYard(double v) { return From(v, MYD, "MYD"); }
        public FuelEconomy FromMetersPerCupUK(double v) { return From(v, MCUPUK, "MCUPUK"); }
        public FuelEconomy FromMetersPerCupUS(double v) { return From(v, MCUPUS, "MCUPUS"); }
        public FuelEconomy FromMetersPerFluidOunceUK(double v) { return From(v, MFOZUK, "MFOZUK"); }
        public FuelEconomy FromMetersPerFluidOunceUS(double v) { return From(v, MFOZUS, "MFOZUS"); }
        public FuelEconomy FromMetersPerGallonUK(double v) { return From(v, MGALUK, "MGALUK"); }
        public FuelEconomy FromMetersPerGallonUS(double v) { return From(v, MGALUS, "MGALUS"); }
        public FuelEconomy FromMetersPerLiter(double v) { return From(v, ML, "ML"); }
        public FuelEconomy FromMetersPerPintUK(double v) { return From(v, MPTUK, "MPTUK"); }
        public FuelEconomy FromMetersPerPintUS(double v) { return From(v, MPTUS, "MPTUS"); }
        public FuelEconomy FromMetersPerQuartUK(double v) { return From(v, MQTUK, "MQTUK"); }
        public FuelEconomy FromMetersPerQuartUS(double v) { return From(v, MQTUS, "MQTUS"); }
        public FuelEconomy FromMilesPerGallonUK(double v) { return From(v, MIGALUK, "MIGALUK"); }
        public FuelEconomy FromMilesPerGallonUS(double v) { return From(v, MIGALUS, "MIGALUS"); }
        public FuelEconomy FromMilesPerLiterUS(double v) { return From(v, MIL, "MIL"); }
        public FuelEconomy FromNauticalMilesPerGallonUS(double v) { return From(v, NMIGAL, "NMIGAL"); }
        public FuelEconomy FromNauticalMilesPerLiter(double v) { return From(v, NMIL, "NMIL"); }
        public FuelEconomy FromPetametersPerLiter(double v) { return From(v, PML, "PML"); }
        public FuelEconomy FromTerametersPerLiter(double v) { return From(v, TML, "TML"); }

        private FuelEconomy From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToCentimetersPerLiter() { return To(CML); }
        public double ToDekametersPerLiter() { return To(DAML); }
        public double ToExametersPerLiter() { return To(EML); }
        public double ToGigametersPerLiter() { return To(GML); }
        public double ToHectometersPerLiter() { return To(HML); }
        public double ToKilometersPerGallonUK() { return To(KMGALUK); }
        public double ToKilometersPerGallonUS() { return To(KMGALUS); }
        public double ToKilometersPerLiter() { return To(KML); }
        public double ToMegametersPerLiter() { return To(MML); }
        public double ToMetersPerCubicCentimeter() { return To(MCM); }
        public double ToMetersPerCubicFoot() { return To(MFT); }
        public double ToMetersPerCubicInch() { return To(MIN); }
        public double ToMetersPerCubicMeter() { return To(MM); }
        public double ToMetersPerCubicYard() { return To(MYD); }
        public double ToMetersPerCupUK() { return To(MCUPUK); }
        public double ToMetersPerCupUS() { return To(MCUPUS); }
        public double ToMetersPerFluidOunceUK() { return To(MFOZUK); }
        public double ToMetersPerFluidOunceUS() { return To(MFOZUS); }
        public double ToMetersPerGallonUK() { return To(MGALUK); }
        public double ToMetersPerGallonUS() { return To(MGALUS); }
        public double ToMetersPerLiter() { return To(ML); }
        public double ToMetersPerPintUK() { return To(MPTUK); }
        public double ToMetersPerPintUS() { return To(MPTUS); }
        public double ToMetersPerQuartUK() { return To(MQTUK); }
        public double ToMetersPerQuartUS() { return To(MQTUS); }
        public double ToMilesPerGallonUK() { return To(MIGALUK); }
        public double ToMilesPerGallonUS() { return To(MIGALUS); }
        public double ToMilesPerLiterUS() { return To(MIL); }
        public double ToNauticalMilesPerGallonUS() { return To(NMIGAL); }
        public double ToNauticalMilesPerLiter() { return To(NMIL); }
        public double ToPetametersPerLiter() { return To(PML); }
        public double ToTerametersPerLiter() { return To(TML); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.MeasumentValue, true);
        }
        #endregion
    }
}