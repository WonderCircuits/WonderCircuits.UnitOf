using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.DataTransferRate()
    /// 
    /// Ex: double foo = new UnitOf.DataTransferRate().FromMegabytesPerSecond(1.25).ToKilobytesPerSecond(); //One line conversion from 1.25 MegabytesPerSecond to KilobytesPerSecond
    /// </summary>
    public class DataTransferRate : UnitConverterBase
    {
        #region Constants
        internal static readonly double BIS = 1.0 * 8.0 * 1024.0 * 1024.0;            //Bit per Second
        internal static readonly double BS = 1.0 * 1.0 * 1024.0 * 1024.0;             //Byte per Second
        internal static readonly double E10 = (1.0 * 8.0 * 1024.0 * 1024.0) / (Math.Pow(1000, 2) * 10.0);      //10 Base-T Ethernet
        internal static readonly double E100 = (1.0 * 8.0 * 1024.0 * 1024.0) / (Math.Pow(1000, 2) * 100.0);    //100 Base-T Ethernet
        internal static readonly double E1000 = (1.0 * 8.0 * 1024.0 * 1024.0) / (Math.Pow(1000, 2) * 1000.0);  //1000 Base-T Ethernet
        internal static readonly double FW400 = 0.02 * 1.048576;                      //FireWire 400
        internal static readonly double FW800 = 0.01 * 1.048576;                      //FireWire 800
        internal static readonly double FW3200 = 0.0025 * 1.048576;                   //FireWire S1600 and S3200 
        internal static readonly double GBIS = 8/(Math.Pow(1024, 1));                 //Gigabit per Second
        internal static readonly double GBS = 1/(Math.Pow(1024, 1));                  //Gigabyte per Second
        internal static readonly double ISDND = 65.536;                               //ISDN (Dual Channel) 
        internal static readonly double ISDNS = 131.072;                              //ISDN (Single Channel) 
        internal static readonly double KBIS = 8 * 1024;                              //Kilobit per Second
        internal static readonly double KBS = 1024;                                   //Kilobyte per Second
        internal static readonly double MBIS = 8;                                     //Megabit per Second
        internal static readonly double MBS = 1;                                      //Megabyte per Second
        internal static readonly double M110 = (1/110.0) * (8.0 * 1024.0 * 1024.0);   //110 BPS Modem
        internal static readonly double M1200 = (1/1200.0) * (8.0 * 1024.0 * 1024.0); //1200 BPS Modem
        internal static readonly double M14K = (1/14400.0) * (8.0 * 1024.0 * 1024.0); //14.4 KBPS Modem
        internal static readonly double M2400 = (1/2400.0) * (8.0 * 1024.0 * 1024.0); //2400 BPS Modem
        internal static readonly double M28K = (1/28800.0) * (8.0 * 1024.0 * 1024.0); //28.8 KBPS Modem
        internal static readonly double M300 = (1/300.0) * (8.0 * 1024.0 * 1024.0);   //300 BPS Modem
        internal static readonly double M33K = (1/33600.0) * (8.0 * 1024.0 * 1024.0); //33.6 KBPS Modem
        internal static readonly double M56K = (1/56000.0) * (8.0 * 1024.0 * 1024.0); //56 KBPS Modem
        internal static readonly double M9600 = (1/9600.0) * (8.0 * 1024.0 * 1024.0); //9600 BPS Modem
        internal static readonly double OC1 = (1/6.48) * 1.048576;                    //OC1
        internal static readonly double OC12 = (1/(6.48 * 12.0)) * 1.048576;          //OC12
        internal static readonly double OC192 = (1/(6.48 * 192.0)) * 1.048576;        //OC192
        internal static readonly double OC24 = (1/(6.48 * 24.0)) * 1.048576;          //OC24
        internal static readonly double OC3 = (1/(6.48 * 3.0)) * 1.048576;            //OC3
        internal static readonly double OC48 = (1/(6.48 * 48.0)) * 1.048576;          //OC48
        internal static readonly double OC768 = (1/(6.48 * 768.0)) * 1.048576;        //OC768
        internal static readonly double PBIS = 8/(Math.Pow(1024, 3));                 //Petabit per Second
        internal static readonly double PBS = 1/(Math.Pow(1024, 3));                  //Petabyte per Second
        internal static readonly double SIGBIS = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 2);        //SI Gigabit per Second
        internal static readonly double SIGBS = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 2);         //SI Gigabyte per Second
        internal static readonly double SIKBIS = (8 * 1024.0) * (1024 / 1000.0);                              //SI Kilobit per Second
        internal static readonly double SIKBS = (1 * 1024.0) * (1024 / 1000.0);                               //SI Kilobyte per Second
        internal static readonly double SIMBIS = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 1);        //SI Megabit per Second
        internal static readonly double SIMBS = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 1);         //SI Megabyte per Second
        internal static readonly double SIPBIS = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 4);        //SI Petabit per Second
        internal static readonly double SIPBS = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 4);         //SI Petabyte per Second
        internal static readonly double SITBIS = ((8 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 3);        //SI Terabit per Second
        internal static readonly double SITBS = ((1 * 1024.0) * (1024 / 1000.0)) / Math.Pow(1000, 3);         //SI Terabyte per Second
        internal static readonly double TBIS = 8/(Math.Pow(1024, 2));                 //Terabit per Second
        internal static readonly double TBS = 1/(Math.Pow(1024, 2));                  //Terabyte per Second
        internal static readonly double USB1 = (1/1.5) * 1.048576;                    //USB 1.X
        internal static readonly double USB2 = (1/35.0) * 1.048576;                   //USB 2.X
        internal static readonly double USB3 = (1/625.0) * 1.048576;                  //USB 3.0
        internal static readonly double USB31 = (1/1250.0) * 1.048576;                //USB 3.1

        #endregion

        #region From Methods
        public DataTransferRate FromBitsPerSecond(double v) { return From(v, BIS, "BIS"); }
        public DataTransferRate FromBytesPerSecond(double v) { return From(v, BS, "BS"); }
        public DataTransferRate FromEthernetsBase10(double v) { return From(v, E10, "E10"); }
        public DataTransferRate FromEthernetsBase100(double v) { return From(v, E100, "E100"); }
        public DataTransferRate FromEthernetsBase1000(double v) { return From(v, E1000, "E1000"); }
        public DataTransferRate FromFireWires400(double v) { return From(v, FW400, "FW400"); }
        public DataTransferRate FromFireWires800(double v) { return From(v, FW800, "FW800"); }
        public DataTransferRate FromFireWiresS1600_S3200(double v) { return From(v, FW3200, "FW3200"); }
        public DataTransferRate FromGigabitsPerSecond(double v) { return From(v, GBIS, "GBIS"); }
        public DataTransferRate FromGigabytesPerSecond(double v) { return From(v, GBS, "GBS"); }
        public DataTransferRate FromISDNsDual(double v) { return From(v, ISDND, "ISDND"); }
        public DataTransferRate FromISDNsSingle(double v) { return From(v, ISDNS, "ISDNS"); }
        public DataTransferRate FromKilobitsPerSecond(double v) { return From(v, KBIS, "KBIS"); }
        public DataTransferRate FromKilobytesPerSecond(double v) { return From(v, KBS, "KBS"); }
        public DataTransferRate FromMegabitsPerSecond(double v) { return From(v, MBIS, "MBIS"); }
        public DataTransferRate FromMegabytesPerSecond(double v) { return From(v, MBS, "MBS"); }
        public DataTransferRate FromModems110b(double v) { return From(v, M110, "M110"); }
        public DataTransferRate FromModems1200b(double v) { return From(v, M1200, "M1200"); }
        public DataTransferRate FromModems14_4k(double v) { return From(v, M14K, "M14K"); }
        public DataTransferRate FromModems2400b(double v) { return From(v, M2400, "M2400"); }
        public DataTransferRate FromModems28_8k(double v) { return From(v, M28K, "M28K"); }
        public DataTransferRate FromModems300b(double v) { return From(v, M300, "M300"); }
        public DataTransferRate FromModems33_6k(double v) { return From(v, M33K, "M33K"); }
        public DataTransferRate FromModems56k(double v) { return From(v, M56K, "M56K"); }
        public DataTransferRate FromModems9600b(double v) { return From(v, M9600, "M9600"); }
        public DataTransferRate FromOCs1(double v) { return From(v, OC1, "OC1"); }
        public DataTransferRate FromOCs12(double v) { return From(v, OC12, "OC12"); }
        public DataTransferRate FromOCs192(double v) { return From(v, OC192, "OC192"); }
        public DataTransferRate FromOCs24(double v) { return From(v, OC24, "OC24"); }
        public DataTransferRate FromOCs3(double v) { return From(v, OC3, "OC3"); }
        public DataTransferRate FromOCs48(double v) { return From(v, OC48, "OC48"); }
        public DataTransferRate FromOCs768(double v) { return From(v, OC768, "OC768"); }
        public DataTransferRate FromPetabitsPerSecond(double v) { return From(v, PBIS, "PBIS"); }
        public DataTransferRate FromPetabytesPerSecond(double v) { return From(v, PBS, "PBS"); }
        public DataTransferRate FromSIUnitGigabitsPerSecond(double v) { return From(v, SIGBIS, "SIGBIS"); }
        public DataTransferRate FromSIUnitGigabytesPerSecond(double v) { return From(v, SIGBS, "SIGBS"); }
        public DataTransferRate FromSIUnitKilobitsPerSecond(double v) { return From(v, SIKBIS, "SIKBIS"); }
        public DataTransferRate FromSIUnitKilobytesPerSecond(double v) { return From(v, SIKBS, "SIKBS"); }
        public DataTransferRate FromSIUnitMegabitsPerSecond(double v) { return From(v, SIMBIS, "SIMBIS"); }
        public DataTransferRate FromSIUnitMegabytesPerSecond(double v) { return From(v, SIMBS, "SIMBS"); }
        public DataTransferRate FromSIUnitPetabitsPerSecond(double v) { return From(v, SIPBIS, "SIPBIS"); }
        public DataTransferRate FromSIUnitPetabytesPerSecond(double v) { return From(v, SIPBS, "SIPBS"); }
        public DataTransferRate FromSIUnitTerabitsPerSecond(double v) { return From(v, SITBIS, "SITBIS"); }
        public DataTransferRate FromSIUnitTerabytesPerSecond(double v) { return From(v, SITBS, "SITBS"); }
        public DataTransferRate FromTerabitsPerSecond(double v) { return From(v, TBIS, "TBIS"); }
        public DataTransferRate FromTerabytesPerSecond(double v) { return From(v, TBS, "TBS"); }
        public DataTransferRate FromUSBs1_0(double v) { return From(v, USB1, "USB1"); }
        public DataTransferRate FromUSBs2_0(double v) { return From(v, USB2, "USB2"); }
        public DataTransferRate FromUSBs3_0(double v) { return From(v, USB3, "USB3"); }
        public DataTransferRate FromUSBs3_1(double v) { return From(v, USB31, "USB31"); }

        private DataTransferRate From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToBitsPerSecond() { return To(BIS); }
        public double ToBytesPerSecond() { return To(BS); }
        public double ToEthernetsBase10() { return To(E10); }
        public double ToEthernetsBase100() { return To(E100); }
        public double ToEthernetsBase1000() { return To(E1000); }
        public double ToFireWires400() { return To(FW400); }
        public double ToFireWires800() { return To(FW800); }
        public double ToFireWiresS1600_S3200() { return To(FW3200); }
        public double ToGigabitsPerSecond() { return To(GBIS); }
        public double ToGigabytesPerSecond() { return To(GBS); }
        public double ToISDNsDual() { return To(ISDND); }
        public double ToISDNsSingle() { return To(ISDNS); }
        public double ToKilobitsPerSecond() { return To(KBIS); }
        public double ToKilobytesPerSecond() { return To(KBS); }
        public double ToMegabitsPerSecond() { return To(MBIS); }
        public double ToMegabytesPerSecond() { return To(MBS); }
        public double ToModems110b() { return To(M110); }
        public double ToModems1200b() { return To(M1200); }
        public double ToModems14_4k() { return To(M14K); }
        public double ToModems2400b() { return To(M2400); }
        public double ToModems28_8k() { return To(M28K); }
        public double ToModems300b() { return To(M300); }
        public double ToModems33_6k() { return To(M33K); }
        public double ToModems56k() { return To(M56K); }
        public double ToModems9600b() { return To(M9600); }
        public double ToOCs1() { return To(OC1); }
        public double ToOCs12() { return To(OC12); }
        public double ToOCs192() { return To(OC192); }
        public double ToOCs24() { return To(OC24); }
        public double ToOCs3() { return To(OC3); }
        public double ToOCs48() { return To(OC48); }
        public double ToOCs768() { return To(OC768); }
        public double ToPetabitsPerSecond() { return To(PBIS); }
        public double ToPetabytesPerSecond() { return To(PBS); }
        public double ToSIUnitGigabitsPerSecond() { return To(SIGBIS); }
        public double ToSIUnitGigabytesPerSecond() { return To(SIGBS); }
        public double ToSIUnitKilobitsPerSecond() { return To(SIKBIS); }
        public double ToSIUnitKilobytesPerSecond() { return To(SIKBS); }
        public double ToSIUnitMegabitsPerSecond() { return To(SIMBIS); }
        public double ToSIUnitMegabytesPerSecond() { return To(SIMBS); }
        public double ToSIUnitPetabitsPerSecond() { return To(SIPBIS); }
        public double ToSIUnitPetabytesPerSecond() { return To(SIPBS); }
        public double ToSIUnitTerabitsPerSecond() { return To(SITBIS); }
        public double ToSIUnitTerabytesPerSecond() { return To(SITBS); }
        public double ToTerabitsPerSecond() { return To(TBIS); }
        public double ToTerabytesPerSecond() { return To(TBS); }
        public double ToUSBs1_0() { return To(USB1); }
        public double ToUSBs2_0() { return To(USB2); }
        public double ToUSBs3_0() { return To(USB3); }
        public double ToUSBs3_1() { return To(USB31); }

        private double To(double t)
        {
            return Conversion(t, true);
        }
        #endregion
    }
}