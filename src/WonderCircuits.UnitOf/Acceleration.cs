using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Acceleration()
    /// 
    /// Ex: double foo = new UnitOf.Acceleration().FromGravity(1.25).ToGalileos(); //One line conversion from 1.25 Gravity to Galileos
    /// </summary>
    [Serializable]
    public class Acceleration : UnitConverterBase
    {
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

        #region From Methods
        public Acceleration FromAttometersPerSecondSquared(double v) { return From(v, AS, "AS"); }
        public Acceleration FromCentimeterPerSecondSquared(double v) { return From(v, CS, "CS"); }
        public Acceleration FromDecimetersPerSecondSquared(double v) { return From(v, DS, "DS"); }
        public Acceleration FromDekametersPerSecondSquared(double v) { return From(v, DAS, "DAS"); }
        public Acceleration FromExametersPerSecondSquared(double v) { return From(v, ES, "ES"); }
        public Acceleration FromFeetPerHourPerSecond(double v) { return From(v, FTHS, "FTHS"); }
        public Acceleration FromFeetPerMinutePerSecond(double v) { return From(v, FTMS, "FTMS"); }
        public Acceleration FromFeetPerSecondSquared(double v) { return From(v, FTS, "FTS"); }
        public Acceleration FromFemtometersPerSecondSquared(double v) { return From(v, FS, "FS"); }
        public Acceleration FromGalileos(double v) { return From(v, GAL, "GAL"); }
        public Acceleration FromGigametersPerSecondSquared(double v) { return From(v, GS, "GS"); }
        public Acceleration FromGravity(double v) { return From(v, G, "G"); }
        public Acceleration FromHectometersPerSecondSquared(double v) { return From(v, HS, "HS"); }
        public Acceleration FromInchesPerMinutePerSecond(double v) { return From(v, INMS, "INMS"); }
        public Acceleration FromInchesPerSecondSquared(double v) { return From(v, INS, "INS"); }
        public Acceleration FromKilometersPerHourPerSecond(double v) { return From(v, KHS, "KHS"); }
        public Acceleration FromKilometersPerHourSquared(double v) { return From(v, KH, "KH"); }
        public Acceleration FromKilometersPerSecondSquared(double v) { return From(v, KS, "KS"); }
        public Acceleration FromKnotsPerSecond(double v) { return From(v, KNS, "KNS"); }
        public Acceleration FromMegametersPerSecondSquared(double v) { return From(v, MGS, "MGS"); }
        public Acceleration FromMetersPerSecondSquared(double v) { return From(v, MS, "MS"); }
        public Acceleration FromMicrogalileos(double v) { return From(v, MUGAL, "MUGAL"); }
        public Acceleration FromMicrometersPerSecondSquared(double v) { return From(v, MUS, "MUS"); }
        public Acceleration FromMilesPerHourPerSecond(double v) { return From(v, MIHS, "MIHS"); }
        public Acceleration FromMilesPerMinutePerSecond(double v) { return From(v, MIMS, "MIMS"); }
        public Acceleration FromMilesPerSecondSquared(double v) { return From(v, MIS, "MIS"); }
        public Acceleration FromMilligalileos(double v) { return From(v, MILGAL, "MILGAL"); }
        public Acceleration FromMillimetersPerSecondSquared(double v) { return From(v, MILS, "MILS"); }
        public Acceleration FromNanometersPerSecondSquared(double v) { return From(v, NS, "NS"); }
        public Acceleration FromPetametersPerSecondSquared(double v) { return From(v, PES, "PES"); }
        public Acceleration FromPicometersPerSecondSquared(double v) { return From(v, PS, "PS"); }
        public Acceleration FromTerametersPerSecondSquared(double v) { return From(v, TS, "TS"); }
        public Acceleration FromYardsPerSecondSquared(double v) { return From(v, YDS, "YDS"); }

        private Acceleration From(double v,double tt,string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAttometersPerSecondSquared() { return To(AS); }
        public double ToCentimeterPerSecondSquared() { return To(CS); }
        public double ToDecimetersPerSecondSquared() { return To(DS); }
        public double ToDekametersPerSecondSquared() { return To(DAS); }
        public double ToExametersPerSecondSquared() { return To(ES); }
        public double ToFeetPerHourPerSecond() { return To(FTHS); }
        public double ToFeetPerMinutePerSecond() { return To(FTMS); }
        public double ToFeetPerSecondSquared() { return To(FTS); }
        public double ToFemtometersPerSecondSquared() { return To(FS); }
        public double ToGalileos() { return To(GAL); }
        public double ToGigametersPerSecondSquared() { return To(GS); }
        public double ToGravity() { return To(G); }
        public double ToHectometersPerSecondSquared() { return To(HS); }
        public double ToInchesPerMinutePerSecond() { return To(INMS); }
        public double ToInchesPerSecondSquared() { return To(INS); }
        public double ToKilometersPerHourPerSecond() { return To(KHS); }
        public double ToKilometersPerHourSquared() { return To(KH); }
        public double ToKilometersPerSecondSquared() { return To(KS); }
        public double ToKnotsPerSecond() { return To(KNS); }
        public double ToMegametersPerSecondSquared() { return To(MGS); }
        public double ToMetersPerSecondSquared() { return To(MS); }
        public double ToMicrogalileos() { return To(MUGAL); }
        public double ToMicrometersPerSecondSquared() { return To(MUS); }
        public double ToMilesPerHourPerSecond() { return To(MIHS); }
        public double ToMilesPerMinutePerSecond() { return To(MIMS); }
        public double ToMilesPerSecondSquared() { return To(MIS); }
        public double ToMilligalileos() { return To(MILGAL); }
        public double ToMillimetersPerSecondSquared() { return To(MILS); }
        public double ToNanometersPerSecondSquared() { return To(NS); }
        public double ToPetametersPerSecondSquared() { return To(PES); }
        public double ToPicometersPerSecondSquared() { return To(PS); }
        public double ToTerametersPerSecondSquared() { return To(TS); }
        public double ToYardsPerSecondSquared() { return To(YDS); }

        private double To(double to)
        {
            return Conversion(to, Varaibles.MeasumentValue, false);
        }
        #endregion

       
    }
}