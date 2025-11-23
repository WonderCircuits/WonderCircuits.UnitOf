namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Frequency()
    /// 
    /// Ex: double foo = new UnitOf.Frequency().FromHertz(1.25).ToCyclesPerSecond(); //One line conversion from 1.25 Hertz to CyclesPerSecond
    /// </summary>
    [Serializable]
    public class Frequency : ConverterBase{

        #region Constants
        internal static readonly double AHZ = 1e24;   //Attohertz 
        internal static readonly double CHZ = 1e8;    //Centihertz
        internal static readonly double CS = 1e6;     //Cycle per Second
        internal static readonly double DHZ = 1e7;    //Decihertz   
        internal static readonly double DAHZ = 1e5;   //Dekahertz   
        internal static readonly double EHZ = 1e-12;  //Exahertz
        internal static readonly double FHZ = 1e21;   //Femtohertz 
        internal static readonly double GHZ = 1e-3;   //Gigahertz
        internal static readonly double HHZ = 1e4;    //Hectohertz  
        internal static readonly double HZ = 1e6;     //Hertz
        internal static readonly double KHZ = 1e3;    //Kilohertz 
        internal static readonly double MHZ = 1;      //Megahertz
        internal static readonly double MUHZ = 1e12;  //Microhertz
        internal static readonly double MIHZ = 1e9;   //Millihertz
        internal static readonly double NHZ = 1e15;   //Nanohertz
        internal static readonly double PEHZ = 1e-9;  //Petahertz
        internal static readonly double PHZ = 1e18;   //Picohertz 
        internal static readonly double RD = 864e8;   //Revolution per Day 
        internal static readonly double RH = 36e8;    //Revolution per Hour
        internal static readonly double RM = 6e7;     //Revolution per Minute
        internal static readonly double RS = 1e6;     //Revolution per Second
        internal static readonly double THZ = 1e-6;   //Terahertz

        #endregion
        /// <summary>
        /// Method to perform all conversions within Frequency class.
        /// All "To" methods within Frequency use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Frequency foo = new UnitOf.Frequency().FromHertz(1.25); //Variable "foo" will be able to convert 1.25 Hertz into any unit of Frequency
        /// </summary>
        public Frequency FromAttohertz(double v){return s(this,v,AHZ,"AHZ");}
        public Frequency FromCentihertz(double v){return s(this,v,CHZ,"CHZ");}
        public Frequency FromCyclesPerSecond(double v){return s(this,v,CS,"CS");}
        public Frequency FromDecihertz(double v){return s(this,v,DHZ,"DHZ");}
        public Frequency FromDekahertz(double v){return s(this,v,DAHZ,"DAHZ");}
        public Frequency FromExahertz(double v){return s(this,v,EHZ,"EHZ");}
        public Frequency FromFemtohertz(double v){return s(this,v,FHZ,"FHZ");}
        public Frequency FromGigahertz(double v){return s(this,v,GHZ,"GHZ");}
        public Frequency FromHectohertz(double v){return s(this,v,HHZ,"HHZ");}
        public Frequency FromHertz(double v){return s(this,v,HZ,"HZ");}
        public Frequency FromKilohertz(double v){return s(this,v,KHZ,"KHZ");}
        public Frequency FromMegahertz(double v){return s(this,v,MHZ,"MHZ");}
        public Frequency FromMicrohertz(double v){return s(this,v,MUHZ,"MUHZ");}
        public Frequency FromMillihertz(double v){return s(this,v,MIHZ,"MIHZ");}
        public Frequency FromNanohertz(double v){return s(this,v,NHZ,"NHZ");}
        public Frequency FromPetahertz(double v){return s(this,v,PEHZ,"PEHZ");}
        public Frequency FromPicohertz(double v){return s(this,v,PHZ,"PHZ");}
        public Frequency FromRevolutionsPerDay(double v){return s(this,v,RD,"RD");}
        public Frequency FromRevolutionsPerHour(double v){return s(this,v,RH,"RH");}
        public Frequency FromRevolutionsPerMinute(double v){return s(this,v,RM,"RM");}
        public Frequency FromRevolutionsPerSecond(double v){return s(this,v,RS,"RS");}
        public Frequency FromTerahertz(double v){return s(this,v,THZ,"THZ");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToCyclesPerSecond(); //Variable "bar" being of type UnitOf.Frequency with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Frequency().FromHertz(1.25).ToCyclesPerSecond(); //One line conversion from 1.25 Hertz to CyclesPerSecond
        /// </summary>
        public double ToAttohertz(){return c(AHZ);}
        public double ToCentihertz(){return c(CHZ);}
        public double ToCyclesPerSecond(){return c(CS);}
        public double ToDecihertz(){return c(DHZ);}
        public double ToDekahertz(){return c(DAHZ);}
        public double ToExahertz(){return c(EHZ);}
        public double ToFemtohertz(){return c(FHZ);}
        public double ToGigahertz(){return c(GHZ);}
        public double ToHectohertz(){return c(HHZ);}
        public double ToHertz(){return c(HZ);}
        public double ToKilohertz(){return c(KHZ);}
        public double ToMegahertz(){return c(MHZ);}
        public double ToMicrohertz(){return c(MUHZ);}
        public double ToMillihertz(){return c(MIHZ);}
        public double ToNanohertz(){return c(NHZ);}
        public double ToPetahertz(){return c(PEHZ);}
        public double ToPicohertz(){return c(PHZ);}
        public double ToRevolutionsPerDay(){return c(RD);}
        public double ToRevolutionsPerHour(){return c(RH);}
        public double ToRevolutionsPerMinute(){return c(RM);}
        public double ToRevolutionsPerSecond(){return c(RS);}
        public double ToTerahertz(){return c(THZ);}
    }
}