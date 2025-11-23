namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Area()
    /// 
    /// Ex: double foo = new UnitOf.Area().fromSquareMeters(1.25).toAcres(); //One line conversion from 1.25 SquareMeters to Acres
    /// </summary>
    [Serializable]
    public class Area : ConverterBase{

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
        /// <summary>
        /// Method to perform all conversions within Area class.
        /// All "To" methods within Area use this method.
        /// </summary>
        private double c(double t) {
            return Conversion(t, me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Area foo = new UnitOf.Area().FromSquareMeters(1.25); //Variable "foo" will be able to convert 1.25 SquareMeters into any unit of Area
        /// </summary>
        public Area FromAcres(double v){return s(this,v,AC,"AC");}
        public Area FromAres(double v){return s(this,v,A,"A");}
        public Area FromArpents(double v){return s(this,v,AR,"AR");}
        public Area FromBarns(double v){return s(this,v,B,"B");}
        public Area FromCircularInches(double v){return s(this,v,CRIN,"CRIN");}
        public Area FromCircularMils(double v){return s(this,v,CRMIL,"CRMIL");}
        public Area FromHectares(double v){return s(this,v,HA,"HA");}
        public Area FromHomesteads(double v){return s(this,v,HS,"HS");}
        public Area FromRoods(double v){return s(this,v,R,"R");}
        public Area FromSabins(double v){return s(this,v,S,"S");}
        public Area FromSquareCentimeters(double v){return s(this,v,C,"C");}
        public Area FromSquareChains(double v){return s(this,v,CH,"CH");}
        public Area FromSquareDecimeters(double v){return s(this,v,D,"D");}
        public Area FromSquareDekameters(double v){return s(this,v,DA,"DA");}
        public Area FromSquareFeet(double v){return s(this,v,FT,"FT");}
        public Area FromSquareHectometers(double v){return s(this,v,H,"H");}
        public Area FromSquareInches(double v){return s(this,v,IN,"IN");}
        public Area FromSquareKilometers(double v){return s(this,v,K,"K");}
        public Area FromSquareMeters(double v){return s(this,v,M,"M");}
        public Area FromSquareMicrometers(double v){return s(this,v,MU,"MU");}
        public Area FromSquareMiles(double v){return s(this,v,MI,"MI");}
        public Area FromSquareMillimeters(double v){return s(this,v,MIL,"MIL");}
        public Area FromSquareNanometers(double v){return s(this,v,N,"N");}
        public Area FromSquarePerches(double v){return s(this,v,PE,"PE");}
        public Area FromSquarePoles(double v){return s(this,v,PO,"PO");}
        public Area FromSquareRods(double v){return s(this,v,ROD,"ROD");}
        public Area FromSquareYards(double v){return s(this,v,YD,"YD");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToAcres(); //Variable "bar" being of type UnitOf.Area with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Area().FromSquareMeters(1.25).ToAcres(); //One line conversion from 1.25 SquareMeters to Acres
        /// </summary>
        public double ToAcres(){return c(AC);}
        public double ToAres(){return c(A);}
        public double ToArpents(){return c(AR);}
        public double ToBarns(){return c(B);}
        public double ToCircularInches(){return c(CRIN);}
        public double ToCircularMils(){return c(CRMIL);}
        public double ToHectares(){return c(HA);}
        public double ToHomesteads(){return c(HS);}
        public double ToRoods(){return c(R);}
        public double ToSabins(){return c(S);}
        public double ToSquareCentimeters(){return c(C);}
        public double ToSquareChains(){return c(CH);}
        public double ToSquareDecimeters(){return c(D);}
        public double ToSquareDekameters(){return c(DA);}
        public double ToSquareFeet(){return c(FT);}
        public double ToSquareHectometers(){return c(H);}
        public double ToSquareInches(){return c(IN);}
        public double ToSquareKilometers(){return c(K);}    
        public double ToSquareMeters(){return c(M);}
        public double ToSquareMicrometers(){return c(MU);}   
        public double ToSquareMiles(){return c(MI);}
        public double ToSquareMillimeters(){return c(MIL);}
        public double ToSquareNanometers(){return c(N);}   
        public double ToSquarePerches(){return c(PE);}
        public double ToSquarePoles(){return c(PO);}
        public double ToSquareRods(){return c(ROD);}
        public double ToSquareYards(){return c(YD);}
    }
}