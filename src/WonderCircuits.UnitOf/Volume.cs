using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{

    /// <summary>
    /// UnitOf.Volume()
    /// 
    /// Ex: double foo = new UnitOf.Volume().FromLiters(1.25).ToCubicMeters(); //One line conversion from 1.25 Liters to CubicMeters
    /// </summary>
    public class Volume : UnitConverterBase
    {
        #region Constants
        internal static readonly double ACFTUS = 0.0008107083295205;  //Acre Foot (US)
        internal static readonly double ACIN = 0.009728558325479;     //Acre Inch
        internal static readonly double ACFTO = 0.0008107131937899;   //Acre Foot
        internal static readonly double AL = 1e21;                    //Attoliter
        internal static readonly double BBLO = 6.289810770432;        //Barrel (Oil)
        internal static readonly double BBLUK = 6.110256897197;       //Barrel (UK) 
        internal static readonly double BBLUS = 8.386414360576;       //Barrel (US)
        internal static readonly double FBM = 423.7760006579;         //Board Foot
        internal static readonly double CL = 1e5;                     //Centiliter 
        internal static readonly double CORD = 0.2758958337616;       //Cord 
        internal static readonly double CM = 1e6;                     //Cubic Centimeter
        internal static readonly double DM = 1e3;                     //Cubic Decimeter
        internal static readonly double FT = 35.31466672148;          //Cubic Foot
        internal static readonly double IN = 61023.74409473;          //Cubic Inch
        internal static readonly double KM = 1e-9;                    //Cubic Kilometer
        internal static readonly double M = 1;                        //Cubic Meter
        internal static readonly double MI = 2.399127585789e-10;      //Cubic Mile
        internal static readonly double MM = 1e9;                     //Cubic Millimeter
        internal static readonly double YD = 1.307950619314;          //Cubic Yard
        internal static readonly double CUPM = 4e3;                   //Cup (Metric)
        internal static readonly double CUPUK = 3519.507972785;       //Cup (UK)
        internal static readonly double CUPUS = 4226.75283773;        //Cup (US)
        internal static readonly double DL = 1e4;                     //Deciliter 
        internal static readonly double DECI = 1e1;                   //Decistere 
        internal static readonly double DAL = 1e2;                    //Dekaliter 
        internal static readonly double DEKA = 0.1;                   //Dekastere
        internal static readonly double DSTSPNUK = 84468.19134685;    //Dessertspoon (UK)
        internal static readonly double DSTSPNUS = 101442.0681055;    //Dessertspoon (US)
        internal static readonly double DROP = 2e7;                   //Drop
        internal static readonly double EL = 1e-15;                   //Exaliter 
        internal static readonly double FL = 1e18;                    //Femtoliter
        internal static readonly double FLOZUK = 35195.07972785;      //Fluid Ounce (UK)
        internal static readonly double FLOZUS = 33814.02270184;      //Fluid Ounce (US)
        internal static readonly double GALUK = 219.9692482991;       //Gallon (UK)
        internal static readonly double GALUS = 264.1720523581;       //Gallon (US)
        internal static readonly double GL = 1e-6;                    //Gigaliter 
        internal static readonly double GILUK = 7039.015945571;       //Fill (UK)
        internal static readonly double GILUS = 8453.505675461;       //Gill (US)
        internal static readonly double HL = 1e1;                     //Hectoliter 
        internal static readonly double HOG = 4.193207180288;         //Hogshead
        internal static readonly double CCF = 0.3531466672149;        //100 Cubic Feet
        internal static readonly double KL = 1;                       //Kiloliter 
        internal static readonly double L = 1e3;                      //Liter
        internal static readonly double ML = 1e-3;                    //Megaliter 
        internal static readonly double MUL = 1e9;                    //Microliter 
        internal static readonly double MILL = 1e6;                   //Milliliter 
        internal static readonly double MINIUK = 16893638.26937;      //Minim (UK)    
        internal static readonly double MINIUS = 16230730.89688;      //Minim (US)
        internal static readonly double NL = 1e12;                    //Nanoliter 
        internal static readonly double PEL = 1e-12;                  //Petaliter 
        internal static readonly double PL = 1e15;                    //Picoliter 
        internal static readonly double PTUK = 1759.753986393;        //Pint (UK)
        internal static readonly double PTUS = 2113.376418865;        //Pint (US) 
        internal static readonly double QTUK = 879.8769931964;        //Quart (UK)
        internal static readonly double QTUS = 1056.688209433;        //Quart (US)
        internal static readonly double REGTON = 0.3531466672149;     //Register Ton
        internal static readonly double ST = 1;                       //Stere 
        internal static readonly double TBSPM = 66666.66666667;       //Tablespoon (Metric)
        internal static readonly double TBSPUK = 56312.12756457;      //Tablespoon (UK)
        internal static readonly double TBSPUS = 67628.04540369;      //Tablespoon (US)
        internal static readonly double TSPM = 2e5;                   //Teaspoon (Metric)
        internal static readonly double TSPUK = 168936.3826937;       //Teaspoon (UK)
        internal static readonly double TSPUS = 202884.1362111;       //Teaspoon (US)
        internal static readonly double TL = 1e-9;                    //Teraliter 
        internal static readonly double TUN = 1.048301795072;         //Tun

        #endregion

        #region From Methods
        public Volume FromAcreFeetUSSurvey(double v) { return From(v, ACFTUS, "ACFTUS"); }
        public Volume FromAcreInches(double v) { return From(v, ACIN, "ACIN"); }
        public Volume FromArceFeet(double v) { return From(v, ACFTO, "ACFTO"); }
        public Volume FromAttoliters(double v) { return From(v, AL, "AL"); }
        public Volume FromBarrelsOfOil(double v) { return From(v, BBLO, "BBLO"); }
        public Volume FromBarrelsUK(double v) { return From(v, BBLUK, "BBLUK"); }
        public Volume FromBarrelsUS(double v) { return From(v, BBLUS, "BBLUS"); }
        public Volume FromBoardFeet(double v) { return From(v, FBM, "FBM"); }
        public Volume FromCentiliters(double v) { return From(v, CL, "CL"); }
        public Volume FromCords(double v) { return From(v, CORD, "CORD"); }
        public Volume FromCubicCentimeters(double v) { return From(v, CM, "CM"); }
        public Volume FromCubicDecimeters(double v) { return From(v, DM, "DM"); }
        public Volume FromCubicFeet(double v) { return From(v, FT, "FT"); }
        public Volume FromCubicInches(double v) { return From(v, IN, "IN"); }
        public Volume FromCubicKilometers(double v) { return From(v, KM, "KM"); }
        public Volume FromCubicMeters(double v) { return From(v, M, "M"); }
        public Volume FromCubicMiles(double v) { return From(v, MI, "MI"); }
        public Volume FromCubicMillimeters(double v) { return From(v, MM, "MM"); }
        public Volume FromCubicYards(double v) { return From(v, YD, "YD"); }
        public Volume FromCupsMetric(double v) { return From(v, CUPM, "CUPM"); }
        public Volume FromCupsUK(double v) { return From(v, CUPUK, "CUPUK"); }
        public Volume FromCupsUS(double v) { return From(v, CUPUS, "CUPUS"); }
        public Volume FromDeciliters(double v) { return From(v, DL, "DL"); }
        public Volume FromDecisteres(double v) { return From(v, DECI, "DECI"); }
        public Volume FromDekaliters(double v) { return From(v, DAL, "DAL"); }
        public Volume FromDekasteres(double v) { return From(v, DEKA, "DEKA"); }
        public Volume FromDessertspoonsUK(double v) { return From(v, DSTSPNUK, "DSTSPNUK"); }
        public Volume FromDessertspoonsUS(double v) { return From(v, DSTSPNUS, "DSTSPNUS"); }
        public Volume FromDrops(double v) { return From(v, DROP, "DROP"); }
        public Volume FromExaliters(double v) { return From(v, EL, "EL"); }
        public Volume FromFemtoliters(double v) { return From(v, FL, "FL"); }
        public Volume FromFluidOuncesUK(double v) { return From(v, FLOZUK, "FLOZUK"); }
        public Volume FromFluidOuncesUS(double v) { return From(v, FLOZUS, "FLOZUS"); }
        public Volume FromGallonsUK(double v) { return From(v, GALUK, "GALUK"); }
        public Volume FromGallonsUS(double v) { return From(v, GALUS, "GALUS"); }
        public Volume FromGigaliters(double v) { return From(v, GL, "GL"); }
        public Volume FromGillsUK(double v) { return From(v, GILUK, "GILUK"); }
        public Volume FromGillsUS(double v) { return From(v, GILUS, "GILUS"); }
        public Volume FromHectoliters(double v) { return From(v, HL, "HL"); }
        public Volume FromHogsheads(double v) { return From(v, HOG, "HOG"); }
        public Volume FromHundredCubicFeet(double v) { return From(v, CCF, "CCF"); }
        public Volume FromKiloliters(double v) { return From(v, KL, "KL"); }
        public Volume FromLiters(double v) { return From(v, L, "L"); }
        public Volume FromMegaliters(double v) { return From(v, ML, "ML"); }
        public Volume FromMicroliters(double v) { return From(v, MUL, "MUL"); }
        public Volume FromMilliliters(double v) { return From(v, MILL, "MILL"); }
        public Volume FromMinimsUK(double v) { return From(v, MINIUK, "MINIUK"); }
        public Volume FromMinimsUS(double v) { return From(v, MINIUS, "MINIUS"); }
        public Volume FromNanoliters(double v) { return From(v, NL, "NL"); }
        public Volume FromPetaliters(double v) { return From(v, PEL, "PEL"); }
        public Volume FromPicoliters(double v) { return From(v, PL, "PL"); }
        public Volume FromPintsUK(double v) { return From(v, PTUK, "PTUK"); }
        public Volume FromPintsUS(double v) { return From(v, PTUS, "PTUS"); }
        public Volume FromQuartsUK(double v) { return From(v, QTUK, "QTUK"); }
        public Volume FromQuartsUS(double v) { return From(v, QTUS, "QTUS"); }
        public Volume FromRegisterTons(double v) { return From(v, REGTON, "REGTON"); }
        public Volume FromSteres(double v) { return From(v, ST, "ST"); }
        public Volume FromTablespoonsMetric(double v) { return From(v, TBSPM, "TBSPM"); }
        public Volume FromTablespoonsUK(double v) { return From(v, TBSPUK, "TBSPUK"); }
        public Volume FromTablespoonsUS(double v) { return From(v, TBSPUS, "TBSPUS"); }
        public Volume FromTeaspoonsMetric(double v) { return From(v, TSPM, "TSPM"); }
        public Volume FromTeaspoonsUK(double v) { return From(v, TSPUK, "TSPUK"); }
        public Volume FromTeaspoonsUS(double v) { return From(v, TSPUS, "TSPUS"); }
        public Volume FromTeraliters(double v) { return From(v, TL, "TL"); }
        public Volume FromTuns(double v) { return From(v, TUN, "TUN"); }

        private Volume From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAcreFeetUSSurvey() { return To(ACFTUS); }
        public double ToAcreInches() { return To(ACIN); }
        public double ToArceFeet() { return To(ACFTO); }
        public double ToAttoliters() { return To(AL); }
        public double ToBarrelsOfOil() { return To(BBLO); }
        public double ToBarrelsUK() { return To(BBLUK); }
        public double ToBarrelsUS() { return To(BBLUS); }
        public double ToBoardFeet() { return To(FBM); }
        public double ToCentiliters() { return To(CL); }
        public double ToCords() { return To(CORD); }
        public double ToCubicCentimeters() { return To(CM); }
        public double ToCubicDecimeters() { return To(DM); }
        public double ToCubicFeet() { return To(FT); }
        public double ToCubicInches() { return To(IN); }
        public double ToCubicKilometers() { return To(KM); }
        public double ToCubicMeters() { return To(M); }
        public double ToCubicMiles() { return To(MI); }
        public double ToCubicMillimeters() { return To(MM); }
        public double ToCubicYards() { return To(YD); }
        public double ToCupsMetric() { return To(CUPM); }
        public double ToCupsUK() { return To(CUPUK); }
        public double ToCupsUS() { return To(CUPUS); }
        public double ToDeciliters() { return To(DL); }
        public double ToDecisteres() { return To(DECI); }
        public double ToDekaliters() { return To(DAL); }
        public double ToDekasteres() { return To(DEKA); }
        public double ToDessertspoonsUK() { return To(DSTSPNUK); }
        public double ToDessertspoonsUS() { return To(DSTSPNUS); }
        public double ToDrops() { return To(DROP); }
        public double ToExaliters() { return To(EL); }
        public double ToFemtoliters() { return To(FL); }
        public double ToFluidOuncesUK() { return To(FLOZUK); }
        public double ToFluidOuncesUS() { return To(FLOZUS); }
        public double ToGallonsUK() { return To(GALUK); }
        public double ToGallonsUS() { return To(GALUS); }
        public double ToGigaliters() { return To(GL); }
        public double ToGillsUK() { return To(GILUK); }
        public double ToGillsUS() { return To(GILUS); }
        public double ToHectoliters() { return To(HL); }
        public double ToHogsheads() { return To(HOG); }
        public double ToHundredCubicFeet() { return To(CCF); }
        public double ToKiloliters() { return To(KL); }
        public double ToLiters() { return To(L); }
        public double ToMegaliters() { return To(ML); }
        public double ToMicroliters() { return To(MUL); }
        public double ToMilliliters() { return To(MILL); }
        public double ToMinimsUK() { return To(MINIUK); }
        public double ToMinimsUS() { return To(MINIUS); }
        public double ToNanoliters() { return To(NL); }
        public double ToPetaliters() { return To(PEL); }
        public double ToPicoliters() { return To(PL); }
        public double ToPintsUK() { return To(PTUK); }
        public double ToPintsUS() { return To(PTUS); }
        public double ToQuartsUK() { return To(QTUK); }
        public double ToQuartsUS() { return To(QTUS); }
        public double ToRegisterTons() { return To(REGTON); }
        public double ToSteres() { return To(ST); }
        public double ToTablespoonsMetric() { return To(TBSPM); }
        public double ToTablespoonsUK() { return To(TBSPUK); }
        public double ToTablespoonsUS() { return To(TBSPUS); }
        public double ToTeaspoonsMetric() { return To(TSPM); }
        public double ToTeaspoonsUK() { return To(TSPUK); }
        public double ToTeaspoonsUS() { return To(TSPUS); }
        public double ToTeraliters() { return To(TL); }
        public double ToTuns() { return To(TUN); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }
        #endregion
    }
}