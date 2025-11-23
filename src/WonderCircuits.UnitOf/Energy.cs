using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Energy() / Work
    /// 
    /// Ex: double foo = new UnitOf.Energy().FromJoules(1.25).ToWattSeconds(); //One line conversion from 1.25 Joules to WattSeconds
    /// </summary>
    public class Energy : UnitConverterBase
    {
        #region Constants
        internal static readonly double AJ = 1e18;                    //Attojoule 
        internal static readonly double BTU = 1/1055.05585262;        //British Thermal Unit 
        internal static readonly double BTUTH = 1/1054.349999974;     //Thermochemical British Thermal Unit  
        internal static readonly double BOE = 1/61178632e2;           //Barrel of Oil Equivalent
        internal static readonly double CALIT = 1/4.1868;             //Calorie (International Steam)
        internal static readonly double CALN = 1/4186.8;              //Calorie (Nutritional)
        internal static readonly double CALTH = 1/4.184;              //Calorie (Thermochemical)
        internal static readonly double DYNCM = 1/1e-7;               //Dyne Centimeter 
        internal static readonly double EV = 1/1.60217733e-19;        //Electron Volt
        internal static readonly double ERG = 1e7;                    //Erg 
        internal static readonly double FTLBF = 0.737562149;          //Foot Pound
        internal static readonly double GJ = 1e-9;                    //Gigajoule 
        internal static readonly double GT = 1/4.184e18;              //Gigaton of TNT
        internal static readonly double GWH = 1/36e11;                //Gigawatt Hour
        internal static readonly double GFCM = 10197.16213009;        //Gram Force Centimeter
        internal static readonly double GFM = 101.9716213009;         //Gram Force Meter
        internal static readonly double H = 1/4.3597482e-18;          //Hartree Energy
        internal static readonly double HPH = 1/2684519.537696172792; //Horsepower Hour
        internal static readonly double HPHM = 1/2647795.5;           //Horsepower Hour (Metric)
        internal static readonly double INOZF = 141.611932666;        //Inch Ounce
        internal static readonly double INLBF = 8.850745792;          //Inch Pound
        internal static readonly double J = 1;                        //Joule 
        internal static readonly double KCALIT = 1/4186.8;            //Kilocalorie (International Steam)
        internal static readonly double KCALTH = 1/4184.0;            //Kilocalorie (Thermochemical)
        internal static readonly double KEV = 1/1.60217733e-16;       //Kiloelectron Volt
        internal static readonly double KGFCM = 10.19716213009;       //Kilogram Force Centimeter
        internal static readonly double KGFM = 0.1019716213009;       //Kilogram Force Meter
        internal static readonly double KGT = 1/4184e3;               //Kilogram of TNT 
        internal static readonly double KJ = 1e-3;                    //Kilojoule 
        internal static readonly double KPM = 0.1019716213009;        //Kilopond Meter
        internal static readonly double KT = 1/4.184e12;              //Kiloton of TNT
        internal static readonly double KWH = 1/36e5;                 //Kilowatt Hour
        internal static readonly double KWS = 1e-3;                   //Kilowatt Second
        internal static readonly double LA = 1/101.325;               //Liter Atmosphere
        internal static readonly double MBTU = 1/1055055852.62;       //Mega British Thermal Unit
        internal static readonly double MEV = 1/1.60217733e-13;       //Megaelectron Volt
        internal static readonly double MJ = 1e-6;                    //Megajoule 
        internal static readonly double MT = 1/4.184e15;              //Megaton of TNT
        internal static readonly double MWH = 1/36e8;                 //Megawatt Hour
        internal static readonly double MUJ = 1e6;                    //Microjoule 
        internal static readonly double MILJ = 1e3;                   //Millijoule 
        internal static readonly double NJ = 1e9;                     //Nanojoule 
        internal static readonly double NM = 1;                       //Newton Meter
        internal static readonly double EP = 1/19561e5;               //Planck Energy
        internal static readonly double PDLFT = 1/0.04214011;         //Poundal Foot
        internal static readonly double RY = 1/2.179872e-18;          //Rydberg
        internal static readonly double THMEC = 1/105505600.0;        //Therm (EC)
        internal static readonly double THMUS = 1/105480400.0;        //Therm (US)
        internal static readonly double TT = 1/4184e6;                //Ton of TNT
        internal static readonly double WH = 1/36e2;                  //Watt Hour
        internal static readonly double WS = 1;                       //Watt Second   

        #endregion

        #region From Methods
        public Energy FromAttojoules(double v) { return From(v, AJ, "AJ"); }
        public Energy FromBTUsInternationalStandard(double v) { return From(v, BTU, "BTU"); }
        public Energy FromBTUsThermochemical(double v) { return From(v, BTUTH, "BTUTH"); }
        public Energy FromBarrelsOfOilEquivalent(double v) { return From(v, BOE, "BOE"); }
        public Energy FromCaloriesInternationalSteam(double v) { return From(v, CALIT, "CALIT"); }
        public Energy FromCaloriesNutritional(double v) { return From(v, CALN, "CALN"); }
        public Energy FromCaloriesThermochemical(double v) { return From(v, CALTH, "CALTH"); }
        public Energy FromDyneCentimeters(double v) { return From(v, DYNCM, "DYNCM"); }
        public Energy FromElectronVolts(double v) { return From(v, EV, "EV"); }
        public Energy FromErgs(double v) { return From(v, ERG, "ERG"); }
        public Energy FromFootPounds(double v) { return From(v, FTLBF, "FTLBF"); }
        public Energy FromGigajoules(double v) { return From(v, GJ, "GJ"); }
        public Energy FromGigatonsOfTNT(double v) { return From(v, GT, "GT"); }
        public Energy FromGigawattHours(double v) { return From(v, GWH, "GWH"); }
        public Energy FromGramForceCentimeters(double v) { return From(v, GFCM, "GFCM"); }
        public Energy FromGramForceMeters(double v) { return From(v, GFM, "GFM"); }
        public Energy FromHartrees(double v) { return From(v, H, "H"); }
        public Energy FromHorsepowerHours(double v) { return From(v, HPH, "HPH"); }
        public Energy FromHorsepowerHoursMetric(double v) { return From(v, HPHM, "HPHM"); }
        public Energy FromInchOunces(double v) { return From(v, INOZF, "INOZF"); }
        public Energy FromInchPounds(double v) { return From(v, INLBF, "INLBF"); }
        public Energy FromJoules(double v) { return From(v, J, "J"); }
        public Energy FromKilocaloriesInternationalSteam(double v) { return From(v, KCALIT, "KCALIT"); }
        public Energy FromKilocaloriesThermochemical(double v) { return From(v, KCALTH, "KCALTH"); }
        public Energy FromKiloelectronVolts(double v) { return From(v, KEV, "KEV"); }
        public Energy FromKilogramForceCentimeters(double v) { return From(v, KGFCM, "KGFCM"); }
        public Energy FromKilogramForceMeters(double v) { return From(v, KGFM, "KGFM"); }
        public Energy FromKilogramsOfTNT(double v) { return From(v, KGT, "KGT"); }
        public Energy FromKilojoules(double v) { return From(v, KJ, "KJ"); }
        public Energy FromKilopondMeters(double v) { return From(v, KPM, "KPM"); }
        public Energy FromKilotonsOfTNT(double v) { return From(v, KT, "KT"); }
        public Energy FromKilowattHours(double v) { return From(v, KWH, "KWH"); }
        public Energy FromKilowattSeconds(double v) { return From(v, KWS, "KWS"); }
        public Energy FromLiterAtmospheres(double v) { return From(v, LA, "LA"); }
        public Energy FromMegaBTUsInternationalStandard(double v) { return From(v, MBTU, "MBTU"); }
        public Energy FromMegaelectronVolts(double v) { return From(v, MEV, "MEV"); }
        public Energy FromMegajoules(double v) { return From(v, MJ, "MJ"); }
        public Energy FromMegatonsOfTNT(double v) { return From(v, MT, "MT"); }
        public Energy FromMegawattHours(double v) { return From(v, MWH, "MWH"); }
        public Energy FromMicrojoules(double v) { return From(v, MUJ, "MUJ"); }
        public Energy FromMillijoules(double v) { return From(v, MILJ, "MILJ"); }
        public Energy FromNanojoules(double v) { return From(v, NJ, "NJ"); }
        public Energy FromNewtonMeters(double v) { return From(v, NM, "NM"); }
        public Energy FromPlanckEnergy(double v) { return From(v, EP, "EP"); }
        public Energy FromPoundalFeet(double v) { return From(v, PDLFT, "PDLFT"); }
        public Energy FromRydbergs(double v) { return From(v, RY, "RY"); }
        public Energy FromThermsEC(double v) { return From(v, THMEC, "THMEC"); }
        public Energy FromThermsUS(double v) { return From(v, THMUS, "THMUS"); }
        public Energy FromTonsOfTNT(double v) { return From(v, TT, "TT"); }
        public Energy FromWattHours(double v) { return From(v, WH, "WH"); }
        public Energy FromWattSeconds(double v) { return From(v, WS, "WS"); }

        private Energy From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAttojoules() { return To(AJ); }
        public double ToBTUsInternationalStandard() { return To(BTU); }
        public double ToBTUsThermochemical() { return To(BTUTH); }
        public double ToBarrelsOfOilEquivalent() { return To(BOE); }
        public double ToCaloriesInternationalSteam() { return To(CALIT); }
        public double ToCaloriesNutritional() { return To(CALN); }
        public double ToCaloriesThermochemical() { return To(CALTH); }
        public double ToDyneCentimeters() { return To(DYNCM); }
        public double ToElectronVolts() { return To(EV); }
        public double ToErgs() { return To(ERG); }
        public double ToFootPounds() { return To(FTLBF); }
        public double ToGigajoules() { return To(GJ); }
        public double ToGigatonsOfTNT() { return To(GT); }
        public double ToGigawattHours() { return To(GWH); }
        public double ToGramForceCentimeters() { return To(GFCM); }
        public double ToGramForceMeters() { return To(GFM); }
        public double ToHartrees() { return To(H); }
        public double ToHorsepowerHours() { return To(HPH); }
        public double ToHorsepowerHoursMetric() { return To(HPHM); }
        public double ToInchOunces() { return To(INOZF); }
        public double ToInchPounds() { return To(INLBF); }
        public double ToJoules() { return To(J); }
        public double ToKilocaloriesInternationalSteam() { return To(KCALIT); }
        public double ToKilocaloriesThermochemical() { return To(KCALTH); }
        public double ToKiloelectronVolts() { return To(KEV); }
        public double ToKilogramForceCentimeters() { return To(KGFCM); }
        public double ToKilogramForceMeters() { return To(KGFM); }
        public double ToKilogramsOfTNT() { return To(KGT); }
        public double ToKilojoules() { return To(KJ); }
        public double ToKilopondMeters() { return To(KPM); }
        public double ToKilotonsOfTNT() { return To(KT); }
        public double ToKilowattHours() { return To(KWH); }
        public double ToKilowattSeconds() { return To(KWS); }
        public double ToLiterAtmospheres() { return To(LA); }
        public double ToMegaBTUsInternationalStandard() { return To(MBTU); }
        public double ToMegaelectronVolts() { return To(MEV); }
        public double ToMegajoules() { return To(MJ); }
        public double ToMegatonsOfTNT() { return To(MT); }
        public double ToMegawattHours() { return To(MWH); }
        public double ToMicrojoules() { return To(MUJ); }
        public double ToMillijoules() { return To(MILJ); }
        public double ToNanojoules() { return To(NJ); }
        public double ToNewtonMeters() { return To(NM); }
        public double ToPlanckEnergy() { return To(EP); }
        public double ToPoundalFeet() { return To(PDLFT); }
        public double ToRydbergs() { return To(RY); }
        public double ToThermsEC() { return To(THMEC); }
        public double ToThermsUS() { return To(THMUS); }
        public double ToTonsOfTNT() { return To(TT); }
        public double ToWattHours() { return To(WH); }
        public double ToWattSeconds() { return To(WS); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }

        #endregion
    }
}