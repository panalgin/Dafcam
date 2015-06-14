using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dafcam
{
    public static class Core
    {
        public static Controller Controller { get; set; }
        public static Spindle Spindle { get; set; }

        public static void ApplySettings()
        {
            /*
             * 0 = XMaxRpm
             * 1 = YMaxRpm
             * 2 = ZMaxRpm
             * 
             * 3 = XShortRpm
             * 4 = YShortRpm
             * 
             * 5 = ZDrillRpm
             * 6 = ZLiftRpm
             * 
             * 7 = ZDrillRampable
             * 8 = ZLiftRampable
             * 
             * 9 = XShortDistance
             * 10 = XRampStartRpm
             * 11 = YShortDistance
             * 12 = YRampStartRpm
             * 13 = ZShortDistance
             * 14 = ZRampStartRpm
             */

            using (DafcamEntities m_Context = new DafcamEntities())
            {

                Motor x_Motor = m_Context.Motors.Where(q => q.Axis.Name == "X").FirstOrDefault();
                Motor y_Motor = m_Context.Motors.Where(q => q.Axis.Name == "Y").FirstOrDefault();
                Motor z_Motor = m_Context.Motors.Where(q => q.Axis.Name == "Z").FirstOrDefault();

                string m_Message = string.Format("Settings={0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9}:{10}:{11}:{12}:{13}:{14};",
                    x_Motor.MaxRpm,
                    y_Motor.MaxRpm,
                    z_Motor.MaxRpm,

                    x_Motor.DwellRpm,
                    y_Motor.DwellRpm,

                    150,
                    200,

                    "True",
                    "True",

                    x_Motor.ShortDistance,
                    x_Motor.AccelerationStartsAt,
                    y_Motor.ShortDistance,
                    y_Motor.AccelerationStartsAt,
                    z_Motor.ShortDistance,
                    z_Motor.AccelerationStartsAt
                    );

                Core.Controller.Send(m_Message);
            }
        }
    }
}
