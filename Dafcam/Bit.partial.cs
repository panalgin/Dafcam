using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Media3D;

namespace Dafcam
{
    public partial class Bit
    {
        public Vector3D StallsAt 
        {
            get
            {
                return Vector3D.Parse(this.IntStallsAt);
            }
            set
            {
                this.IntStallsAt = string.Format("{0},{1},{2}", value.X, value.Y, value.Z);
            }
        }

        public Vector3D DropsAt
        {
            get
            {
                return Vector3D.Parse(this.IntDropsAt);
            }
            set
            {
                this.IntDropsAt = string.Format("{0},{1},{2}", value.X, value.Y, value.Z);
            }
        }
    }
}