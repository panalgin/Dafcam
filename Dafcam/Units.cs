using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dafcam
{
    public static class Units
    {
        public static decimal Ratio = 400;

        public static decimal StepsToMilimeter(decimal value)
        {
            return value / Ratio;
        }

        public static decimal MillimeterToSteps(decimal value)
        {
            return value * Ratio;
        }

        public static decimal MillimeterToCentimeter(decimal value)
        {
            return value / 10;
        }

        public static decimal CentimeterToMillimeter(decimal value)
        {
            return value * 10;
        }
    }
}
