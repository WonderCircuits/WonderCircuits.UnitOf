namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Length()
    /// 
    /// Ex: double foo = new UnitOf.Length().FromMeters(1.25).ToFeet(); //One line conversion from 1.25 Meters to Feet
    /// </summary>
    [Serializable]
    public class Length : ConverterBase
    {
        #region Constants
        internal static readonly double A = 1e10;                     //Angstrom
        internal static readonly double AM = 1e18;                    //Attometer 
        internal static readonly double BC = 1/(0.2286/27.0);         //Barleycorn 
        internal static readonly double CBLIMP = 1/185.3184;          //Cable Length (Imperial)
        internal static readonly double CBLIN = 1/185.2;              //Cable Length (International)
        internal static readonly double CBLUS = 1/219.456;            //Cable Length (US)
        internal static readonly double CL = 1/0.000254;              //Caliber 
        internal static readonly double CIN = 1/0.000254;             //Centiinch 
        internal static readonly double CM = 1e2;                     //Centimeter 
        internal static readonly double CH = 1/20.1168;               //Chain 
        internal static readonly double CU = 1/0.4572;                //Cubit
        internal static readonly double DM = 1e1;                     //Decimeter 
        internal static readonly double DAM = 1e-1;                   //Dekameter
        internal static readonly double ELL = 1/1.143;                //Ell
        internal static readonly double EM = 1e-18;                   //Exameter 
        internal static readonly double FTM = 1/1.8288;               //Fathom 
        internal static readonly double FT = 1/0.3048;                //Foot 
        internal static readonly double FM = 1e15;                    //Femtometer 
        internal static readonly double FING = 1/0.1143;              //Finger 
        internal static readonly double FUR = 1/201.168;              //Furlong 
        internal static readonly double GM = 1e-9;                    //Gigameter 
        internal static readonly double HAND = 1/0.1016;              //Hand 
        internal static readonly double HM = 1e-2;                    //Hectometer 
        internal static readonly double IN = 1/0.0254;                //Inch 
        internal static readonly double KM = 1e-3;                    //Kilometer 
        internal static readonly double KYD = 1/914.4;                //Kiloyard 
        internal static readonly double LEA = 1/4828.032;             //League 
        internal static readonly double LY = 1/9.46073047258e15;      //Lightyear
        internal static readonly double LNK = 1/0.201168;             //Link 
        internal static readonly double MM = 1e-6;                    //Megameter
        internal static readonly double M = 1;                        //Meter 
        internal static readonly double MUIN = 1/(0.0000254/1000.0);  //Microinch 
        internal static readonly double MUM = 1e6;                    //Micrometer 
        internal static readonly double MURM = 1e6;                   //Micron 
        internal static readonly double MI = 1/1609.344;              //Mile 
        internal static readonly double MILM = 1e3;                   //Millimeter
        internal static readonly double NAIL = 1/0.05715;             //Nail 
        internal static readonly double NM = 1e9;                     //Nanometer 
        internal static readonly double NLEAIN = 1/5556.0;            //Nautical League (International) 
        internal static readonly double NLEAUK = 1/5559.552;          //Nautical League (UK)
        internal static readonly double NMIINT = 1/1852.0;            //Nautical Mile (International)
        internal static readonly double NMIUK = 1/1853.184;           //Nautical Mile (UK)
        internal static readonly double NMIUS = 1/1853.248;           //Nautical Mile (US) 
        internal static readonly double PER = 1/5.0292;               //Perch
        internal static readonly double PEM = 1e-15;                  //Petameter 
        internal static readonly double PM = 1e12;                    //Picometer 
        internal static readonly double POL = 1/5.0292;               //Pole
        internal static readonly double RD = 1/5.0292;                //Rod
        internal static readonly double ROPE = 1/6.096;               //Rope 
        internal static readonly double SPAN = 1/0.2286;              //Span 
        internal static readonly double TM = 1e-12;                   //Terameter 
        internal static readonly double TIN = 1/0.0000254;            //Thousandth of Inch
        internal static readonly double YD = 1/0.9144;                //Yard

        #endregion
        /// <summary>
        /// Method to perform all conversions within Length class.
        /// All "To" methods within Length use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Length foo = new UnitOf.Length().FromMeters(1.25); //Variable "foo" will be able to convert 1.25 Meters into any unit of Length
        /// </summary>
        public Length FromAngstroms(double v){return s(this,v,A,"A");}
        public Length FromAttometers(double v){return s(this,v,AM,"AM");}
        public Length FromBarleycorns(double v){return s(this,v,BC,"BC");}
        public Length FromCablesImperial(double v){return s(this,v,CBLIMP,"CBLIMP");}
        public Length FromCablesInternational(double v){return s(this,v,CBLIN,"CBLIN");}
        public Length FromCablesUSCustomary(double v){return s(this,v,CBLUS,"CBLUS");}
        public Length FromCaliber(double v){return s(this,v,CL,"CL");}
        public Length FromCentiinches(double v){return s(this,v,CIN,"CIN");}
        public Length FromCentimeters(double v){return s(this,v,CM,"CM");}
        public Length FromChains(double v){return s(this,v,CH,"CH");}
        public Length FromCubits(double v){return s(this,v,CU,"CU");}
        public Length FromDecimeters(double v){return s(this,v,DM,"DM");}
        public Length FromDekameters(double v){return s(this,v,DAM,"DAM");}
        public Length FromElls(double v){return s(this,v,ELL,"ELL");}
        public Length FromExameters(double v){return s(this,v,EM,"EM");}
        public Length FromFathoms(double v){return s(this,v,FTM,"FTM");}
        public Length FromFeet(double v){return s(this,v,FT,"FT");}
        public Length FromFemtometers(double v){return s(this,v,FM,"FM");}
        public Length FromFingers(double v){return s(this,v,FING,"FING");}
        public Length FromFurlongs(double v){return s(this,v,FUR,"FUR");}
        public Length FromGigameters(double v){return s(this,v,GM,"GM");}
        public Length FromHands(double v){return s(this,v,HAND,"HAND");}
        public Length FromHectometers(double v){return s(this,v,HM,"HM");}
        public Length FromInches(double v){return s(this,v,IN,"IN");}
        public Length FromKilometers(double v){return s(this,v,KM,"KM");}
        public Length FromKiloyards(double v){return s(this,v,KYD,"KYD");}
        public Length FromLeagues(double v){return s(this,v,LEA,"LEA");}
        public Length FromLightYears(double v){return s(this,v,LY,"LY");}
        public Length FromLinks(double v){return s(this,v,LNK,"LNK");}
        public Length FromMegameters(double v){return s(this,v,MM,"MM");}
        public Length FromMeters(double v){return s(this,v,M,"M");}
        public Length FromMicroinches(double v){return s(this,v,MUIN,"MUIN");}
        public Length FromMicrometers(double v){return s(this,v,MUM,"MUM");}
        public Length FromMicrons(double v){return s(this,v,MURM,"MURM");}
        public Length FromMiles(double v){return s(this,v,MI,"MI");}
        public Length FromMillimeters(double v){return s(this,v,MILM,"MILM");}
        public Length FromNails(double v){return s(this,v,NAIL,"NAIL");}
        public Length FromNanometers(double v){return s(this,v,NM,"NM");}
        public Length FromNauticalLeaguesInternational(double v){return s(this,v,NLEAIN,"NLEAIN");}
        public Length FromNauticalLeaguesUK(double v){return s(this,v,NLEAUK,"NLEAUK");}
        public Length FromNauticalMilesInternational(double v){return s(this,v,NMIINT,"NMIINT");}
        public Length FromNauticalMilesUK(double v){return s(this,v,NMIUK,"NMIUK");}
        public Length FromNauticalMilesUSCustomary(double v){return s(this,v,NMIUS,"NMIUS");}
        public Length FromPerches(double v){return s(this,v,PER,"PER");}
        public Length FromPetameters(double v){return s(this,v,PEM,"PEM");}
        public Length FromPicometers(double v){return s(this,v,PM,"PM");}
        public Length FromPoles(double v){return s(this,v,POL,"POL");}
        public Length FromRods(double v){return s(this,v,RD,"RD");}
        public Length FromRopes(double v){return s(this,v,ROPE,"ROPE");}
        public Length FromSpans(double v){return s(this,v,SPAN,"SPAN");}
        public Length FromTerameters(double v){return s(this,v,TM,"TM");}
        public Length FromThousandthInches(double v){return s(this,v,TIN,"TIN");}
        public Length FromYards(double v){return s(this,v,YD,"YD");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToFeet(); //Variable "bar" being of type UnitOf.Length with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Length().FromMeters(1.25).ToFeet(); //One line conversion from 1.25 Meters to Feet
        /// </summary>
        public double ToAngstroms(){return c(A);}
        public double ToAttometers(){return c(AM);}
        public double ToBarleycorns(){return c(BC);}
        public double ToCablesImperial(){return c(CBLIMP);}
        public double ToCablesInternational(){return c(CBLIN);}
        public double ToCablesUSCustomary(){return c(CBLUS);}
        public double ToCaliber(){return c(CL);}
        public double ToCentiinches(){return c(CIN);}
        public double ToCentimeters(){return c(CM);}
        public double ToChains(){return c(CH);}
        public double ToCubits(){return c(CU);}
        public double ToDecimeters(){return c(DM);}
        public double ToDekameters(){return c(DAM);}
        public double ToElls(){return c(ELL);}
        public double ToExameters(){return c(EM);}
        public double ToFathoms(){return c(FTM);}
        public double ToFeet(){return c(FT);}
        public double ToFemtometers(){return c(FM);}
        public double ToFingers(){return c(FING);}
        public double ToFurlongs(){return c(FUR);}
        public double ToGigameters(){return c(GM);}
        public double ToHands(){return c(HAND);}
        public double ToHectometers(){return c(HM);}
        public double ToInches(){return c(IN);}
        public double ToKilometers(){return c(KM);}
        public double ToKiloyards(){return c(KYD);}
        public double ToLeagues(){return c(LEA);}
        public double ToLightYears(){return c(LY);}
        public double ToLinks(){return c(LNK);}
        public double ToMegameters(){return c(MM);}
        public double ToMeters(){return c(M);}
        public double ToMicroinches(){return c(MUIN);}
        public double ToMicrometers(){return c(MUM);}
        public double ToMicrons(){return c(MURM);}
        public double ToMiles(){return c(MI);}
        public double ToMillimeters(){return c(MILM);}
        public double ToNails(){return c(NAIL);}
        public double ToNanometers(){return c(NM);}
        public double ToNauticalLeaguesInternational(){return c(NLEAIN);}
        public double ToNauticalLeaguesUK(){return c(NLEAUK);}
        public double ToNauticalMilesInternational(){return c(NMIINT);}
        public double ToNauticalMilesUK(){return c(NMIUK);}
        public double ToNauticalMilesUSCustomary(){return c(NMIUS);}
        public double ToPerches(){return c(PER);}
        public double ToPetameters(){return c(PEM);}
        public double ToPicometers(){return c(PM);}
        public double ToPoles(){return c(POL);}
        public double ToRods(){return c(RD);}
        public double ToRopes(){return c(ROPE);}
        public double ToSpans(){return c(SPAN);}
        public double ToTerameters(){return c(TM);}
        public double ToThousandthInches(){return c(TIN);}
        public double ToYards(){return c(YD);}
    }

    [Serializable]
    public struct O
    {
    }
}