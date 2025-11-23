using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Torque()
    /// 
    /// Ex: double foo = new UnitOf.Torque().FromNewtonMeters(1.25).ToGramMeters(); //One line conversion from 1.25 NewtonMeters to GramMeters
    /// </summary>
    [Serializable]
    public class Torque : UnitConverterBase
    {
        #region Constants
        internal static readonly double DYNCM = 9.80665e7;        //Dyne Centimeter
        internal static readonly double DYNM = 9.80665e5;         //Dyne Meter
        internal static readonly double DYNMM = 9.80665e8;        //Dyne Millimeter
        internal static readonly double GFCM = 1e5;               //Gram Force Centimeter
        internal static readonly double GFM = 1e3;                //Gram Force Meter
        internal static readonly double GFMM = 1e6;               //Gram Force Millimeter
        internal static readonly double KGFCM = 1e2;              //Kilogram Force Centimeter
        internal static readonly double KGFM = 1;                 //Kilogram Force Meter
        internal static readonly double KGFMM = 1e3;              //Kilogram Force Millimeter
        internal static readonly double KNM = 9.80665e-3;         //Kilonewton Meter
        internal static readonly double NCM = 9.80665e2;          //Newton Centimeter
        internal static readonly double NM = 9.80665;             //Newton Meter
        internal static readonly double NMM = 9.80665e3;          //Newton Millimeter
        internal static readonly double OZFFT = 115.7282185748;   //Ounce Force Foot
        internal static readonly double OZFIN = 1388.738622898;   //Ounce Force Inch
        internal static readonly double LBFFT = 7.23301357557;    //Pound Force Foot
        internal static readonly double LBFIN = 86.79616290684;   //Pound Force Inch

        #endregion

        #region From Methods
        public Torque FromDyneCentimeters(double v) { return From(v, DYNCM, "DYNCM"); }
        public Torque FromDyneMeters(double v) { return From(v, DYNM, "DYNM"); }
        public Torque FromDyneMillimeters(double v) { return From(v, DYNMM, "DYNMM"); }
        public Torque FromGramCentimeters(double v) { return From(v, GFCM, "GFCM"); }
        public Torque FromGramMeters(double v) { return From(v, GFM, "GFM"); }
        public Torque FromGramMillimeters(double v) { return From(v, GFMM, "GFMM"); }
        public Torque FromKilogramCentimeters(double v) { return From(v, KGFCM, "KGFCM"); }
        public Torque FromKilogramMeters(double v) { return From(v, KGFM, "KGFM"); }
        public Torque FromKilogramMillimeters(double v) { return From(v, KGFMM, "KGFMM"); }
        public Torque FromKilonewtonMeters(double v) { return From(v, KNM, "KNM"); }
        public Torque FromNewtonCentimeters(double v) { return From(v, NCM, "NCM"); }
        public Torque FromNewtonMeters(double v) { return From(v, NM, "NM"); }
        public Torque FromNewtonMillimeters(double v) { return From(v, NMM, "NMM"); }
        public Torque FromOunceFeet(double v) { return From(v, OZFFT, "OZFFT"); }
        public Torque FromOunceInches(double v) { return From(v, OZFIN, "OZFIN"); }
        public Torque FromPoundFeet(double v) { return From(v, LBFFT, "LBFFT"); }
        public Torque FromPoundInches(double v) { return From(v, LBFIN, "LBFIN"); }

        private Torque From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToDyneCentimeters() { return To(DYNCM); }
        public double ToDyneMeters() { return To(DYNM); }
        public double ToDyneMillimeters() { return To(DYNMM); }
        public double ToGramCentimeters() { return To(GFCM); }
        public double ToGramMeters() { return To(GFM); }
        public double ToGramMillimeters() { return To(GFMM); }
        public double ToKilogramCentimeters() { return To(KGFCM); }
        public double ToKilogramMeters() { return To(KGFM); }
        public double ToKilogramMillimeters() { return To(KGFMM); }
        public double ToKilonewtonMeters() { return To(KNM); }
        public double ToNewtonCentimeters() { return To(NCM); }
        public double ToNewtonMeters() { return To(NM); }
        public double ToNewtonMillimeters() { return To(NMM); }
        public double ToOunceFeet() { return To(OZFFT); }
        public double ToOunceInches() { return To(OZFIN); }
        public double ToPoundFeet() { return To(LBFFT); }
        public double ToPoundInches() { return To(LBFIN); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }

        #endregion
    }
}