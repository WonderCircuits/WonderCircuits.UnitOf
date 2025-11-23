using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Area()
    /// 
    /// Ex: double foo = new UnitOf.Area().fromSquareMeters(1.25).toAcres(); //One line conversion from 1.25 SquareMeters to Acres
    /// </summary>
    public class Area : UnitConverterBase
    {
        #region Constants
        internal static readonly double AC = 1/4046.8564224;  //Acre
        internal static readonly double A = 1e-2;             //Are
        internal static readonly double AR = 1/3418.740000066;//Arpent
        internal static readonly double B = 1e28;             //Barn
        internal static readonly double CRIN = 1973.52524139; //Circular Inch
        internal static readonly double CRMIL = 1973525241.39;//Circular Mil
        internal static readonly double HA = 1e-4;            //Hactare
        internal static readonly double HS = 1/647497.027584; //Homestead 
        internal static readonly double R = 1/1011.7141056;   //Rood
        internal static readonly double S = 1/0.09290304;     //Sabin
        internal static readonly double C = 1e4;              //Square Centimeter
        internal static readonly double CH = 1/404.68564224;  //Square Chain
        internal static readonly double D = 1e2;              //Square Decimeter
        internal static readonly double DA = 1e-2;            //Square Dekameter
        internal static readonly double FT = 1/0.09290304;    //Square Foot
        internal static readonly double H = 1e-4;             //Square Hectometer
        internal static readonly double IN = 1/0.00064516;    //Square Inch
        internal static readonly double K = 1e-6;             //Square Kilometer
        internal static readonly double M = 1;                //Square Meter
        internal static readonly double MU = 1e12;            //Square Micrometer  
        internal static readonly double MI = 1/2589988.110336;//Square Mile
        internal static readonly double MIL = 1e6;            //Square millimeter  
        internal static readonly double N = 1e18;             //Square Nanometer
        internal static readonly double PE = 1/25.29285264;   //Square Perch
        internal static readonly double PO = 1/25.29285264;   //Square Pole
        internal static readonly double ROD = 1/25.29285264;  //Square Rod
        internal static readonly double YD = 1/0.83612736;    //Square Yard

        #endregion

        #region From Methods
        public Area FromAcres(double v) { return From(v, AC, "AC"); }
        public Area FromAres(double v) { return From(v, A, "A"); }
        public Area FromArpents(double v) { return From(v, AR, "AR"); }
        public Area FromBarns(double v) { return From(v, B, "B"); }
        public Area FromCircularInches(double v) { return From(v, CRIN, "CRIN"); }
        public Area FromCircularMils(double v) { return From(v, CRMIL, "CRMIL"); }
        public Area FromHectares(double v) { return From(v, HA, "HA"); }
        public Area FromHomesteads(double v) { return From(v, HS, "HS"); }
        public Area FromRoods(double v) { return From(v, R, "R"); }
        public Area FromSabins(double v) { return From(v, S, "S"); }
        public Area FromSquareCentimeters(double v) { return From(v, C, "C"); }
        public Area FromSquareChains(double v) { return From(v, CH, "CH"); }
        public Area FromSquareDecimeters(double v) { return From(v, D, "D"); }
        public Area FromSquareDekameters(double v) { return From(v, DA, "DA"); }
        public Area FromSquareFeet(double v) { return From(v, FT, "FT"); }
        public Area FromSquareHectometers(double v) { return From(v, H, "H"); }
        public Area FromSquareInches(double v) { return From(v, IN, "IN"); }
        public Area FromSquareKilometers(double v) { return From(v, K, "K"); }
        public Area FromSquareMeters(double v) { return From(v, M, "M"); }
        public Area FromSquareMicrometers(double v) { return From(v, MU, "MU"); }
        public Area FromSquareMiles(double v) { return From(v, MI, "MI"); }
        public Area FromSquareMillimeters(double v) { return From(v, MIL, "MIL"); }
        public Area FromSquareNanometers(double v) { return From(v, N, "N"); }
        public Area FromSquarePerches(double v) { return From(v, PE, "PE"); }
        public Area FromSquarePoles(double v) { return From(v, PO, "PO"); }
        public Area FromSquareRods(double v) { return From(v, ROD, "ROD"); }
        public Area FromSquareYards(double v) { return From(v, YD, "YD"); }

        private Area From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAcres() { return To(AC); }
        public double ToAres() { return To(A); }
        public double ToArpents() { return To(AR); }
        public double ToBarns() { return To(B); }
        public double ToCircularInches() { return To(CRIN); }
        public double ToCircularMils() { return To(CRMIL); }
        public double ToHectares() { return To(HA); }
        public double ToHomesteads() { return To(HS); }
        public double ToRoods() { return To(R); }
        public double ToSabins() { return To(S); }
        public double ToSquareCentimeters() { return To(C); }
        public double ToSquareChains() { return To(CH); }
        public double ToSquareDecimeters() { return To(D); }
        public double ToSquareDekameters() { return To(DA); }
        public double ToSquareFeet() { return To(FT); }
        public double ToSquareHectometers() { return To(H); }
        public double ToSquareInches() { return To(IN); }
        public double ToSquareKilometers() { return To(K); }
        public double ToSquareMeters() { return To(M); }
        public double ToSquareMicrometers() { return To(MU); }
        public double ToSquareMiles() { return To(MI); }
        public double ToSquareMillimeters() { return To(MIL); }
        public double ToSquareNanometers() { return To(N); }
        public double ToSquarePerches() { return To(PE); }
        public double ToSquarePoles() { return To(PO); }
        public double ToSquareRods() { return To(ROD); }
        public double ToSquareYards() { return To(YD); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }

        #endregion
    }
}