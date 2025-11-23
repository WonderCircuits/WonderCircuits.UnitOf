namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.Energy() / Work
    /// 
    /// Ex: double foo = new UnitOf.Energy().FromJoules(1.25).ToWattSeconds(); //One line conversion from 1.25 Joules to WattSeconds
    /// </summary>
    [Serializable]
    public class Energy : ConverterBase{

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

        /// <summary>
        /// Method to perform all conversions within Energy class.
        /// All "To" methods within Energy use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Energy foo = new UnitOf.Energy().FromJoules(1.25); //Variable "foo" will be able to convert 1.25 Joules into any unit of Energy
        /// </summary>
        public Energy FromAttojoules(double v){return s(this,v,AJ,"AJ");}
        public Energy FromBTUsInternationalStandard(double v){return s(this,v,BTU,"BTU");}
        public Energy FromBTUsThermochemical(double v){return s(this, v, BTUTH, "BTUTH");}
        public Energy FromBarrelsOfOilEquivalent(double v){return s(this,v,BOE,"BOE");}
        public Energy FromCaloriesInternationalSteam(double v){return s(this,v,CALIT,"CALIT");}
        public Energy FromCaloriesNutritional(double v){return s(this,v,CALN,"CALN");}
        public Energy FromCaloriesThermochemical(double v){return s(this,v,CALTH,"CALTH");}
        public Energy FromDyneCentimeters(double v){return s(this,v,DYNCM,"DYNCM");}
        public Energy FromElectronVolts(double v){return s(this,v,EV,"EV");}
        public Energy FromErgs(double v){return s(this,v,ERG,"ERG");}
        public Energy FromFootPounds(double v){return s(this,v,FTLBF,"FTLBF");}
        public Energy FromGigajoules(double v){return s(this,v,GJ,"GJ");}
        public Energy FromGigatonsOfTNT(double v){return s(this, v, GT, "GT");}
        public Energy FromGigawattHours(double v){return s(this,v,GWH,"GWH");}
        public Energy FromGramForceCentimeters(double v){return s(this,v,GFCM,"GFCM");}
        public Energy FromGramForceMeters(double v){return s(this,v,GFM,"GFM");}
        public Energy FromHartrees(double v){return s(this,v,H,"H");}
        public Energy FromHorsepowerHours(double v){return s(this,v,HPH,"HPH");}
        public Energy FromHorsepowerHoursMetric(double v){return s(this,v,HPHM,"HPHM");}
        public Energy FromInchOunces(double v){return s(this,v,INOZF,"INOZF");}
        public Energy FromInchPounds(double v){return s(this,v,INLBF,"INLBF");}
        public Energy FromJoules(double v){return s(this,v,J,"J");}
        public Energy FromKilocaloriesInternationalSteam(double v){return s(this,v,KCALIT,"KCALIT");}
        public Energy FromKilocaloriesThermochemical(double v){return s(this,v,KCALTH,"KCALTH");}
        public Energy FromKiloelectronVolts(double v){return s(this,v,KEV,"KEV");}
        public Energy FromKilogramForceCentimeters(double v){return s(this,v,KGFCM,"KGFCM");}
        public Energy FromKilogramForceMeters(double v){return s(this,v,KGFM,"KGFM");}
        public Energy FromKilogramsOfTNT(double v){return s(this, v, KGT, "KGT");}
        public Energy FromKilojoules(double v){return s(this,v,KJ,"KJ");}
        public Energy FromKilopondMeters(double v){return s(this,v,KPM,"KPM");}
        public Energy FromKilotonsOfTNT(double v){return s(this, v, KT, "KT");}
        public Energy FromKilowattHours(double v){return s(this,v,KWH,"KWH");}
        public Energy FromKilowattSeconds(double v){return s(this,v,KWS,"KWS");}
        public Energy FromLiterAtmospheres(double v){return s(this,v,LA,"LA");}
        public Energy FromMegaBTUsInternationalStandard(double v){return s(this, v, MBTU, "MBTU");}
        public Energy FromMegaelectronVolts(double v){return s(this,v,MEV,"MEV");}
        public Energy FromMegajoules(double v){return s(this,v,MJ,"MJ");}
        public Energy FromMegatonsOfTNT(double v){return s(this, v, MT, "MT");}
        public Energy FromMegawattHours(double v){return s(this,v,MWH,"MWH");}
        public Energy FromMicrojoules(double v){return s(this,v,MUJ,"MUJ");}
        public Energy FromMillijoules(double v){return s(this,v,MILJ,"MILJ");}
        public Energy FromNanojoules(double v){return s(this,v,NJ,"NJ");}
        public Energy FromNewtonMeters(double v){return s(this,v,NM,"NM");}
        public Energy FromPlanckEnergy(double v){return s(this,v,EP,"EP");}
        public Energy FromPoundalFeet(double v){return s(this,v,PDLFT,"PDLFT");}
        public Energy FromRydbergs(double v){return s(this,v,RY,"RY");}
        public Energy FromThermsEC(double v){return s(this,v,THMEC,"THMEC");}
        public Energy FromThermsUS(double v){return s(this,v,THMUS,"THMUS");}
        public Energy FromTonsOfTNT(double v){return s(this, v, TT, "TT");}
        public Energy FromWattHours(double v){return s(this,v,WH,"WH");}
        public Energy FromWattSeconds(double v){return s(this,v,WS,"WS");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToWattSeconds(); //Variable "bar" being of type UnitOf.Energy with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.Energy().FromJoules(1.25).ToWattSeconds(); //One line conversion from 1.25 Joules to WattSeconds
        /// </summary>
        public double ToAttojoules(){return c(AJ);}
        public double ToBTUsInternationalStandard(){return c(BTU);}
        public double ToBTUsThermochemical(){return c(BTUTH);}
        public double ToBarrelsOfOilEquivalent(){return c(BOE);}
        public double ToCaloriesInternationalSteam(){return c(CALIT);}
        public double ToCaloriesNutritional(){return c(CALN);}
        public double ToCaloriesThermochemical(){return c(CALTH);}
        public double ToDyneCentimeters(){return c(DYNCM);}
        public double ToElectronVolts(){return c(EV);}
        public double ToErgs(){return c(ERG);}
        public double ToFootPounds(){return c(FTLBF);}
        public double ToGigajoules(){return c(GJ);}
        public double ToGigatonsOfTNT(){return c(GT);}
        public double ToGigawattHours(){return c(GWH);}
        public double ToGramForceCentimeters(){return c(GFCM);}
        public double ToGramForceMeters(){return c(GFM);}
        public double ToHartrees(){return c(H);}
        public double ToHorsepowerHours(){return c(HPH);}
        public double ToHorsepowerHoursMetric(){return c(HPHM);}
        public double ToInchOunces(){return c(INOZF);}
        public double ToInchPounds(){return c(INLBF);}
        public double ToJoules(){return c(J);}
        public double ToKilocaloriesInternationalSteam(){return c(KCALIT);}
        public double ToKilocaloriesThermochemical(){return c(KCALTH);}
        public double ToKiloelectronVolts(){return c(KEV);}
        public double ToKilogramForceCentimeters(){return c(KGFCM);}
        public double ToKilogramForceMeters(){return c(KGFM);}
        public double ToKilogramsOfTNT(){return c(KGT);}
        public double ToKilojoules(){return c(KJ);}
        public double ToKilopondMeters(){return c(KPM);}
        public double ToKilotonsOfTNT(){return c(KT);}
        public double ToKilowattHours(){return c(KWH);}
        public double ToKilowattSeconds(){return c(KWS);}
        public double ToLiterAtmospheres(){return c(LA);}
        public double ToMegaBTUsInternationalStandard(){return c(MBTU);}
        public double ToMegaelectronVolts(){return c(MEV);}
        public double ToMegajoules(){return c(MJ);}
        public double ToMegatonsOfTNT(){return c(MT);}
        public double ToMegawattHours(){return c(MWH);}
        public double ToMicrojoules(){return c(MUJ);}
        public double ToMillijoules(){return c(MILJ);}
        public double ToNanojoules(){return c(NJ);}
        public double ToNewtonMeters(){return c(NM);}
        public double ToPlanckEnergy(){return c(EP);}
        public double ToPoundalFeet(){return c(PDLFT);}
        public double ToRydbergs(){return c(RY);}
        public double ToThermsEC(){return c(THMEC);}
        public double ToThermsUS(){return c(THMUS);}
        public double ToTonsOfTNT(){return c(TT);}
        public double ToWattHours(){return c(WH);}
        public double ToWattSeconds(){return c(WS);}
    }
}