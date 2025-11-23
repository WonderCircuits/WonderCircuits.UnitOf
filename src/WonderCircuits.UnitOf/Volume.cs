namespace WonderCircuits.UnitOf {

    /// <summary>
    /// UnitOf.Volume()
    /// 
    /// Ex: double foo = new UnitOf.Volume().FromLiters(1.25).ToCubicMeters(); //One line conversion from 1.25 Liters to CubicMeters
    /// </summary>
    [Serializable]
    public class Volume : ConverterBase{
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
        /// <summary>
        /// Method to perform all conversions within Volume class.
        /// All "To" methods within Volume use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Volume foo = new UnitOf.Volume().FromLiters(1.25); //Variable "foo" will be able to convert 1.25 Liters into any unit of Volume
        /// </summary>
        public Volume FromAcreFeetUSSurvey(double v){return s(this,v,ACFTUS,"ACFTUS");}
        public Volume FromAcreInches(double v){return s(this,v,ACIN,"ACIN");}
        public Volume FromArceFeet(double v){return s(this,v,ACFTO,"ACFTO");}
        public Volume FromAttoliters(double v){return s(this,v,AL,"AL");}
        public Volume FromBarrelsOfOil(double v){return s(this,v,BBLO,"BBLO");}
        public Volume FromBarrelsUK(double v){return s(this,v,BBLUK,"BBLUK");}
        public Volume FromBarrelsUS(double v){return s(this,v,BBLUS,"BBLUS");}
        public Volume FromBoardFeet(double v){return s(this,v,FBM,"FBM");}
        public Volume FromCentiliters(double v){return s(this,v,CL,"CL");}
        public Volume FromCords(double v){return s(this,v,CORD,"CORD");}
        public Volume FromCubicCentimeters(double v){return s(this, v, CM, "CM");}
        public Volume FromCubicDecimeters(double v){return s(this, v, DM, "DM");}
        public Volume FromCubicFeet(double v){return s(this, v, FT, "FT");}
        public Volume FromCubicInches(double v){return s(this, v, IN, "IN");}
        public Volume FromCubicKilometers(double v){return s(this, v, KM, "KM");}
        public Volume FromCubicMeters(double v){return s(this, v, M, "M");}
        public Volume FromCubicMiles(double v){return s(this, v, MI, "MI");}
        public Volume FromCubicMillimeters(double v){return s(this, v, MM, "MM");}
        public Volume FromCubicYards(double v){return s(this, v, YD, "YD");}
        public Volume FromCupsMetric(double v){return s(this,v,CUPM,"CUPM");}
        public Volume FromCupsUK(double v){return s(this,v,CUPUK,"CUPUK");}
        public Volume FromCupsUS(double v){return s(this,v,CUPUS,"CUPUS");}
        public Volume FromDeciliters(double v){return s(this,v,DL,"DL");}
        public Volume FromDecisteres(double v){return s(this,v,DECI,"DECI");}
        public Volume FromDekaliters(double v){return s(this,v,DAL,"DAL");}
        public Volume FromDekasteres(double v){return s(this,v,DEKA,"DEKA");}
        public Volume FromDessertspoonsUK(double v){return s(this,v,DSTSPNUK,"DSTSPNUK");}
        public Volume FromDessertspoonsUS(double v){return s(this,v,DSTSPNUS,"DSTSPNUS");}
        public Volume FromDrops(double v){return s(this,v,DROP,"DROP");}
        public Volume FromExaliters(double v){return s(this,v,EL,"EL");}
        public Volume FromFemtoliters(double v){return s(this,v,FL,"FL");}
        public Volume FromFluidOuncesUK(double v){return s(this,v,FLOZUK,"FLOZUK");}
        public Volume FromFluidOuncesUS(double v){return s(this,v,FLOZUS,"FLOZUS");}
        public Volume FromGallonsUK(double v){return s(this,v,GALUK,"GALUK");}
        public Volume FromGallonsUS(double v){return s(this,v,GALUS,"GALUS");}
        public Volume FromGigaliters(double v){return s(this,v,GL,"GL");}
        public Volume FromGillsUK(double v){return s(this,v,GILUK,"GILUK");}
        public Volume FromGillsUS(double v){return s(this,v,GILUS,"GILUS");}
        public Volume FromHectoliters(double v){return s(this,v,HL,"HL");}
        public Volume FromHogsheads(double v){return s(this,v,HOG,"HOG");}
        public Volume FromHundredCubicFeet(double v){return s(this, v, CCF, "CCF");}
        public Volume FromKiloliters(double v){return s(this,v,KL,"KL");}
        public Volume FromLiters(double v){return s(this,v,L,"L");}
        public Volume FromMegaliters(double v){return s(this,v,ML,"ML");}
        public Volume FromMicroliters(double v){return s(this,v,MUL,"MUL");}
        public Volume FromMilliliters(double v){return s(this,v,MILL,"MILL");}
        public Volume FromMinimsUK(double v){return s(this,v,MINIUK,"MINIUK");}
        public Volume FromMinimsUS(double v){return s(this,v,MINIUS,"MINIUS");}
        public Volume FromNanoliters(double v){return s(this,v,NL,"NL");}
        public Volume FromPetaliters(double v){return s(this,v,PEL,"PEL");}
        public Volume FromPicoliters(double v){return s(this,v,PL,"PL");}
        public Volume FromPintsUK(double v){return s(this,v,PTUK,"PTUK");}
        public Volume FromPintsUS(double v){return s(this,v,PTUS,"PTUS");}
        public Volume FromQuartsUK(double v){return s(this,v,QTUK,"QTUK");}
        public Volume FromQuartsUS(double v){return s(this,v,QTUS,"QTUS");}
        public Volume FromRegisterTons(double v){return s(this,v,REGTON,"REGTON");}
        public Volume FromSteres(double v){return s(this,v,ST,"ST");}
        public Volume FromTablespoonsMetric(double v){return s(this,v,TBSPM,"TBSPM");}
        public Volume FromTablespoonsUK(double v){return s(this,v,TBSPUK,"TBSPUK");}
        public Volume FromTablespoonsUS(double v){return s(this,v,TBSPUS,"TBSPUS");}
        public Volume FromTeaspoonsMetric(double v){return s(this,v,TSPM,"TSPM");}
        public Volume FromTeaspoonsUK(double v){return s(this,v,TSPUK,"TSPUK");}
        public Volume FromTeaspoonsUS(double v){return s(this,v,TSPUS,"TSPUS");}
        public Volume FromTeraliters(double v){return s(this,v,TL,"TL");}
        public Volume FromTuns(double v){return s(this,v,TUN,"TUN");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToCubicMeters(); //Variable "bar" being of type UnitOf.Volume with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Volume().FromLiters(1.25).ToCubicMeters(); //One line conversion from 1.25 Liters to CubicMeters
        /// </summary>
        public double ToAcreFeetUSSurvey(){return c(ACFTUS);}
        public double ToAcreInches(){return c(ACIN);}
        public double ToArceFeet(){return c(ACFTO);}
        public double ToAttoliters(){return c(AL);}
        public double ToBarrelsOfOil(){return c(BBLO);}
        public double ToBarrelsUK(){return c(BBLUK);}
        public double ToBarrelsUS(){return c(BBLUS);}
        public double ToBoardFeet(){return c(FBM);}
        public double ToCentiliters(){return c(CL);}
        public double ToCords(){return c(CORD);}
        public double ToCubicCentimeters(){return c(CM);}
        public double ToCubicDecimeters(){return c(DM);}
        public double ToCubicFeet(){return c(FT);}
        public double ToCubicInches(){return c(IN);}
        public double ToCubicKilometers(){return c(KM);}
        public double ToCubicMeters(){return c(M);}
        public double ToCubicMiles(){return c(MI);}
        public double ToCubicMillimeters(){return c(MM);}
        public double ToCubicYards(){return c(YD);}
        public double ToCupsMetric(){return c(CUPM);}
        public double ToCupsUK(){return c(CUPUK);}
        public double ToCupsUS(){return c(CUPUS);}
        public double ToDeciliters(){return c(DL);}
        public double ToDecisteres(){return c(DECI);}
        public double ToDekaliters(){return c(DAL);}
        public double ToDekasteres(){return c(DEKA);}
        public double ToDessertspoonsUK(){return c(DSTSPNUK);}
        public double ToDessertspoonsUS(){return c(DSTSPNUS);}
        public double ToDrops(){return c(DROP);}
        public double ToExaliters(){return c(EL);}
        public double ToFemtoliters(){return c(FL);}
        public double ToFluidOuncesUK(){return c(FLOZUK);}
        public double ToFluidOuncesUS(){return c(FLOZUS);}
        public double ToGallonsUK(){return c(GALUK);}
        public double ToGallonsUS(){return c(GALUS);}
        public double ToGigaliters(){return c(GL);}
        public double ToGillsUK(){return c(GILUK);}
        public double ToGillsUS(){return c(GILUS);}
        public double ToHectoliters(){return c(HL);}
        public double ToHogsheads(){return c(HOG);}
        public double ToHundredCubicFeet(){return c(CCF);}
        public double ToKiloliters(){return c(KL);}
        public double ToLiters(){return c(L);}
        public double ToMegaliters(){return c(ML);}
        public double ToMicroliters(){return c(MUL);}
        public double ToMilliliters(){return c(MILL);}
        public double ToMinimsUK(){return c(MINIUK);}
        public double ToMinimsUS(){return c(MINIUS);}
        public double ToNanoliters(){return c(NL);}
        public double ToPetaliters(){return c(PEL);}
        public double ToPicoliters(){return c(PL);}
        public double ToPintsUK(){return c(PTUK);}
        public double ToPintsUS(){return c(PTUS);}
        public double ToQuartsUK(){return c(QTUK);}
        public double ToQuartsUS(){return c(QTUS);}
        public double ToRegisterTons(){return c(REGTON);}
        public double ToSteres(){return c(ST);}
        public double ToTablespoonsMetric(){return c(TBSPM);}
        public double ToTablespoonsUK(){return c(TBSPUK);}
        public double ToTablespoonsUS(){return c(TBSPUS);}
        public double ToTeaspoonsMetric(){return c(TSPM);}
        public double ToTeaspoonsUK(){return c(TSPUK);}
        public double ToTeaspoonsUS(){return c(TSPUS);}
        public double ToTeraliters(){return c(TL);}
        public double ToTuns(){return c(TUN);}
    }
}