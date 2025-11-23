namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.ElectricCharge()
    /// 
    /// Ex: double foo = new UnitOf.ElectricCharge().FromCoulombs(1.25).ToAmpereHours(); //One line conversion from 1.25 Coulombs to AmpereHours
    /// </summary>
    [Serializable]
    public class ElectricCharge : ConverterBase{

        #region Constants
        internal static readonly double ABC = 1e5;                //Abcoulomb
        internal static readonly double AH = 1/0.0036;            //Ampere Hour
        internal static readonly double AM = 1/0.00006;           //Ampere Minute
        internal static readonly double AS = 1e6;                 //Ampere Second
        internal static readonly double C = 1e6;                  //Coulomb
        internal static readonly double EMU = 1e5;                //EMU of Charge
        internal static readonly double ESU = 2.99792457999957e15;//ESU of Charge
        internal static readonly double E = 1/1.60217646e-25;     //Electron Vharge
        internal static readonly double F = 1e6;                  //Farad Volt
        internal static readonly double FA12 = 1/0.0964853103;    //Faraday (Carbon 12)
        internal static readonly double FACH = 1/0.0964957007;    //Faraday (Chemistry)
        internal static readonly double FAPH = 1/0.0965219008;    //Faraday (Physics)
        internal static readonly double FR = 2.99792457999957e15; //Franklin
        internal static readonly double KC = 1e3;                 //Kilocoulomb
        internal static readonly double MC = 1;                   //Megacoulomb
        internal static readonly double MUC = 1e12;               //Microcoulomb
        internal static readonly double MILC = 1e9;               //Millicoulomb
        internal static readonly double NC = 1e15;                //Nanocoulomb
        internal static readonly double PC = 1e18;                //Picocoulomb
        internal static readonly double STC = 2.99792457999957e15;//Statcoulomb

        #endregion
        /// <summary>
        /// Method to perform all conversions within ElectricCharge class.
        /// All "To" methods within ElectricCharge use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.ElectricCharge foo = new UnitOf.ElectricCharge().FromCoulombs(1.25); //Variable "foo" will be able to convert 1.25 Coulombs into any unit of ElectricCharge
        /// </summary>
        public ElectricCharge FromAbcoulombs(double v){return s(this,v,ABC,"ABC");}
        public ElectricCharge FromAmpereHours(double v){return s(this,v,AH,"AH");}
        public ElectricCharge FromAmpereMinutes(double v){return s(this,v,AM,"AM");}
        public ElectricCharge FromAmpereSeconds(double v){return s(this,v,AS,"AS");}
        public ElectricCharge FromCoulombs(double v){return s(this,v,C,"C");}
        public ElectricCharge FromEMUsOfCharge(double v){return s(this,v,EMU,"EMU");}
        public ElectricCharge FromESUsOfCharge(double v){return s(this,v,ESU,"ESU");}
        public ElectricCharge FromElectronCharge(double v){return s(this,v,E,"E");}
        public ElectricCharge FromFaradVolts(double v){return s(this,v,F,"F");}
        public ElectricCharge FromFaradayCarbon12(double v){return s(this,v,FA12,"FA12");}
        public ElectricCharge FromFaradayChemistry(double v){return s(this,v,FACH,"FACH");}
        public ElectricCharge FromFaradayPhysics(double v){return s(this,v,FAPH,"FAPH");}
        public ElectricCharge FromFranklins(double v){return s(this,v,FR,"FR");}
        public ElectricCharge FromKilocoulombs(double v){return s(this,v,KC,"KC");}
        public ElectricCharge FromMegacoulombs(double v){return s(this,v,MC,"MC");}
        public ElectricCharge FromMicrocoulombs(double v){return s(this,v,MUC,"MUC");}
        public ElectricCharge FromMillicoulombs(double v){return s(this,v,MILC,"MILC");}
        public ElectricCharge FromNanocoulombs(double v){return s(this,v,NC,"NC");}
        public ElectricCharge FromPicocoulombs(double v){return s(this,v,PC,"PC");}
        public ElectricCharge FromStatcoulombs(double v){return s(this,v,STC,"STC");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToAmpereHours(); //Variable "bar" being of type UnitOf.ElectricCharge with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.ElectricCharge().FromCoulombs(1.25).ToAmpereHours(); //One line conversion from 1.25 Coulombs to AmpereHours
        /// </summary>
        public double ToAbcoulombs(){return c(ABC);}
        public double ToAmpereHours(){return c(AH);}
        public double ToAmpereMinutes(){return c(AM);}
        public double ToAmpereSeconds(){return c(AS);}
        public double ToCoulombs(){return c(C);}
        public double ToEMUsOfCharge(){return c(EMU);}
        public double ToESUsOfCharge(){return c(ESU);}
        public double ToElectronCharge(){return c(E);}
        public double ToFaradVolts(){return c(F);}
        public double ToFaradayCarbon12(){return c(FA12);}
        public double ToFaradayChemistry(){return c(FACH);}
        public double ToFaradayPhysics(){return c(FAPH);}
        public double ToFranklins(){return c(FR);}
        public double ToKilocoulombs(){return c(KC);}
        public double ToMegacoulombs(){return c(MC);}
        public double ToMicrocoulombs(){return c(MUC);}
        public double ToMillicoulombs(){return c(MILC);}
        public double ToNanocoulombs(){return c(NC);}
        public double ToPicocoulombs(){return c(PC);}
        public double ToStatcoulombs(){return c(STC);}
    }
}