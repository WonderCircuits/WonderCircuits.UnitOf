namespace WonderCircuits.UnitOf {
    /// <summary>
    /// UnitOf.DataStorage()
    /// 
    /// double foo = new UnitOf.DataStorage().FromMegabytes(1.25)ToKilobytes(); //One line conversion from 1.25 Megabytes to Kilobytes
    /// </summary>
    [Serializable]
    public class DataStorage : ConverterBase{
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
        /// <summary>
        /// Method to perform all conversions within DataStorage class.
        /// All "To" methods within DataStorage use this method.
        /// </summary>
        private double c(double t){
            return Conversion(t,me.t);
        }

        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.DataStorage foo = new UnitOf.DataStorage().FromMegabytes(1.25); //Variable "foo" will be able to convert 1.25 Megabytes into any unit of DataStorage
        /// </summary>
        public DataStorage FromBits(double v){return s(this,v,B,"B");}
        public DataStorage FromBlocks(double v){return s(this,v,BL,"BL");}
        public DataStorage FromBluRay_DoubleLayer(double v){return s(this,v,BD2,"BD2");}
        public DataStorage FromBluRay_SingleLayer(double v){return s(this,v,BD1,"BD1");}
        public DataStorage FromBytes(double v){return s(this,v,BY,"BY");}
        public DataStorage FromCDs_74Minutes(double v) {return s(this,v,CD74,"CD74");}
        public DataStorage FromCDs_80Minutes(double v) {return s(this,v,CD80,"CD80");}
        public DataStorage FromDVDs_DoubleSidedDoubleLayer(double v) {return s(this,v,D22,"D22");}
        public DataStorage FromDVDs_DoubleSidedSingleLayer(double v) {return s(this,v,D12,"D12");}
        public DataStorage FromDVDs_SingleSidedDoubleLayer(double v) {return s(this,v,D21,"D21");}
        public DataStorage FromDVDs_SingleSidedSingleLayer(double v) {return s(this,v,D11,"D11");}
        public DataStorage FromExabits(double v){return s(this,v,EBI,"EBI");}
        public DataStorage FromExabytes(double v){return s(this,v,EB,"EB");}
        public DataStorage FromFloppyDisks_35DD(double v){return s(this,v,F35DD,"F35DD");}
        public DataStorage FromFloppyDisks_35ED(double v) {return s(this,v,F35ED,"F35ED");}
        public DataStorage FromFloppyDisks_35HD(double v) {return s(this,v,F35HD,"F35HD");}
        public DataStorage FromFloppyDisks_525DD(double v) {return s(this,v,F525DD,"F525DD");}
        public DataStorage FromFloppyDisks_525HD(double v) {return s(this,v,F525HD,"F525HD");}
        public DataStorage FromGigabits(double v){return s(this,v,GBI,"GBI");}
        public DataStorage FromGigabytes(double v){return s(this,v,GB,"GB");}
        public DataStorage FromKilobits(double v){return s(this,v,KBI,"KBI");}
        public DataStorage FromKilobytes(double v){return s(this,v,KB,"KB");}
        public DataStorage FromMegabits(double v){return s(this,v,MBI,"MBI");}
        public DataStorage FromMegabytes(double v){return s(this,v,MB,"MB");}
        public DataStorage FromNibbles(double v){return s(this,v,NI,"NI");}
        public DataStorage FromPetabits(double v){return s(this,v,PBI,"PBI");}
        public DataStorage FromPetabytes(double v){return s(this,v,PB,"PB");}
        public DataStorage FromSIUnitExabits(double v){return s(this,v,SIEBI,"SIEBI");}
        public DataStorage FromSIUnitExabytes(double v){return s(this,v,SIEB,"SIEB");}
        public DataStorage FromSIUnitGigabits(double v){return s(this,v,SIGBI,"SIGBI");}
        public DataStorage FromSIUnitGigabytes(double v){return s(this,v,SIGB,"SIGB");}
        public DataStorage FromSIUnitKilobits(double v){return s(this,v,SIKBI,"SIKBI");}
        public DataStorage FromSIUnitKilobytes(double v){return s(this,v,SIKB,"SIKB");}
        public DataStorage FromSIUnitMegabits(double v){return s(this,v,SIMBI,"SIMBI");}
        public DataStorage FromSIUnitMegabytes(double v){return s(this,v,SIMB,"SIMB");}
        public DataStorage FromSIUnitPetabits(double v){return s(this,v,SIPBI,"SIPBI");}
        public DataStorage FromSIUnitPetabytes(double v){return s(this,v,SIPB,"SIPB");}
        public DataStorage FromSIUnitTerabits(double v){return s(this,v,SITBI,"SITBI");}
        public DataStorage FromSIUnitTerabytes(double v){return s(this,v,SITB,"SITB");}
        public DataStorage FromSIUnitYottabits(double v){return s(this,v,SIYBI,"SIYBI");}
        public DataStorage FromSIUnitYottabytes(double v){return s(this,v,SIYB,"SIYB");}
        public DataStorage FromSIUnitZettabits(double v){return s(this,v,SIZBI,"SIZBI");}
        public DataStorage FromSIUnitZettabytes(double v){return s(this,v,SIZB,"SIZB");}
        public DataStorage FromTerabits(double v){return s(this,v,TBI,"TBI");}
        public DataStorage FromTerabytes(double v){return s(this,v,TB,"TB");}
        public DataStorage FromWords(double v){return s(this,v,W,"W");}
        public DataStorage FromYottabits(double v){return s(this,v,YBI,"YBI");}
        public DataStorage FromYottabytes(double v){return s(this,v,YB,"YB");}
        public DataStorage FromZettabits(double v){return s(this,v,ZBI,"ZBI");}
        public DataStorage FromZettabytes(double v){return s(this,v,ZB,"ZB");}

        /// <summary>
        /// "To" Methods
        /// 
        /// Ex 1: double bar = foo.ToKilobytes(); //Variable "bar" being of type UnitOf.DataStorage with "From" value already assigned
        /// Ex 2: double foobar = new UnitOf.DataStorage().FromMegabytes(1.25).ToKilobytes(); //One line conversion from 1.25 Megabytes to Kilobytes
        /// </summary>
        public double ToBits(){return c(B);}
        public double ToBlocks(){return c(BL);}
        public double ToBluRay_DoubleLayer(){return c(BD2);}
        public double ToBluRay_SingleLayer(){return c(BD1);}
        public double ToBytes(){return c(BY);}
        public double ToCDs_74Minutes(){return c(CD74);}
        public double ToCDs_80Minutes(){return c(CD80);}
        public double ToDVDs_DoubleSidedDoubleLayer(){return c(D22);}
        public double ToDVDs_DoubleSidedSingleLayer(){return c(D12);}
        public double ToDVDs_SingleSidedDoubleLayer(){return c(D21);}
        public double ToDVDs_SingleSidedSingleLayer(){return c(D11);}
        public double ToExabits(){return c(EBI);}
        public double ToExabytes(){return c(EB);}
        public double ToFloppyDisks_35DD(){return c(F35DD);}
        public double ToFloppyDisks_35ED(){return c(F35ED);}
        public double ToFloppyDisks_35HD(){return c(F35HD);}
        public double ToFloppyDisks_525DD(){return c(F525DD);}
        public double ToFloppyDisks_525HD(){return c(F525HD);}
        public double ToGigabits(){return c(GBI);}
        public double ToGigabytes(){return c(GB);}
        public double ToKilobits(){return c(KBI);}
        public double ToKilobytes(){return c(KB);}
        public double ToMegabits(){return c(MBI);}
        public double ToMegabytes(){return c(MB);}
        public double ToNibbles(){return c(NI);}
        public double ToPetabits(){return c(PBI);}
        public double ToPetabytes(){return c(PB);}
        public double ToSIUnitExabits(){return c(SIEBI);}
        public double ToSIUnitExabytes(){return c(SIEB);}
        public double ToSIUnitGigabits(){return c(SIGBI);}
        public double ToSIUnitGigabytes(){return c(SIGB);}
        public double ToSIUnitKilobits(){return c(SIKBI);}
        public double ToSIUnitKilobytes(){return c(SIKB);}
        public double ToSIUnitMegabits(){return c(SIMBI);}
        public double ToSIUnitMegabytes(){return c(SIMB);}
        public double ToSIUnitPetabits(){return c(SIPBI);}
        public double ToSIUnitPetabytes(){return c(SIPB);}
        public double ToSIUnitTerabits(){return c(SITBI);}
        public double ToSIUnitTerabytes(){return c(SITB);}
        public double ToSIUnitYottabits(){return c(SIYBI);}
        public double ToSIUnitYottabytes(){return c(SIYB);}
        public double ToSIUnitZettabits(){return c(SIZBI);}
        public double ToSIUnitZettabytes(){return c(SIZB);}
        public double ToTerabits(){return c(TBI);}
        public double ToTerabytes(){return c(TB);}
        public double ToWords(){return c(W);}
        public double ToYottabits(){return c(YBI);}
        public double ToYottabytes(){return c(YB);}
        public double ToZettabits(){return c(ZBI);}
        public double ToZettabytes(){return c(ZB);}
    }
}