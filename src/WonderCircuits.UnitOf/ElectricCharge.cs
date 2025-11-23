using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.ElectricCharge()
    /// 
    /// Ex: double foo = new UnitOf.ElectricCharge().FromCoulombs(1.25).ToAmpereHours(); //One line conversion from 1.25 Coulombs to AmpereHours
    /// </summary>
    [Serializable]
    public class ElectricCharge : UnitConverterBase
    {
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

        #region From Methods
        public ElectricCharge FromAbcoulombs(double v) { return From(v, ABC, "ABC"); }
        public ElectricCharge FromAmpereHours(double v) { return From(v, AH, "AH"); }
        public ElectricCharge FromAmpereMinutes(double v) { return From(v, AM, "AM"); }
        public ElectricCharge FromAmpereSeconds(double v) { return From(v, AS, "AS"); }
        public ElectricCharge FromCoulombs(double v) { return From(v, C, "C"); }
        public ElectricCharge FromEMUsOfCharge(double v) { return From(v, EMU, "EMU"); }
        public ElectricCharge FromESUsOfCharge(double v) { return From(v, ESU, "ESU"); }
        public ElectricCharge FromElectronCharge(double v) { return From(v, E, "E"); }
        public ElectricCharge FromFaradVolts(double v) { return From(v, F, "F"); }
        public ElectricCharge FromFaradayCarbon12(double v) { return From(v, FA12, "FA12"); }
        public ElectricCharge FromFaradayChemistry(double v) { return From(v, FACH, "FACH"); }
        public ElectricCharge FromFaradayPhysics(double v) { return From(v, FAPH, "FAPH"); }
        public ElectricCharge FromFranklins(double v) { return From(v, FR, "FR"); }
        public ElectricCharge FromKilocoulombs(double v) { return From(v, KC, "KC"); }
        public ElectricCharge FromMegacoulombs(double v) { return From(v, MC, "MC"); }
        public ElectricCharge FromMicrocoulombs(double v) { return From(v, MUC, "MUC"); }
        public ElectricCharge FromMillicoulombs(double v) { return From(v, MILC, "MILC"); }
        public ElectricCharge FromNanocoulombs(double v) { return From(v, NC, "NC"); }
        public ElectricCharge FromPicocoulombs(double v) { return From(v, PC, "PC"); }
        public ElectricCharge FromStatcoulombs(double v) { return From(v, STC, "STC"); }

        private ElectricCharge From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToAbcoulombs() { return To(ABC); }
        public double ToAmpereHours() { return To(AH); }
        public double ToAmpereMinutes() { return To(AM); }
        public double ToAmpereSeconds() { return To(AS); }
        public double ToCoulombs() { return To(C); }
        public double ToEMUsOfCharge() { return To(EMU); }
        public double ToESUsOfCharge() { return To(ESU); }
        public double ToElectronCharge() { return To(E); }
        public double ToFaradVolts() { return To(F); }
        public double ToFaradayCarbon12() { return To(FA12); }
        public double ToFaradayChemistry() { return To(FACH); }
        public double ToFaradayPhysics() { return To(FAPH); }
        public double ToFranklins() { return To(FR); }
        public double ToKilocoulombs() { return To(KC); }
        public double ToMegacoulombs() { return To(MC); }
        public double ToMicrocoulombs() { return To(MUC); }
        public double ToMillicoulombs() { return To(MILC); }
        public double ToNanocoulombs() { return To(NC); }
        public double ToPicocoulombs() { return To(PC); }
        public double ToStatcoulombs() { return To(STC); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }
        #endregion
    }
}