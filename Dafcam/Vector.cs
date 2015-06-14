using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CncDrill
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector operator - (Vector a, Vector b)
        {
            return (new Vector(a.X - b.X, a.Y - b.Y));
        }

        public static double operator *(Vector a, Vector b)
        {
            return (a.X * b.X) + (a.Y * b.Y);
        }

        private double DistanceTo(Vector b)
        {
            Vector a = this;
            // Math.Square((x2 - x1)^2 + (y2 - y1)^2);


            return Math.Abs(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));
        }

        private double GetAngle(Vector b, Vector c)
        {
            Vector a = this;

            Vector ab_Vec = b - a;
            Vector ac_Vec = c - a;

            double ab_Dist = a.DistanceTo(b);
            double ac_Dist = a.DistanceTo(c);

            //Formula ABv . ACv / ABd . ACd  = cos alpha

            return (ab_Vec * ac_Vec) / (ab_Dist * ac_Dist);
        }

        public double GetAngleInDegree(Vector b, Vector c)
        {
            double m_Radian = Math.Acos(GetAngle(b, c));

            return (m_Radian * 180) / Math.PI;
        }
    }
}
