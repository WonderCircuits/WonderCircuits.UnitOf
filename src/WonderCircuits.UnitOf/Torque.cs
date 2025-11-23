namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Torque()
    /// 
    /// Ex: double foo = new UnitOf.Torque().FromNewtonMeters(1.25).ToGramMeters(); //One line conversion from 1.25 NewtonMeters to GramMeters
    /// </summary>
    [Serializable]
    public class Torque : ConverterBase{
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
        /// <summary>
        /// Method to perform all conversions within Torque class.
        /// All "To" methods within Torque use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Torque foo = new UnitOf.Torque().FromNewtonMeters(1.25); //Variable "foo" will be able to convert 1.25 NewtonMeters into any unit of Torque
        /// </summary>
        public Torque FromDyneCentimeters(double v){return s(this,v,DYNCM,"DYNCM");}
        public Torque FromDyneMeters(double v){return s(this,v,DYNM,"DYNM");}
        public Torque FromDyneMillimeters(double v){return s(this,v,DYNMM,"DYNMM");}
        public Torque FromGramCentimeters(double v){return s(this,v,GFCM,"GFCM");}
        public Torque FromGramMeters(double v){return s(this,v,GFM,"GFM");}
        public Torque FromGramMillimeters(double v){return s(this,v,GFMM,"GFMM");}
        public Torque FromKilogramCentimeters(double v){return s(this,v,KGFCM,"KGFCM");}
        public Torque FromKilogramMeters(double v){return s(this,v,KGFM,"KGFM");}
        public Torque FromKilogramMillimeters(double v){return s(this,v,KGFMM,"KGFMM");}
        public Torque FromKilonewtonMeters(double v){return s(this,v,KNM,"KNM");}
        public Torque FromNewtonCentimeters(double v){return s(this,v,NCM,"NCM");}
        public Torque FromNewtonMeters(double v){return s(this,v,NM,"NM");}
        public Torque FromNewtonMillimeters(double v){return s(this,v,NMM,"NMM");}
        public Torque FromOunceFeet(double v){return s(this,v,OZFFT,"OZFFT");}
        public Torque FromOunceInches(double v){return s(this,v,OZFIN,"OZFIN");}
        public Torque FromPoundFeet(double v){return s(this,v,LBFFT,"LBFFT");}
        public Torque FromPoundInches(double v){return s(this,v,LBFIN,"LBFIN");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToGramMeters(); //Variable "bar" being of type UnitOf.Torque with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Torque().FromNewtonMeters(1.25).ToGramMeters(); //One line conversion from 1.25 NewtonMeters to GramMeters
        /// </summary>
        public double ToDyneCentimeters(){return c(DYNCM);}
        public double ToDyneMeters(){return c(DYNM);}
        public double ToDyneMillimeters(){return c(DYNMM);}
        public double ToGramCentimeters(){return c(GFCM);}
        public double ToGramMeters(){return c(GFM);}
        public double ToGramMillimeters(){return c(GFMM);}
        public double ToKilogramCentimeters(){return c(KGFCM);}
        public double ToKilogramMeters(){return c(KGFM);}
        public double ToKilogramMillimeters(){return c(KGFMM);}
        public double ToKilonewtonMeters(){return c(KNM);}
        public double ToNewtonCentimeters(){return c(NCM);}
        public double ToNewtonMeters(){return c(NM);}
        public double ToNewtonMillimeters(){return c(NMM);}
        public double ToOunceFeet(){return c(OZFFT);}
        public double ToOunceInches(){return c(OZFIN);}
        public double ToPoundFeet(){return c(LBFFT);}
        public double ToPoundInches(){return c(LBFIN);}
    }
}