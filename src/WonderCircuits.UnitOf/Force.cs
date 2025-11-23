using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Force()
    /// 
    /// Ex: double foo = new UnitOf.Force().FromNewtons(1.25).ToPoundForces(); //One line conversion from 1.25 Newtons to PoundForces
    /// </summary>
    public class Force : UnitConverterBase
    {
        #region Constants
        internal static readonly double AUF = 12137804.11081;         //Atomic Unit of Force
        internal static readonly double AN = 1e18;                    //Attonewton
        internal static readonly double CN = 1e2;                     //Centinewton
        internal static readonly double DN = 1e1;                     //DeciNewton
        internal static readonly double DAN = 1e-1;                   //Dekanewton  
        internal static readonly double DYN = 1e5;                    //Dyne
        internal static readonly double EN = 1e-18;                   //Exanewton
        internal static readonly double FN = 1e15;                    //Femtonewton
        internal static readonly double GN = 1e-9;                    //Giganewton
        internal static readonly double GF = 1/9.80665e-3;            //Gram Force
        internal static readonly double GFF = 1/9.80665;              //Grave Force
        internal static readonly double HN = 1e-2;                    //Hectonewton 
        internal static readonly double JCM = 1e2;                    //Joule per Centimeter 
        internal static readonly double JM = 1;                       //Joule per Meter
        internal static readonly double KGF = 1/9.80665;              //Kilogram force
        internal static readonly double KN = 1e-3;                    //Kilonewton
        internal static readonly double KP = 1/9.80665;               //Kilopond
        internal static readonly double KIP = 1/4448.221615255;       //Kilopound Force
        internal static readonly double LTF = 1/9964.01641818352;     //Long Ton Force
        internal static readonly double MN = 1e-6;                    //Meganewton
        internal static readonly double TFM = 1/9806.65;              //Ton Force (Metric)
        internal static readonly double MUN = 1e6;                    //Micronewton
        internal static readonly double MGF = 1/9.80665e-3;           //Milligrave Force
        internal static readonly double MILN = 1e3;                   //Millinewton
        internal static readonly double NN = 1e9;                     //Nanonewton
        internal static readonly double N = 1;                        //Newton
        internal static readonly double OZF = 1/0.27801385095378125;  //Ounce Force
        internal static readonly double PEN = 1e-15;                  //Petanewton
        internal static readonly double PN = 1e12;                    //Piconewton
        internal static readonly double P = 1/9.80665e-3;             //Pond
        internal static readonly double LBFT = 1/0.138254954376;      //Pound Foot per Second Squared
        internal static readonly double LBF = 1/4.4482216152605;      //Pound Force
        internal static readonly double PDL = 1/0.138254954376;       //Poundal
        internal static readonly double TFS = 1/8896.443230521;       //Ton Force (Short)
        internal static readonly double SN = 1/1e3;                   //Sthene
        internal static readonly double TN = 1e-12;                   //Teranewton   

        #endregion

        #region From Methods
        public Force FromAtomicUnitsOfForce(double v) { return From(v, AUF, "AUF"); }
        public Force FromAttonewtons(double v) { return From(v, AN, "AN"); }
        public Force FromCentinewtons(double v) { return From(v, CN, "CN"); }
        public Force FromDecinewtons(double v) { return From(v, DN, "DN"); }
        public Force FromDekanewtons(double v) { return From(v, DAN, "DAN"); }
        public Force FromDynes(double v) { return From(v, DYN, "DYN"); }
        public Force FromExanewtons(double v) { return From(v, EN, "EN"); }
        public Force FromFemtonewtons(double v) { return From(v, FN, "FN"); }
        public Force FromGiganewtons(double v) { return From(v, GN, "GN"); }
        public Force FromGramForces(double v) { return From(v, GF, "GF"); }
        public Force FromGraveForces(double v) { return From(v, GFF, "GFF"); }
        public Force FromHectonewtons(double v) { return From(v, HN, "HN"); }
        public Force FromJouleCentimeters(double v) { return From(v, JCM, "JCM"); }
        public Force FromJouleMeters(double v) { return From(v, JM, "JM"); }
        public Force FromKilogramForces(double v) { return From(v, KGF, "KGF"); }
        public Force FromKilonewtons(double v) { return From(v, KN, "KN"); }
        public Force FromKiloponds(double v) { return From(v, KP, "KP"); }
        public Force FromKilopoundForces(double v) { return From(v, KIP, "KIP"); }
        public Force FromLongTonForces(double v) { return From(v, LTF, "LTF"); }
        public Force FromMeganewtons(double v) { return From(v, MN, "MN"); }
        public Force FromMetricTonForces(double v) { return From(v, TFM, "TFM"); }
        public Force FromMicronewtons(double v) { return From(v, MUN, "MUN"); }
        public Force FromMilligraveForces(double v) { return From(v, MGF, "MGF"); }
        public Force FromMillinewtons(double v) { return From(v, MILN, "MILN"); }
        public Force FromNanonewtons(double v) { return From(v, NN, "NN"); }
        public Force FromNewtons(double v) { return From(v, N, "N"); }
        public Force FromOunceForces(double v) { return From(v, OZF, "OZF"); }
        public Force FromPetanewtons(double v) { return From(v, PEN, "PEN"); }
        public Force FromPiconewtons(double v) { return From(v, PN, "PN"); }
        public Force FromPonds(double v) { return From(v, P, "P"); }
        public Force FromPoundFeetPerSecondSquared(double v) { return From(v, LBFT, "LBFT"); }
        public Force FromPoundForces(double v) { return From(v, LBF, "LBF"); }
        public Force FromPoundals(double v) { return From(v, PDL, "PDL"); }
        public Force FromShortTonForces(double v) { return From(v, TFS, "TFS"); }
        public Force FromSthenes(double v) { return From(v, SN, "SN"); }
        public Force FromTeranewtons(double v) { return From(v, TN, "TN"); }

        private Force From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAtomicUnitsOfForce() { return To(AUF); }
        public double ToAttonewtons() { return To(AN); }
        public double ToCentinewtons() { return To(CN); }
        public double ToDecinewtons() { return To(DN); }
        public double ToDekanewtons() { return To(DAN); }
        public double ToDynes() { return To(DYN); }
        public double ToExanewtons() { return To(EN); }
        public double ToFemtonewtons() { return To(FN); }
        public double ToGiganewtons() { return To(GN); }
        public double ToGramForces() { return To(GF); }
        public double ToGraveForces() { return To(GFF); }
        public double ToHectonewtons() { return To(HN); }
        public double ToJouleCentimeters() { return To(JCM); }
        public double ToJouleMeters() { return To(JM); }
        public double ToKilogramForces() { return To(KGF); }
        public double ToKilonewtons() { return To(KN); }
        public double ToKiloponds() { return To(KP); }
        public double ToKilopoundForces() { return To(KIP); }
        public double ToLongTonForces() { return To(LTF); }
        public double ToMeganewtons() { return To(MN); }
        public double ToMetricTonForces() { return To(TFM); }
        public double ToMicronewtons() { return To(MUN); }
        public double ToMilligraveForces() { return To(MGF); }
        public double ToMillinewtons() { return To(MILN); }
        public double ToNanonewtons() { return To(NN); }
        public double ToNewtons() { return To(N); }
        public double ToOunceForces() { return To(OZF); }
        public double ToPetanewtons() { return To(PEN); }
        public double ToPiconewtons() { return To(PN); }
        public double ToPonds() { return To(P); }
        public double ToPoundFeetPerSecondSquared() { return To(LBFT); }
        public double ToPoundForces() { return To(LBF); }
        public double ToPoundals() { return To(PDL); }
        public double ToShortTonForces() { return To(TFS); }
        public double ToSthenes() { return To(SN); }
        public double ToTeranewtons() { return To(TN); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.MeasumentValue, true);
        }
        #endregion
    }
}