using System;
using WonderCircuits.UnitOf.Common;

namespace WonderCircuits.UnitOf
{
    /// <summary>
    /// UnitOf.Angle()
    /// 
    /// Ex: double foo = new UnitOf.Angle().FromDegrees(1.25).ToRadians(); //One line conversion from 1.25 Degrees to Radians
    /// </summary>
    public class Angle : UnitConverterBase
    {
        #region Constants
        internal static readonly double C = 1/360.0;          //Circle
        internal static readonly double D = 1;                //Degree
        internal static readonly double G = 1/0.9;            //Gradian
        internal static readonly double MIL = (1/0.05625);    //Angular Mil
        internal static readonly double M = 60;               //Minute 
        internal static readonly double Q = 1/90.0;           //Quadrant
        internal static readonly double RAD = Math.PI/180.0;  //Radian
        internal static readonly double R = 1/360.0;          //Revolution
        internal static readonly double RA = 1/90.0;          //Right Angle
        internal static readonly double S = 3600;             //Second 
        internal static readonly double SE = 1/60.0;          //Sextant
        internal static readonly double SI = (1/30.0);        //Sign
        internal static readonly double T = 1/360.0;          //Turn
        #endregion

        #region From Methods
        /// <summary>
        /// "From" Methods
        /// 
        /// Ex: UnitOf.Angle foo = new UnitOf.Angle().FromDegrees(1.25); //Variable "foo" will be able to convert 1.25 Degrees into any unit of Angle
        /// </summary>
        public Angle FromCircles(double v) { return From(v, C, "C"); }
        public Angle FromDegrees(double v) { return From(v, D, "D"); }
        public Angle FromGradians(double v) { return From(v, G, "G"); }
        public Angle FromMils(double v) { return From(v, MIL, "MIL"); }
        public Angle FromMinutes(double v) { return From(v, M, "M"); }
        public Angle FromQuadrants(double v) { return From(v, Q, "Q"); }
        public Angle FromRadians(double v) { return From(v, RAD, "RAD"); }
        public Angle FromRevolutions(double v) { return From(v, R, "R"); }
        public Angle FromRightAngles(double v) { return From(v, RA, "RA"); }
        public Angle FromSeconds(double v) { return From(v, S, "S"); }
        public Angle FromSextants(double v) { return From(v, SE, "SE"); }
        public Angle FromSigns(double v) { return From(v, SI, "SI"); }
        public Angle FromTurns(double v) { return From(v, T, "T"); }

        private Angle From(double v, double tt, string ts)
        {
            Store(v, tt, ts);
            return this;
        }
        #endregion

        #region To Methods
        public double ToCircles() { return To(C); }
        public double ToDegrees() { return To(D); }
        public double ToGradians() { return To(G); }
        public double ToMils() { return To(MIL); }
        public double ToMinutes() { return To(M); }
        public double ToQuadrants() { return To(Q); }
        public double ToRadians() { return To(RAD); }
        public double ToRevolutions() { return To(R); }
        public double ToRightAngles() { return To(RA); }
        public double ToSeconds() { return To(S); }
        public double ToSextants() { return To(SE); }
        public double ToSigns() { return To(SI); }
        public double ToTurns() { return To(T); }

        private double To(double t)
        {
            return Conversion(t, Varaibles.FromConstant);
        }
        #endregion
    }
}