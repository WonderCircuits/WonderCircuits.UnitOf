namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Mass()
    /// 
    /// Ex: double foo = new UnitOf.Mass().FromGrams(1.25).ToPounds(); //One line conversion from 1.25 Grams to Pounds
    /// </summary>
    [Serializable]
    public class Mass : ConverterBase{

        #region Constants
        internal static readonly double AG = 1e18;                //Attogram 
        internal static readonly double CT = 5;                   //Carat
        internal static readonly double CG = 1e2;                 //Centigram
        internal static readonly double CWT = 1e-5;               //Centner
        internal static readonly double DG = 1e1;                 //Decigram
        internal static readonly double DAG = 1e-1;               //Dekagram
        internal static readonly double EG = 1e-18;               //Exagram
        internal static readonly double FG = 1e15;                //Femtogram
        internal static readonly double GAMM = 1e6;               //Gamma
        internal static readonly double GG = 1e-9;                //Gigagram
        internal static readonly double G = 1;                    //Gram
        internal static readonly double HG = 1e-2;                //Hectogram
        internal static readonly double KG = 1e-3;                //Kilogram
        internal static readonly double KIP = 1/453592.37;        //Kilopound
        internal static readonly double TK = 1e-9;                //Kilotons (Metric)
        internal static readonly double MG = 1e-6;                //Megagram
        internal static readonly double MUG = 1e6;                //Microgram
        internal static readonly double MILG = 1e3;               //Milligram
        internal static readonly double NG = 1e9;                 //Nanogram
        internal static readonly double MOZ = 4e-2;               //Ounce (Metric)
        internal static readonly double USOZ = 1/28.349523125;    //Ounce (US)
        internal static readonly double PEG = 1e-15;              //Petagram
        internal static readonly double PG = 1e12;                //Picogram
        internal static readonly double LB = 1/453.592;           //Pound 
        internal static readonly double QU = 1e-5;                //Quintal (Metric) 
        internal static readonly double SLUG = 1/14593.9029372;   //Slug
        internal static readonly double STUK = 1/6350.29318;      //Stone (UK)
        internal static readonly double STUS = 1/5669.904625;     //Stone (US)
        internal static readonly double TG = 1e-12;               //Teragram
        internal static readonly double TI = 1/1016000.0;         //Ton (Imperial)
        internal static readonly double TM = 1e-6;                //Tons (Metric)
        internal static readonly double TUS = 1/907185.0;         //Ton (US)

        #endregion

        /// <summary>
        /// Method to perform all conversions within Mass class.
        /// All "To" methods within Mass use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Mass foo = new UnitOf.Mass().FromGrams(1.25); //Variable "foo" will be able to convert 1.25 Grams into any unit of Mass
        /// </summary>
        public Mass FromAttograms(double v){return s(this,v,AG,"AG");}
        public Mass FromCarats(double v){return s(this,v,CT,"CT");}
        public Mass FromCentigrams(double v){return s(this,v,CG,"CG");}
        public Mass FromCentners(double v){return s(this,v,CWT,"CWT");}
        public Mass FromDecigrams(double v){return s(this,v,DG,"DG");}
        public Mass FromDekagrams(double v){return s(this,v,DAG,"DAG");}
        public Mass FromExagrams(double v){return s(this,v,EG,"EG");}
        public Mass FromFemtograms(double v){return s(this,v,FG,"FG");}
        public Mass FromGamma(double v){return s(this,v,GAMM,"GAMM");}
        public Mass FromGigagrams(double v){return s(this,v,GG,"GG");}
        public Mass FromGrams(double v){return s(this,v,G,"G");}
        public Mass FromHectograms(double v){return s(this,v,HG,"HG");}
        public Mass FromKilograms(double v){return s(this,v,KG,"KG");}
        public Mass FromKilopounds(double v){return s(this,v,KIP,"KIP");}
        public Mass FromKilotonsMetric(double v){return s(this,v,TK,"TK");}
        public Mass FromMegagrams(double v){return s(this,v,MG,"MG");}
        public Mass FromMicrograms(double v){return s(this,v,MUG,"MUG");}
        public Mass FromMilligrams(double v){return s(this,v,MILG,"MILG");}
        public Mass FromNanograms(double v){return s(this,v,NG,"NG");}
        public Mass FromOuncesMetric(double v){return s(this,v,MOZ,"MOZ");}
        public Mass FromOuncesUS(double v){return s(this,v,USOZ,"USOZ");}
        public Mass FromPetagrams(double v){return s(this,v,PEG,"PEG");}
        public Mass FromPicograms(double v){return s(this,v,PG,"PG");}
        public Mass FromPounds(double v){return s(this,v,LB,"LB");}
        public Mass FromQuintals(double v){return s(this,v,QU,"QU");}
        public Mass FromSlugs(double v){return s(this,v,SLUG,"SLUG");}
        public Mass FromStonesUK(double v){return s(this,v,STUK,"STUK");}
        public Mass FromStonesUS(double v){return s(this,v,STUS,"STUS");}
        public Mass FromTeragrams(double v){return s(this,v,TG,"TG");}
        public Mass FromTonsImperial(double v){return s(this,v,TI,"TI");}
        public Mass FromTonsMetric(double v){return s(this,v,TM,"TM");}
        public Mass FromTonsUS(double v){return s(this,v,TUS,"TUS");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToPounds(); //Variable "bar" being of type UnitOf.Mass with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Mass().FromGrams(1.25).ToPounds(); //One line conversion from 1.25 Grams to Pounds
        /// </summary>
        public double ToAttograms(){return c(AG);}
        public double ToCarats(){return c(CT);}
        public double ToCentigrams(){return c(CG);}
        public double ToCentners(){return c(CWT);}
        public double ToDecigrams(){return c(DG);}
        public double ToDekagrams(){return c(DAG);}
        public double ToExagrams(){return c(EG);}
        public double ToFemtograms(){return c(FG);}
        public double ToGamma(){return c(GAMM);}
        public double ToGigagrams(){return c(GG);}
        public double ToGrams(){return c(G);}
        public double ToHectograms(){return c(HG);}
        public double ToKilograms(){return c(KG);}
        public double ToKilopounds(){return c(KIP);}
        public double ToKilotonsMetric(){return c(TK);}
        public double ToMegagrams(){return c(MG);}
        public double ToMicrograms(){return c(MUG);}
        public double ToMilligrams(){return c(MILG);}
        public double ToNanograms(){return c(NG);}
        public double ToOuncesMetric(){return c(MOZ);}
        public double ToOuncesUS(){return c(USOZ);}
        public double ToPetagrams(){return c(PEG);}
        public double ToPicograms(){return c(PG);}
        public double ToPounds(){return c(LB);}
        public double ToQuintals(){return c(QU);}
        public double ToSlugs(){return c(SLUG);}
        public double ToStonesUK(){return c(STUK);}
        public double ToStonesUS(){return c(STUS);}
        public double ToTeragrams(){return c(TG);}
        public double ToTonsImperial(){return c(TI);}
        public double ToTonsMetric(){return c(TM);}
        public double ToTonsUS(){return c(TUS);}  
    }
}