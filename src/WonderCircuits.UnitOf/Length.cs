using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Length()
    /// 
    /// Ex: double foo = new UnitOf.Length().FromMeters(1.25).ToFeet(); //One line conversion from 1.25 Meters to Feet
    /// </summary>
    public class Length : UnitConverterBase
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

        #region From Methods
        public Length FromAngstroms(double v) { return From(v, A, "A"); }
        public Length FromAttometers(double v) { return From(v, AM, "AM"); }
        public Length FromBarleycorns(double v) { return From(v, BC, "BC"); }
        public Length FromCablesImperial(double v) { return From(v, CBLIMP, "CBLIMP"); }
        public Length FromCablesInternational(double v) { return From(v, CBLIN, "CBLIN"); }
        public Length FromCablesUSCustomary(double v) { return From(v, CBLUS, "CBLUS"); }
        public Length FromCaliber(double v) { return From(v, CL, "CL"); }
        public Length FromCentiinches(double v) { return From(v, CIN, "CIN"); }
        public Length FromCentimeters(double v) { return From(v, CM, "CM"); }
        public Length FromChains(double v) { return From(v, CH, "CH"); }
        public Length FromCubits(double v) { return From(v, CU, "CU"); }
        public Length FromDecimeters(double v) { return From(v, DM, "DM"); }
        public Length FromDekameters(double v) { return From(v, DAM, "DAM"); }
        public Length FromElls(double v) { return From(v, ELL, "ELL"); }
        public Length FromExameters(double v) { return From(v, EM, "EM"); }
        public Length FromFathoms(double v) { return From(v, FTM, "FTM"); }
        public Length FromFeet(double v) { return From(v, FT, "FT"); }
        public Length FromFemtometers(double v) { return From(v, FM, "FM"); }
        public Length FromFingers(double v) { return From(v, FING, "FING"); }
        public Length FromFurlongs(double v) { return From(v, FUR, "FUR"); }
        public Length FromGigameters(double v) { return From(v, GM, "GM"); }
        public Length FromHands(double v) { return From(v, HAND, "HAND"); }
        public Length FromHectometers(double v) { return From(v, HM, "HM"); }
        public Length FromInches(double v) { return From(v, IN, "IN"); }
        public Length FromKilometers(double v) { return From(v, KM, "KM"); }
        public Length FromKiloyards(double v) { return From(v, KYD, "KYD"); }
        public Length FromLeagues(double v) { return From(v, LEA, "LEA"); }
        public Length FromLightYears(double v) { return From(v, LY, "LY"); }
        public Length FromLinks(double v) { return From(v, LNK, "LNK"); }
        public Length FromMegameters(double v) { return From(v, MM, "MM"); }
        public Length FromMeters(double v) { return From(v, M, "M"); }
        public Length FromMicroinches(double v) { return From(v, MUIN, "MUIN"); }
        public Length FromMicrometers(double v) { return From(v, MUM, "MUM"); }
        public Length FromMicrons(double v) { return From(v, MURM, "MURM"); }
        public Length FromMiles(double v) { return From(v, MI, "MI"); }
        public Length FromMillimeters(double v) { return From(v, MILM, "MILM"); }
        public Length FromNails(double v) { return From(v, NAIL, "NAIL"); }
        public Length FromNanometers(double v) { return From(v, NM, "NM"); }
        public Length FromNauticalLeaguesInternational(double v) { return From(v, NLEAIN, "NLEAIN"); }
        public Length FromNauticalLeaguesUK(double v) { return From(v, NLEAUK, "NLEAUK"); }
        public Length FromNauticalMilesInternational(double v) { return From(v, NMIINT, "NMIINT"); }
        public Length FromNauticalMilesUK(double v) { return From(v, NMIUK, "NMIUK"); }
        public Length FromNauticalMilesUSCustomary(double v) { return From(v, NMIUS, "NMIUS"); }
        public Length FromPerches(double v) { return From(v, PER, "PER"); }
        public Length FromPetameters(double v) { return From(v, PEM, "PEM"); }
        public Length FromPicometers(double v) { return From(v, PM, "PM"); }
        public Length FromPoles(double v) { return From(v, POL, "POL"); }
        public Length FromRods(double v) { return From(v, RD, "RD"); }
        public Length FromRopes(double v) { return From(v, ROPE, "ROPE"); }
        public Length FromSpans(double v) { return From(v, SPAN, "SPAN"); }
        public Length FromTerameters(double v) { return From(v, TM, "TM"); }
        public Length FromThousandthInches(double v) { return From(v, TIN, "TIN"); }
        public Length FromYards(double v) { return From(v, YD, "YD"); }

        private Length From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAngstroms() { return To(A); }
        public double ToAttometers() { return To(AM); }
        public double ToBarleycorns() { return To(BC); }
        public double ToCablesImperial() { return To(CBLIMP); }
        public double ToCablesInternational() { return To(CBLIN); }
        public double ToCablesUSCustomary() { return To(CBLUS); }
        public double ToCaliber() { return To(CL); }
        public double ToCentiinches() { return To(CIN); }
        public double ToCentimeters() { return To(CM); }
        public double ToChains() { return To(CH); }
        public double ToCubits() { return To(CU); }
        public double ToDecimeters() { return To(DM); }
        public double ToDekameters() { return To(DAM); }
        public double ToElls() { return To(ELL); }
        public double ToExameters() { return To(EM); }
        public double ToFathoms() { return To(FTM); }
        public double ToFeet() { return To(FT); }
        public double ToFemtometers() { return To(FM); }
        public double ToFingers() { return To(FING); }
        public double ToFurlongs() { return To(FUR); }
        public double ToGigameters() { return To(GM); }
        public double ToHands() { return To(HAND); }
        public double ToHectometers() { return To(HM); }
        public double ToInches() { return To(IN); }
        public double ToKilometers() { return To(KM); }
        public double ToKiloyards() { return To(KYD); }
        public double ToLeagues() { return To(LEA); }
        public double ToLightYears() { return To(LY); }
        public double ToLinks() { return To(LNK); }
        public double ToMegameters() { return To(MM); }
        public double ToMeters() { return To(M); }
        public double ToMicroinches() { return To(MUIN); }
        public double ToMicrometers() { return To(MUM); }
        public double ToMicrons() { return To(MURM); }
        public double ToMiles() { return To(MI); }
        public double ToMillimeters() { return To(MILM); }
        public double ToNails() { return To(NAIL); }
        public double ToNanometers() { return To(NM); }
        public double ToNauticalLeaguesInternational() { return To(NLEAIN); }
        public double ToNauticalLeaguesUK() { return To(NLEAUK); }
        public double ToNauticalMilesInternational() { return To(NMIINT); }
        public double ToNauticalMilesUK() { return To(NMIUK); }
        public double ToNauticalMilesUSCustomary() { return To(NMIUS); }
        public double ToPerches() { return To(PER); }
        public double ToPetameters() { return To(PEM); }
        public double ToPicometers() { return To(PM); }
        public double ToPoles() { return To(POL); }
        public double ToRods() { return To(RD); }
        public double ToRopes() { return To(ROPE); }
        public double ToSpans() { return To(SPAN); }
        public double ToTerameters() { return To(TM); }
        public double ToThousandthInches() { return To(TIN); }
        public double ToYards() { return To(YD); }
    
        private double To(double t)
        {
            return Conversion(t, true);
        }
        #endregion
    }
}