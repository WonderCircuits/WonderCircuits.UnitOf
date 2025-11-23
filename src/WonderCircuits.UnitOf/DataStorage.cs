using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.DataStorage()
    /// 
    /// double foo = new UnitOf.DataStorage().FromMegabytes(1.25)ToKilobytes(); //One line conversion from 1.25 Megabytes to Kilobytes
    /// </summary>
    public class DataStorage : UnitConverterBase
    {
        #region Constants
        internal static readonly double B = 1.0 * 8.0 * 1024.0 * 1024.0;  //Bit
        internal static readonly double BL = 1.0 * 1.0 * 2.0 * 1024.0;    //Block
        internal static readonly double BD2 = 1/51200.0;                  //Blu-ray Disc (Double-Layer)
        internal static readonly double BD1 = 1/25600.0;                  //Blu-ray Disc (Single-Layer)
        internal static readonly double BY = 1.0 * 1.0 * 1024.0 * 1024.0; //Byte
        internal static readonly double CD74 = 1/(665096.0/1024.0);       //CD (74 Minute)
        internal static readonly double CD80 = 1/702.170607567;           //CD (80 Minute)
        internal static readonly double D22 = 1/17408.0;                  //DVD (2 Layer 2 Side)
        internal static readonly double D12 = 1/9625.6;                   //DVD (1 Layer 2 Side)
        internal static readonly double D21 = 1/8704.0;                   //DVD (2 Layer 1 Side)
        internal static readonly double D11 = 1/4812.8;                   //DVD (1 Layer 1 Side)
        internal static readonly double EBI = 8/(Math.Pow(1024, 4));      //Exabit
        internal static readonly double EB = 1/(Math.Pow(1024, 4));       //Exabyte 
        internal static readonly double F35DD = 1/(711.75/1024.0);        //Floppy Disk (3.5 DD)
        internal static readonly double F35ED = 1/(2847.0/1024.0);        //Floppy Disk (3.5 ED)
        internal static readonly double F35HD = 1/(1423.5/1024.0);        //Floppy Disk (3.5 HD)
        internal static readonly double F525DD = 1/(355.875/1024.0);      //Floppy Disk (5.25 DD)
        internal static readonly double F525HD = 1/(1185.5/1024.0);       //Floppy Disk (5.25 HD)
        internal static readonly double GBI = 8/(Math.Pow(1024, 1));      //Gigabit
        internal static readonly double GB = 1/(Math.Pow(1024, 1));       //Gigbyte
        internal static readonly double KBI = 8 * 1024;                   //Kilobit
        internal static readonly double KB = 1024;                        //Kilobyte
        internal static readonly double MBI = 8;                          //Megabit
        internal static readonly double MB = 1;                           //Megabyte
        internal static readonly double NI = 1.0 * 2.0 * 1024.0 * 1024.0; //Nibble 
        internal static readonly double PBI = 8/(Math.Pow(1024, 3));     //Petabit
        internal static readonly double PB = 1/(Math.Pow(1024, 3));      //Petabyte
        internal static readonly double SIEBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 5); //SI Exabit
        internal static readonly double SIEB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 5);  //SI Exabyte
        internal static readonly double SIGBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 2); //SI Gigabit
        internal static readonly double SIGB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 2);  //SI Gigbyte
        internal static readonly double SIKBI = (8 * 1024.0) * (1024 / 1000.0);                       //SI Kilobit
        internal static readonly double SIKB = (1 * 1024.0) * (1024 / 1000.0);                        //SI Kilobyte
        internal static readonly double SIMBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 1); //SI Megabit
        internal static readonly double SIMB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 1);  //SI Megabyte
        internal static readonly double SIPBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 4); //SI Petabit
        internal static readonly double SIPB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 4);  //SI Petabyte
        internal static readonly double SITBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 3); //SI Terabit
        internal static readonly double SITB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 3);  //SI Terabyte
        internal static readonly double SIYBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 7); //SI Yottabit
        internal static readonly double SIYB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 7);  //SI Yottabyte
        internal static readonly double SIZBI = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 6); //SI Zettabit
        internal static readonly double SIZB = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 6);  //SI Zettabyte   
        internal static readonly double TBI = 8/(Math.Pow(1024, 2));      //Terabit
        internal static readonly double TB = 1/(Math.Pow(1024, 2));       //Terabyte
        internal static readonly double W = 1.0 * 1.0 * 512.0 * 1024.0;   //Word
        internal static readonly double YBI = 8/(Math.Pow(1024, 6));      //Yottabit
        internal static readonly double YB = 1/(Math.Pow(1024, 6));       //Yottabyte
        internal static readonly double ZBI = 8/(Math.Pow(1024, 5));      //Zettabit
        internal static readonly double ZB = 1/(Math.Pow(1024, 5));       //Zettabyte

        #endregion

        #region From Methods
        public DataStorage FromBits(double v) { return From(v, B, "B"); }
        public DataStorage FromBlocks(double v) { return From(v, BL, "BL"); }
        public DataStorage FromBluRay_DoubleLayer(double v) { return From(v, BD2, "BD2"); }
        public DataStorage FromBluRay_SingleLayer(double v) { return From(v, BD1, "BD1"); }
        public DataStorage FromBytes(double v) { return From(v, BY, "BY"); }
        public DataStorage FromCDs_74Minutes(double v) { return From(v, CD74, "CD74"); }
        public DataStorage FromCDs_80Minutes(double v) { return From(v, CD80, "CD80"); }
        public DataStorage FromDVDs_DoubleSidedDoubleLayer(double v) { return From(v, D22, "D22"); }
        public DataStorage FromDVDs_DoubleSidedSingleLayer(double v) { return From(v, D12, "D12"); }
        public DataStorage FromDVDs_SingleSidedDoubleLayer(double v) { return From(v, D21, "D21"); }
        public DataStorage FromDVDs_SingleSidedSingleLayer(double v) { return From(v, D11, "D11"); }
        public DataStorage FromExabits(double v) { return From(v, EBI, "EBI"); }
        public DataStorage FromExabytes(double v) { return From(v, EB, "EB"); }
        public DataStorage FromFloppyDisks_35DD(double v) { return From(v, F35DD, "F35DD"); }
        public DataStorage FromFloppyDisks_35ED(double v) { return From(v, F35ED, "F35ED"); }
        public DataStorage FromFloppyDisks_35HD(double v) { return From(v, F35HD, "F35HD"); }
        public DataStorage FromFloppyDisks_525DD(double v) { return From(v, F525DD, "F525DD"); }
        public DataStorage FromFloppyDisks_525HD(double v) { return From(v, F525HD, "F525HD"); }
        public DataStorage FromGigabits(double v) { return From(v, GBI, "GBI"); }
        public DataStorage FromGigabytes(double v) { return From(v, GB, "GB"); }
        public DataStorage FromKilobits(double v) { return From(v, KBI, "KBI"); }
        public DataStorage FromKilobytes(double v) { return From(v, KB, "KB"); }
        public DataStorage FromMegabits(double v) { return From(v, MBI, "MBI"); }
        public DataStorage FromMegabytes(double v) { return From(v, MB, "MB"); }
        public DataStorage FromNibbles(double v) { return From(v, NI, "NI"); }
        public DataStorage FromPetabits(double v) { return From(v, PBI, "PBI"); }
        public DataStorage FromPetabytes(double v) { return From(v, PB, "PB"); }
        public DataStorage FromSIUnitExabits(double v) { return From(v, SIEBI, "SIEBI"); }
        public DataStorage FromSIUnitExabytes(double v) { return From(v, SIEB, "SIEB"); }
        public DataStorage FromSIUnitGigabits(double v) { return From(v, SIGBI, "SIGBI"); }
        public DataStorage FromSIUnitGigabytes(double v) { return From(v, SIGB, "SIGB"); }
        public DataStorage FromSIUnitKilobits(double v) { return From(v, SIKBI, "SIKBI"); }
        public DataStorage FromSIUnitKilobytes(double v) { return From(v, SIKB, "SIKB"); }
        public DataStorage FromSIUnitMegabits(double v) { return From(v, SIMBI, "SIMBI"); }
        public DataStorage FromSIUnitMegabytes(double v) { return From(v, SIMB, "SIMB"); }
        public DataStorage FromSIUnitPetabits(double v) { return From(v, SIPBI, "SIPBI"); }
        public DataStorage FromSIUnitPetabytes(double v) { return From(v, SIPB, "SIPB"); }
        public DataStorage FromSIUnitTerabits(double v) { return From(v, SITBI, "SITBI"); }
        public DataStorage FromSIUnitTerabytes(double v) { return From(v, SITB, "SITB"); }
        public DataStorage FromSIUnitYottabits(double v) { return From(v, SIYBI, "SIYBI"); }
        public DataStorage FromSIUnitYottabytes(double v) { return From(v, SIYB, "SIYB"); }
        public DataStorage FromSIUnitZettabits(double v) { return From(v, SIZBI, "SIZBI"); }
        public DataStorage FromSIUnitZettabytes(double v) { return From(v, SIZB, "SIZB"); }
        public DataStorage FromTerabits(double v) { return From(v, TBI, "TBI"); }
        public DataStorage FromTerabytes(double v) { return From(v, TB, "TB"); }
        public DataStorage FromWords(double v) { return From(v, W, "W"); }
        public DataStorage FromYottabits(double v) { return From(v, YBI, "YBI"); }
        public DataStorage FromYottabytes(double v) { return From(v, YB, "YB"); }
        public DataStorage FromZettabits(double v) { return From(v, ZBI, "ZBI"); }
        public DataStorage FromZettabytes(double v) { return From(v, ZB, "ZB"); }

        private DataStorage From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToBits() { return To(B); }
        public double ToBlocks() { return To(BL); }
        public double ToBluRay_DoubleLayer() { return To(BD2); }
        public double ToBluRay_SingleLayer() { return To(BD1); }
        public double ToBytes() { return To(BY); }
        public double ToCDs_74Minutes() { return To(CD74); }
        public double ToCDs_80Minutes() { return To(CD80); }
        public double ToDVDs_DoubleSidedDoubleLayer() { return To(D22); }
        public double ToDVDs_DoubleSidedSingleLayer() { return To(D12); }
        public double ToDVDs_SingleSidedDoubleLayer() { return To(D21); }
        public double ToDVDs_SingleSidedSingleLayer() { return To(D11); }
        public double ToExabits() { return To(EBI); }
        public double ToExabytes() { return To(EB); }
        public double ToFloppyDisks_35DD() { return To(F35DD); }
        public double ToFloppyDisks_35ED() { return To(F35ED); }
        public double ToFloppyDisks_35HD() { return To(F35HD); }
        public double ToFloppyDisks_525DD() { return To(F525DD); }
        public double ToFloppyDisks_525HD() { return To(F525HD); }
        public double ToGigabits() { return To(GBI); }
        public double ToGigabytes() { return To(GB); }
        public double ToKilobits() { return To(KBI); }
        public double ToKilobytes() { return To(KB); }
        public double ToMegabits() { return To(MBI); }
        public double ToMegabytes() { return To(MB); }
        public double ToNibbles() { return To(NI); }
        public double ToPetabits() { return To(PBI); }
        public double ToPetabytes() { return To(PB); }
        public double ToSIUnitExabits() { return To(SIEBI); }
        public double ToSIUnitExabytes() { return To(SIEB); }
        public double ToSIUnitGigabits() { return To(SIGBI); }
        public double ToSIUnitGigabytes() { return To(SIGB); }
        public double ToSIUnitKilobits() { return To(SIKBI); }
        public double ToSIUnitKilobytes() { return To(SIKB); }
        public double ToSIUnitMegabits() { return To(SIMBI); }
        public double ToSIUnitMegabytes() { return To(SIMB); }
        public double ToSIUnitPetabits() { return To(SIPBI); }
        public double ToSIUnitPetabytes() { return To(SIPB); }
        public double ToSIUnitTerabits() { return To(SITBI); }
        public double ToSIUnitTerabytes() { return To(SITB); }
        public double ToSIUnitYottabits() { return To(SIYBI); }
        public double ToSIUnitYottabytes() { return To(SIYB); }
        public double ToSIUnitZettabits() { return To(SIZBI); }
        public double ToSIUnitZettabytes() { return To(SIZB); }
        public double ToTerabits() { return To(TBI); }
        public double ToTerabytes() { return To(TB); }
        public double ToWords() { return To(W); }
        public double ToYottabits() { return To(YBI); }
        public double ToYottabytes() { return To(YB); }
        public double ToZettabits() { return To(ZBI); }
        public double ToZettabytes() { return To(ZB); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.MeasumentValue, true);
        }
        #endregion
    }
}