using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Weight()
    /// 
    /// Ex: double foo = new UnitOf.Weight().FromGrams(1.25).ToPounds(); //One line conversion from 1.25 Grams to Pounds
    /// </summary>
    [Serializable]
    public class Weight : UnitConverterBase
    {
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

        #region From Methods
        public Weight FromAttograms(double v) { return From(v, AG, "AG"); }
        public Weight FromCarats(double v) { return From(v, CT, "CT"); }
        public Weight FromCentigrams(double v) { return From(v, CG, "CG"); }
        public Weight FromCentners(double v) { return From(v, CWT, "CWT"); }
        public Weight FromDecigrams(double v) { return From(v, DG, "DG"); }
        public Weight FromDekagrams(double v) { return From(v, DAG, "DAG"); }
        public Weight FromExagrams(double v) { return From(v, EG, "EG"); }
        public Weight FromFemtograms(double v) { return From(v, FG, "FG"); }
        public Weight FromGamma(double v) { return From(v, GAMM, "GAMM"); }
        public Weight FromGigagrams(double v) { return From(v, GG, "GG"); }
        public Weight FromGrams(double v) { return From(v, G, "G"); }
        public Weight FromHectograms(double v) { return From(v, HG, "HG"); }
        public Weight FromKilograms(double v) { return From(v, KG, "KG"); }
        public Weight FromKilopounds(double v) { return From(v, KIP, "KIP"); }
        public Weight FromKilotonsMetric(double v) { return From(v, TK, "TK"); }
        public Weight FromMegagrams(double v) { return From(v, MG, "MG"); }
        public Weight FromMicrograms(double v) { return From(v, MUG, "MUG"); }
        public Weight FromMilligrams(double v) { return From(v, MILG, "MILG"); }
        public Weight FromNanograms(double v) { return From(v, NG, "NG"); }
        public Weight FromOuncesMetric(double v) { return From(v, MOZ, "MOZ"); }
        public Weight FromOuncesUS(double v) { return From(v, USOZ, "USOZ"); }
        public Weight FromPetagrams(double v) { return From(v, PEG, "PEG"); }
        public Weight FromPicograms(double v) { return From(v, PG, "PG"); }
        public Weight FromPounds(double v) { return From(v, LB, "LB"); }
        public Weight FromQuintals(double v) { return From(v, QU, "QU"); }
        public Weight FromSlugs(double v) { return From(v, SLUG, "SLUG"); }
        public Weight FromStonesUK(double v) { return From(v, STUK, "STUK"); }
        public Weight FromStonesUS(double v) { return From(v, STUS, "STUS"); }
        public Weight FromTeragrams(double v) { return From(v, TG, "TG"); }
        public Weight FromTonsImperial(double v) { return From(v, TI, "TI"); }
        public Weight FromTonsMetric(double v) { return From(v, TM, "TM"); }
        public Weight FromTonsUS(double v) { return From(v, TUS, "TUS"); }

        private Weight From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAttograms() { return To(AG); }
        public double ToCarats() { return To(CT); }
        public double ToCentigrams() { return To(CG); }
        public double ToCentners() { return To(CWT); }
        public double ToDecigrams() { return To(DG); }
        public double ToDekagrams() { return To(DAG); }
        public double ToExagrams() { return To(EG); }
        public double ToFemtograms() { return To(FG); }
        public double ToGamma() { return To(GAMM); }
        public double ToGigagrams() { return To(GG); }
        public double ToGrams() { return To(G); }
        public double ToHectograms() { return To(HG); }
        public double ToKilograms() { return To(KG); }
        public double ToKilopounds() { return To(KIP); }
        public double ToKilotonsMetric() { return To(TK); }
        public double ToMegagrams() { return To(MG); }
        public double ToMicrograms() { return To(MUG); }
        public double ToMilligrams() { return To(MILG); }
        public double ToNanograms() { return To(NG); }
        public double ToOuncesMetric() { return To(MOZ); }
        public double ToOuncesUS() { return To(USOZ); }
        public double ToPetagrams() { return To(PEG); }
        public double ToPicograms() { return To(PG); }
        public double ToPounds() { return To(LB); }
        public double ToQuintals() { return To(QU); }
        public double ToSlugs() { return To(SLUG); }
        public double ToStonesUK() { return To(STUK); }
        public double ToStonesUS() { return To(STUS); }
        public double ToTeragrams() { return To(TG); }
        public double ToTonsImperial() { return To(TI); }
        public double ToTonsMetric() { return To(TM); }
        public double ToTonsUS() { return To(TUS); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }

        #endregion
    }
}