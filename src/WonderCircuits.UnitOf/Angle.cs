namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Angle()
    /// 
    /// Ex: double foo = new UnitOf.Angle().FromDegrees(1.25).ToRadians(); //One line conversion from 1.25 Degrees to Radians
    /// </summary>
    [Serializable]
    public class Angle : ConverterBase {

        #region Constants
        internal static readonly double C = 1/360.0;          //Circle
        internal static readonly double D = 1;                //Degree
        internal static readonly double G = 1/0.9;            //Gradian
        internal static readonly double MIL = (1/0.05625);    //Angular Mil
        internal static readonly double M = 60;               //Minute 
        internal static readonly double Q = 1/90.0;           //Quadrant
        internal static readonly double RAD = Math.PI/180.0;  //Radian
        internal static readonly double R = 1/360.0;          //Revolution
        internal static readonly double RA = 1/90.0;          //Right Angle
        internal static readonly double S = 3600;             //Second 
        internal static readonly double SE = 1/60.0;          //Sextant
        internal static readonly double SI = (1/30.0);        //Sign
        internal static readonly double T = 1/360.0;          //Turn
        #endregion

        /// <summary>
        /// Method to perform all conversions within Angle class.
        /// All "To" methods within Angle use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Angle foo = new UnitOf.Angle().FromDegrees(1.25); //Variable "foo" will be able to convert 1.25 Degrees into any unit of Angle
        /// </summary>
        public Angle FromCircles(double v){return s(this,v,C,"C");}
        public Angle FromDegrees(double v){return s(this,v,D,"D");}
        public Angle FromGradians(double v){return s(this,v,G,"G");}
        public Angle FromMils(double v){return s(this,v,MIL,"MIL");}
        public Angle FromMinutes(double v){return s(this,v,M,"M");}
        public Angle FromQuadrants(double v){return s(this,v,Q,"Q");}
        public Angle FromRadians(double v){return s(this,v,RAD,"RAD");}
        public Angle FromRevolutions(double v){return s(this,v,R,"R");}
        public Angle FromRightAngles(double v){return s(this,v,RA,"RA");}
        public Angle FromSeconds(double v){return s(this,v,S,"S");}
        public Angle FromSextants(double v){return s(this,v,SE,"SE");}
        public Angle FromSigns(double v){return s(this,v,SI,"SI");}
        public Angle FromTurns(double v){return s(this,v,T,"T");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToRadians(); //Variable "bar" being of type UnitOf.Angle with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Angle().FromDegrees(1.25).ToRadians(); //One line conversion from 1.25 Degrees to Radians
        /// </summary>
        public double ToCircles(){return c(C);}
        public double ToDegrees(){return c(D);}
        public double ToGradians(){return c(G);}
        public double ToMils(){return c(MIL);}  
        public double ToMinutes(){return c(M);}
        public double ToQuadrants(){return c(Q);}
        public double ToRadians(){return c(RAD);}  
        public double ToRevolutions(){return c(R);}
        public double ToRightAngles(){return c(RA);}
        public double ToSeconds(){return c(S);}
        public double ToSextants(){return c(SE);}
        public double ToSigns(){return c(SI);}
        public double ToTurns(){return c(T);}
    }
}