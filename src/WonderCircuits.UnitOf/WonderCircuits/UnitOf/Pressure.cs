using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Pressure()
    /// 
    /// Ex: double foo = new UnitOf.Pressure().FromPascals(1.25).ToKSI(); //One line conversion from 1.25 Pascals to KSI
    /// </summary>
    public class Pressure : UnitConverterBase
    {
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

        #region From Methods
        public Pressure FromAttopascals(double v) { return From(v, APA, "APA"); }
        public Pressure FromBars(double v) { return From(v, BAR, "BAR"); }
        public Pressure FromBaryes(double v) { return From(v, BA, "BA"); }
        public Pressure FromCentimetersOfMercury0C(double v) { return From(v, CMHG, "CMHG"); }
        public Pressure FromCentimetersOfWater4C(double v) { return From(v, CMW4, "CMW4"); }
        public Pressure FromCentipascals(double v) { return From(v, CPA, "CPA"); }
        public Pressure FromDecibars(double v) { return From(v, DBAR, "DBAR"); }
        public Pressure FromDecipascals(double v) { return From(v, DPA, "DPA"); }
        public Pressure FromDekapascals(double v) { return From(v, DAPA, "DAPA"); }
        public Pressure FromDynesPerSquareCentimeter(double v) { return From(v, DYNCM, "DYNCM"); }
        public Pressure FromExapascals(double v) { return From(v, EPA, "EPA"); }
        public Pressure FromFeetOfSeaWater(double v) { return From(v, FSW, "FSW"); }
        public Pressure FromFeetOfWater4C(double v) { return From(v, FTW4, "FTW4"); }
        public Pressure FromFeetOfWater60F(double v) { return From(v, FTW60, "FTW60"); }
        public Pressure FromFemtopascals(double v) { return From(v, FPA, "FPA"); }
        public Pressure FromGigapascals(double v) { return From(v, GPA, "GPA"); }
        public Pressure FromGramsPerSquareCentimeter(double v) { return From(v, GFCM, "GFCM"); }
        public Pressure FromHectopascals(double v) { return From(v, HPA, "HPA"); }
        public Pressure FromInchesOfMercury32F(double v) { return From(v, INHG32, "INHG32"); }
        public Pressure FromInchesOfMercury60F(double v) { return From(v, INHG60, "INHG60"); }
        public Pressure FromInchesOfWater4C(double v) { return From(v, INW4, "INW4"); }
        public Pressure FromInchesOfWater60F(double v) { return From(v, INW60, "INW60"); }
        public Pressure FromKSI(double v) { return From(v, KSI, "KSI"); }
        public Pressure FromKilogramsPerSquareCentimeter(double v) { return From(v, KGFCM, "KGFCM"); }
        public Pressure FromKilogramsPerSquareMeter(double v) { return From(v, KGFM, "KGFM"); }
        public Pressure FromKilogramsPerSquareMillimeter(double v) { return From(v, KFGMM, "KFGMM"); }
        public Pressure FromKilonewtonsPerSquareMeter(double v) { return From(v, KNM, "KNM"); }
        public Pressure FromKilopascals(double v) { return From(v, KPA, "KPA"); }
        public Pressure FromKipsPerSquareInch(double v) { return From(v, KIPFIN, "KIPFIN"); }
        public Pressure FromLongTonsPerSquareFoot(double v) { return From(v, TFFTL, "TFFTL"); }
        public Pressure FromLongTonsPerSquareInch(double v) { return From(v, TFINL, "TFINL"); }
        public Pressure FromMegapascals(double v) { return From(v, MPA, "MPA"); }
        public Pressure FromMetersOfSeaWater(double v) { return From(v, MSW, "MSW"); }
        public Pressure FromMetersOfWater4C(double v) { return From(v, MW4, "MW4"); }
        public Pressure FromMicrobars(double v) { return From(v, MUBAR, "MUBAR"); }
        public Pressure FromMicropascals(double v) { return From(v, MUPA, "MUPA"); }
        public Pressure FromMillibars(double v) { return From(v, MILBAR, "MILBAR"); }
        public Pressure FromMillimetersOfMercury0C(double v) { return From(v, MMHG, "MMHG"); }
        public Pressure FromMillimetersOfWater4C(double v) { return From(v, MMW4, "MMW4"); }
        public Pressure FromMillipascals(double v) { return From(v, MILPA, "MILPA"); }
        public Pressure FromNanopascals(double v) { return From(v, NPA, "NPA"); }
        public Pressure FromNewtonsPerSquareCentimeter(double v) { return From(v, NCM, "NCM"); }
        public Pressure FromNewtonsPerSquareMeter(double v) { return From(v, NM, "NM"); }
        public Pressure FromNewtonsPerSquareMillimeter(double v) { return From(v, NMM, "NMM"); }
        public Pressure FromPSI(double v) { return From(v, PSI, "PSI"); }
        public Pressure FromPascals(double v) { return From(v, PA, "PA"); }
        public Pressure FromPetapascals(double v) { return From(v, PEPA, "PEPA"); }
        public Pressure FromPicopascals(double v) { return From(v, PPA, "PPA"); }
        public Pressure FromPieze(double v) { return From(v, PIZ, "PIZ"); }
        public Pressure FromPoundalsPerSquareFoot(double v) { return From(v, PDLFT, "PDLFT"); }
        public Pressure FromPoundsPerSquareFoot(double v) { return From(v, LBFFT, "LBFFT"); }
        public Pressure FromPoundsPerSquareInch(double v) { return From(v, LBFIN, "LBFIN"); }
        public Pressure FromShortTonsPerSquareFoot(double v) { return From(v, TFFTS, "TFFTS"); }
        public Pressure FromShortTonsPerSquareInch(double v) { return From(v, TFINS, "TFINS"); }
        public Pressure FromStandardAtmospheres(double v) { return From(v, ATM, "ATM"); }
        public Pressure FromSthenesPerSquareMeter(double v) { return From(v, SM, "SM"); }
        public Pressure FromTechnicalAtmospheres(double v) { return From(v, AT, "AT"); }
        public Pressure FromTerapascals(double v) { return From(v, TPA, "TPA"); }
        public Pressure FromTorrs(double v) { return From(v, TORR, "TORR"); }

        private Pressure From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAttopascals() { return To(APA); }
        public double ToBars() { return To(BAR); }
        public double ToBaryes() { return To(BA); }
        public double ToCentimetersOfMercury0C() { return To(CMHG); }
        public double ToCentimetersOfWater4C() { return To(CMW4); }
        public double ToCentipascals() { return To(CPA); }
        public double ToDecibars() { return To(DBAR); }
        public double ToDecipascals() { return To(DPA); }
        public double ToDekapascals() { return To(DAPA); }
        public double ToDynesPerSquareCentimeter() { return To(DYNCM); }
        public double ToExapascals() { return To(EPA); }
        public double ToFeetOfSeaWater() { return To(FSW); }
        public double ToFeetOfWater4C() { return To(FTW4); }
        public double ToFeetOfWater60F() { return To(FTW60); }
        public double ToFemtopascals() { return To(FPA); }
        public double ToGigapascals() { return To(GPA); }
        public double ToGramsPerSquareCentimeter() { return To(GFCM); }
        public double ToHectopascals() { return To(HPA); }
        public double ToInchesOfMercury32F() { return To(INHG32); }
        public double ToInchesOfMercury60F() { return To(INHG60); }
        public double ToInchesOfWater4C() { return To(INW4); }
        public double ToInchesOfWater60F() { return To(INW60); }
        public double ToKSI() { return To(KSI); }
        public double ToKilogramsPerSquareCentimeter() { return To(KGFCM); }
        public double ToKilogramsPerSquareMeter() { return To(KGFM); }
        public double ToKilogramsPerSquareMillimeter() { return To(KFGMM); }
        public double ToKilonewtonsPerSquareMeter() { return To(KNM); }
        public double ToKilopascals() { return To(KPA); }
        public double ToKipsPerSquareInch() { return To(KIPFIN); }
        public double ToLongTonsPerSquareFoot() { return To(TFFTL); }
        public double ToLongTonsPerSquareInch() { return To(TFINL); }
        public double ToMegapascals() { return To(MPA); }
        public double ToMetersOfSeaWater() { return To(MSW); }
        public double ToMetersOfWater4C() { return To(MW4); }
        public double ToMicrobars() { return To(MUBAR); }
        public double ToMicropascals() { return To(MUPA); }
        public double ToMillibars() { return To(MILBAR); }
        public double ToMillimetersOfMercury0C() { return To(MMHG); }
        public double ToMillimetersOfWater4C() { return To(MMW4); }
        public double ToMillipascals() { return To(MILPA); }
        public double ToNanopascals() { return To(NPA); }
        public double ToNewtonsPerSquareCentimeter() { return To(NCM); }
        public double ToNewtonsPerSquareMeter() { return To(NM); }
        public double ToNewtonsPerSquareMillimeter() { return To(NMM); }
        public double ToPSI() { return To(PSI); }
        public double ToPascals() { return To(PA); }
        public double ToPetapascals() { return To(PEPA); }
        public double ToPicopascals() { return To(PPA); }
        public double ToPieze() { return To(PIZ); }
        public double ToPoundalsPerSquareFoot() { return To(PDLFT); }
        public double ToPoundsPerSquareFoot() { return To(LBFFT); }
        public double ToPoundsPerSquareInch() { return To(LBFIN); }
        public double ToShortTonsPerSquareFoot() { return To(TFFTS); }
        public double ToShortTonsPerSquareInch() { return To(TFINS); }
        public double ToStandardAtmospheres() { return To(ATM); }
        public double ToSthenesPerSquareMeter() { return To(SM); }
        public double ToTechnicalAtmospheres() { return To(AT); }
        public double ToTerapascals() { return To(TPA); }
        public double ToTorrs() { return To(TORR); }

        private double To(double t)
        {
            return Conversion(t, true);
        }
        #endregion

    }
}