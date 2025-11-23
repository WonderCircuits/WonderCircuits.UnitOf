namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Pressure()
    /// 
    /// Ex: double foo = new UnitOf.Pressure().FromPascals(1.25).ToKSI(); //One line conversion from 1.25 Pascals to KSI
    /// </summary>
    [Serializable]
    public class Pressure : ConverterBase{

        #region Constants
        internal static readonly double APA = 1e18;               //Attopascal
        internal static readonly double BAR = 1e-5;               //Bar
        internal static readonly double BA = 1e1;                 //Barye 
        internal static readonly double CMHG = 1/1333.22;         //Centimeter Mercury (0C)
        internal static readonly double CMW4 = 1/98.0638;         //Centimeter Water (4C)
        internal static readonly double CPA = 1e2;                //Centipascal
        internal static readonly double DBAR = 1e-4;              //Decibar 
        internal static readonly double DPA = 1e1;                //Decipascal
        internal static readonly double DAPA = 1e-1;              //Dekapascal
        internal static readonly double DYNCM = 1e1;              //Dyne per Square Centimeter
        internal static readonly double EPA = 1e-18;              //Exapascal
        internal static readonly double FSW = 1/3064.30593138;    //Foot Sea Water (15§³)
        internal static readonly double FTW4 = 1/2988.98;         //Foot Water (4C)
        internal static readonly double FTW60 = 1/2986.116;       //Foot Water (60F)
        internal static readonly double FPA = 1e15;               //Femtopascal
        internal static readonly double GPA = 1e-9;               //Gigapascal
        internal static readonly double GFCM = 1/98.0665;         //Gram Force per Square Centimeter
        internal static readonly double HPA = 1e-2;               //Hectopascal
        internal static readonly double INHG32 = 1/3386.38;       //Inch Mercury (32F)
        internal static readonly double INHG60 = 1/3376.85;       //Inch Mercury (60F)
        internal static readonly double INW4 = 1/249.082;         //Inch Water (4C)
        internal static readonly double INW60 = 1/248.843;        //Inch Water (60F)
        internal static readonly double KSI = 1/6894757.293178;   //KSI
        internal static readonly double KGFCM = 1/98066.5;        //Kilogram Force per Square Centimeter
        internal static readonly double KGFM = 1/9.80665;         //Kilogram Force per Square Meter   
        internal static readonly double KFGMM = 1/9806650.0;      //Kilogram Force per Square Millimeter
        internal static readonly double KNM = 1e-3;               //Kilonewton per Square Meter
        internal static readonly double KPA = 1e-3;               //Kilopascal
        internal static readonly double KIPFIN = 1/6894757.293178;//Kip Force per Square Inch
        internal static readonly double TFFTL = 1/107251.780116;  //Ton Force per Square Foot (Long)
        internal static readonly double TFINL = 1/15444256.3367;  //Ton Force per Square Inch (Long)
        internal static readonly double MPA = 1e-6;               //Megapascal
        internal static readonly double MSW = 1e-4;               //Meter Sea Water
        internal static readonly double MW4 = 1/9806.38;          //Meter Water (4C)
        internal static readonly double MUBAR = 1e1;              //Microbar 
        internal static readonly double MUPA = 1e6;               //Micropascal
        internal static readonly double MILBAR = 1e-2;            //Millibar 
        internal static readonly double MMHG = 1/133.322;         //Millimeter Mercury (0C)
        internal static readonly double MMW4 = 1/9.80638;         //Millimeter Water (4C)
        internal static readonly double MILPA = 1e3;              //Millipascal
        internal static readonly double NPA = 1e9;                //Nanopascal
        internal static readonly double NCM = 1e-4;               //Newton per Square Centimeter
        internal static readonly double NM = 1;                   //Newton per Square Meter
        internal static readonly double NMM = 1e-6;               //Newton per Square Millimeter
        internal static readonly double PSI = 1/6894.757293178;   //PSI
        internal static readonly double PA = 1;                   //Pascal
        internal static readonly double PEPA = 1e-15;             //Petapascal
        internal static readonly double PPA = 1e12;               //Picopascal
        internal static readonly double PIZ = 1e-3;               //Pieze 
        internal static readonly double PDLFT = 1/1.48816394357;  //Poundal per Square Foot
        internal static readonly double LBFFT = 1/47.8802589804;  //Pound Force per Square Foot
        internal static readonly double LBFIN = 1/6894.757293178; //Pound Force per Square Inch
        internal static readonly double TFFTS = 1/95760.51796068; //Ton Force per Square Foot (Short)
        internal static readonly double TFINS = 1/13789514.58634; //Ton Force per Square Inch (Short)
        internal static readonly double ATM = 1/101325.0;         //Standard Atmosphere
        internal static readonly double SM = 1e-3;                //Sthene per Square Meter
        internal static readonly double AT = 1/98066.5;           //Atmosphere Technical
        internal static readonly double TPA = 1e-12;              //Terapascal
        internal static readonly double TORR = 1/133.3223684211;  //Torr

        #endregion

        /// <summary>
        /// Method to perform all conversions within Pressure class.
        /// All "To" methods within Pressure use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Pressure foo = new UnitOf.Pressure().FromPascals(1.25); //Variable "foo" will be able to convert 1.25 Pascals into any unit of Pressure
        /// </summary>
        public Pressure FromAttopascals(double v){return s(this, v, APA, "APA");}
        public Pressure FromBars(double v){return s(this, v, BAR, "BAR");}
        public Pressure FromBaryes(double v){return s(this, v, BA, "BA");}
        public Pressure FromCentimetersOfMercury0C(double v){return s(this, v, CMHG, "CMHG");}
        public Pressure FromCentimetersOfWater4C(double v){return s(this, v, CMW4, "CMW4");}
        public Pressure FromCentipascals(double v){return s(this, v, CPA, "CPA");}
        public Pressure FromDecibars(double v){return s(this, v, DBAR, "DBAR");}
        public Pressure FromDecipascals(double v){return s(this, v, DPA, "DPA");}
        public Pressure FromDekapascals(double v){return s(this, v, DAPA, "DAPA");}
        public Pressure FromDynesPerSquareCentimeter(double v){return s(this, v, DYNCM, "DYNCM");}
        public Pressure FromExapascals(double v){return s(this, v, EPA, "EPA");}
        public Pressure FromFeetOfSeaWater(double v){return s(this, v, FSW, "FSW");}
        public Pressure FromFeetOfWater4C(double v){return s(this, v, FTW4, "FTW4");}
        public Pressure FromFeetOfWater60F(double v){return s(this, v, FTW60, "FTW60");}
        public Pressure FromFemtopascals(double v){return s(this, v, FPA, "FPA");}
        public Pressure FromGigapascals(double v){return s(this, v, GPA, "GPA");}
        public Pressure FromGramsPerSquareCentimeter(double v){return s(this, v, GFCM, "GFCM");}
        public Pressure FromHectopascals(double v){return s(this, v, HPA, "HPA");}
        public Pressure FromInchesOfMercury32F(double v){return s(this, v, INHG32, "INHG32");}
        public Pressure FromInchesOfMercury60F(double v){return s(this, v, INHG60, "INHG60");}
        public Pressure FromInchesOfWater4C(double v){return s(this, v, INW4, "INW4");}
        public Pressure FromInchesOfWater60F(double v){return s(this, v, INW60, "INW60");}
        public Pressure FromKSI(double v){return s(this,v,KSI,"KSI");}
        public Pressure FromKilogramsPerSquareCentimeter(double v){return s(this, v, KGFCM, "KGFCM");}
        public Pressure FromKilogramsPerSquareMeter(double v){return s(this, v, KGFM, "KGFM");}
        public Pressure FromKilogramsPerSquareMillimeter(double v){return s(this, v, KFGMM, "KFGMM");}
        public Pressure FromKilonewtonsPerSquareMeter(double v){return s(this, v, KNM, "KNM");}
        public Pressure FromKilopascals(double v){return s(this, v, KPA, "KPA");}
        public Pressure FromKipsPerSquareInch(double v){return s(this, v, KIPFIN, "KIPFIN");}
        public Pressure FromLongTonsPerSquareFoot(double v){return s(this, v, TFFTL, "TFFTL");}
        public Pressure FromLongTonsPerSquareInch(double v){return s(this, v, TFINL, "TFINL");}
        public Pressure FromMegapascals(double v){return s(this, v, MPA, "MPA");}
        public Pressure FromMetersOfSeaWater(double v){return s(this, v, MSW, "MSW");}
        public Pressure FromMetersOfWater4C(double v){return s(this, v, MW4, "MW4");}
        public Pressure FromMicrobars(double v){return s(this, v, MUBAR, "MUBAR");}
        public Pressure FromMicropascals(double v){return s(this, v, MUPA, "MUPA");}
        public Pressure FromMillibars(double v){return s(this, v, MILBAR, "MILBAR");}
        public Pressure FromMillimetersOfMercury0C(double v){return s(this, v, MMHG, "MMHG");}
        public Pressure FromMillimetersOfWater4C(double v){return s(this, v, MMW4, "MMW4");}
        public Pressure FromMillipascals(double v){return s(this, v, MILPA, "MILPA");}
        public Pressure FromNanopascals(double v){return s(this, v, NPA, "NPA");}
        public Pressure FromNewtonsPerSquareCentimeter(double v){return s(this, v, NCM, "NCM");}
        public Pressure FromNewtonsPerSquareMeter(double v){return s(this, v, NM, "NM");}
        public Pressure FromNewtonsPerSquareMillimeter(double v){return s(this, v, NMM, "NMM");}
        public Pressure FromPSI(double v){return s(this,v,PSI,"PSI");}
        public Pressure FromPascals(double v){return s(this, v, PA, "PA");}
        public Pressure FromPetapascals(double v){return s(this, v, PEPA, "PEPA");}
        public Pressure FromPicopascals(double v){return s(this, v, PPA, "PPA");}
        public Pressure FromPieze(double v){return s(this,v,PIZ,"PIZ");}
        public Pressure FromPoundalsPerSquareFoot(double v){return s(this, v, PDLFT, "PDLFT");}
        public Pressure FromPoundsPerSquareFoot(double v){return s(this, v, LBFFT, "LBFFT");}
        public Pressure FromPoundsPerSquareInch(double v){return s(this, v, LBFIN, "LBFIN");}
        public Pressure FromShortTonsPerSquareFoot(double v){return s(this, v, TFFTS, "TFFTS");}
        public Pressure FromShortTonsPerSquareInch(double v){return s(this, v, TFINS, "TFINS");}
        public Pressure FromStandardAtmospheres(double v){return s(this, v, ATM, "ATM");}
        public Pressure FromSthenesPerSquareMeter(double v){return s(this, v, SM, "SM");}
        public Pressure FromTechnicalAtmospheres(double v){return s(this, v, AT, "AT");}
        public Pressure FromTerapascals(double v){return s(this, v, TPA, "TPA");}
        public Pressure FromTorrs(double v){return s(this, v, TORR, "TORR");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToKSI(); //Variable "bar" being of type UnitOf.Pressure with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Pressure().FromPascals(1.25).ToKSI(); //One line conversion from 1.25 Pascals to KSI
        /// </summary>
        public double ToAttopascals(){return c(APA);}
        public double ToBars(){return c(BAR);}
        public double ToBaryes(){return c(BA);}
        public double ToCentimetersOfMercury0C(){return c(CMHG);}
        public double ToCentimetersOfWater4C(){return c(CMW4);}
        public double ToCentipascals(){return c(CPA);}
        public double ToDecibars(){return c(DBAR);}
        public double ToDecipascals(){return c(DPA);}
        public double ToDekapascals(){return c(DAPA);}
        public double ToDynesPerSquareCentimeter(){return c(DYNCM);}
        public double ToExapascals(){return c(EPA);}
        public double ToFeetOfSeaWater(){return c(FSW);}
        public double ToFeetOfWater4C(){return c(FTW4);}
        public double ToFeetOfWater60F(){return c(FTW60);}
        public double ToFemtopascals(){return c(FPA);}
        public double ToGigapascals(){return c(GPA);}
        public double ToGramsPerSquareCentimeter(){return c(GFCM);}
        public double ToHectopascals(){return c(HPA);}
        public double ToInchesOfMercury32F(){return c(INHG32);}
        public double ToInchesOfMercury60F(){return c(INHG60);}
        public double ToInchesOfWater4C(){return c(INW4);}
        public double ToInchesOfWater60F(){return c(INW60);}
        public double ToKSI(){return c(KSI);}
        public double ToKilogramsPerSquareCentimeter(){return c(KGFCM);}
        public double ToKilogramsPerSquareMeter(){return c(KGFM);}
        public double ToKilogramsPerSquareMillimeter(){return c(KFGMM);}
        public double ToKilonewtonsPerSquareMeter(){return c(KNM);}
        public double ToKilopascals(){return c(KPA);}
        public double ToKipsPerSquareInch(){return c(KIPFIN);}
        public double ToLongTonsPerSquareFoot(){return c(TFFTL);}
        public double ToLongTonsPerSquareInch(){return c(TFINL);}
        public double ToMegapascals(){return c(MPA);}
        public double ToMetersOfSeaWater(){return c(MSW);}
        public double ToMetersOfWater4C(){return c(MW4);}
        public double ToMicrobars(){return c(MUBAR);}
        public double ToMicropascals(){return c(MUPA);}
        public double ToMillibars(){return c(MILBAR);}
        public double ToMillimetersOfMercury0C(){return c(MMHG);}
        public double ToMillimetersOfWater4C(){return c(MMW4);}
        public double ToMillipascals(){return c(MILPA);}
        public double ToNanopascals(){return c(NPA);}
        public double ToNewtonsPerSquareCentimeter(){return c(NCM);}
        public double ToNewtonsPerSquareMeter(){return c(NM);}
        public double ToNewtonsPerSquareMillimeter(){return c(NMM);}
        public double ToPSI(){return c(PSI);}
        public double ToPascals(){return c(PA);}
        public double ToPetapascals(){return c(PEPA);}
        public double ToPicopascals(){return c(PPA);}
        public double ToPieze(){return c(PIZ);}
        public double ToPoundalsPerSquareFoot(){return c(PDLFT);}
        public double ToPoundsPerSquareFoot(){return c(LBFFT);}
        public double ToPoundsPerSquareInch(){return c(LBFIN);}
        public double ToShortTonsPerSquareFoot(){return c(TFFTS);}
        public double ToShortTonsPerSquareInch(){return c(TFINS);}
        public double ToStandardAtmospheres(){return c(ATM);}
        public double ToSthenesPerSquareMeter(){return c(SM);}
        public double ToTechnicalAtmospheres(){return c(AT);}
        public double ToTerapascals(){return c(TPA);}
        public double ToTorrs(){return c(TORR);}
    }
}