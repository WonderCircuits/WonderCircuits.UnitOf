namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Force()
    /// 
    /// Ex: double foo = new UnitOf.Force().FromNewtons(1.25).ToPoundForces(); //One line conversion from 1.25 Newtons to PoundForces
    /// </summary>
    [Serializable]
    public class Force : ConverterBase{

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
        /// <summary>
        /// Method to perform all conversions within Force class.
        /// All "To" methods within Force use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Force foo = new UnitOf.Force().FromNewtons(1.25); //Variable "foo" will be able to convert 1.25 Newtons into any unit of Force
        /// </summary>
        public Force FromAtomicUnitsOfForce(double v){return s(this,v,AUF,"AUF");}
        public Force FromAttonewtons(double v){return s(this,v,AN,"AN");}
        public Force FromCentinewtons(double v){return s(this,v,CN,"CN");}
        public Force FromDecinewtons(double v){return s(this,v,DN,"DN");}
        public Force FromDekanewtons(double v){return s(this,v,DAN,"DAN");}
        public Force FromDynes(double v){return s(this,v,DYN,"DYN");}
        public Force FromExanewtons(double v){return s(this,v,EN,"EN");}
        public Force FromFemtonewtons(double v){return s(this,v,FN,"FN");}
        public Force FromGiganewtons(double v){return s(this,v,GN,"GN");}
        public Force FromGramForces(double v){return s(this,v,GF,"GF");}
        public Force FromGraveForces(double v){return s(this,v,GFF,"GFF");}
        public Force FromHectonewtons(double v){return s(this,v,HN,"HN");}
        public Force FromJouleCentimeters(double v){return s(this,v,JCM,"JCM");}
        public Force FromJouleMeters(double v){return s(this,v,JM,"JM");}
        public Force FromKilogramForces(double v){return s(this,v,KGF,"KGF");}
        public Force FromKilonewtons(double v){return s(this,v,KN,"KN");}
        public Force FromKiloponds(double v){return s(this,v,KP,"KP");}
        public Force FromKilopoundForces(double v){return s(this,v,KIP,"KIP");}
        public Force FromLongTonForces(double v){return s(this,v,LTF,"LTF");}
        public Force FromMeganewtons(double v){return s(this,v,MN,"MN");}
        public Force FromMetricTonForces(double v){return s(this,v,TFM,"TFM");}
        public Force FromMicronewtons(double v){return s(this,v,MUN,"MUN");}
        public Force FromMilligraveForces(double v){return s(this,v,MGF,"MGF");}
        public Force FromMillinewtons(double v){return s(this,v,MILN,"MILN");}
        public Force FromNanonewtons(double v){return s(this,v,NN,"NN");}
        public Force FromNewtons(double v){return s(this,v,N,"N");}
        public Force FromOunceForces(double v){return s(this,v,OZF,"OZF");}
        public Force FromPetanewtons(double v){return s(this,v,PEN,"PEN");}
        public Force FromPiconewtons(double v){return s(this,v,PN,"PN");}
        public Force FromPonds(double v){return s(this,v,P,"P");}
        public Force FromPoundFeetPerSecondSquared(double v){return s(this,v,LBFT,"LBFT");}
        public Force FromPoundForces(double v){return s(this,v,LBF,"LBF");}
        public Force FromPoundals(double v){return s(this,v,PDL,"PDL");}
        public Force FromShortTonForces(double v){return s(this,v,TFS,"TFS");}
        public Force FromSthenes(double v){return s(this,v,SN,"SN");}
        public Force FromTeranewtons(double v){return s(this,v,TN,"TN");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToPoundForces(); //Variable "bar" being of type UnitOf.Force with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Force().FromNewtons(1.25).ToPoundForces(); //One line conversion from 1.25 Newtons to PoundForces
        /// </summary>
        public double ToAtomicUnitsOfForce(){return c(AUF);}
        public double ToAttonewtons(){return c(AN);}
        public double ToCentinewtons(){return c(CN);}
        public double ToDecinewtons(){return c(DN);}
        public double ToDekanewtons(){return c(DAN);}
        public double ToDynes(){return c(DYN);}
        public double ToExanewtons(){return c(EN);}
        public double ToFemtonewtons(){return c(FN);}
        public double ToGiganewtons(){return c(GN);}
        public double ToGramForces(){return c(GF);}
        public double ToGraveForces(){return c(GFF);}
        public double ToHectonewtons(){return c(HN);}
        public double ToJouleCentimeters(){return c(JCM);}
        public double ToJouleMeters(){return c(JM);}
        public double ToKilogramForces(){return c(KGF);}
        public double ToKilonewtons(){return c(KN);}
        public double ToKiloponds(){return c(KP);}
        public double ToKilopoundForces(){return c(KIP);}
        public double ToLongTonForces(){return c(LTF);}
        public double ToMeganewtons(){return c(MN);}
        public double ToMetricTonForces(){return c(TFM);}
        public double ToMicronewtons(){return c(MUN);}
        public double ToMilligraveForces(){return c(MGF);}
        public double ToMillinewtons(){return c(MILN);}
        public double ToNanonewtons(){return c(NN);}
        public double ToNewtons(){return c(N);}
        public double ToOunceForces(){return c(OZF);}
        public double ToPetanewtons(){return c(PEN);}
        public double ToPiconewtons(){return c(PN);}
        public double ToPonds(){return c(P);}
        public double ToPoundFeetPerSecondSquared(){return c(LBFT);}
        public double ToPoundForces(){return c(LBF);}
        public double ToPoundals(){return c(PDL);}
        public double ToShortTonForces(){return c(TFS);}
        public double ToSthenes(){return c(SN);}
        public double ToTeranewtons(){return c(TN);}
    }
}