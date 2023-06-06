using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mount_Bic
{
    class MountainBike:Bicycle
    {
        private int seaheight;
        public MountainBike(int seaheight,int cadence,int speed,int gear):base(cadence,speed,gear)
        {
            this.seaheight = seaheight;
        }
        public void setseaheight(int height)
        {
            seaheight = height;
        }
        public int getseaheight()
            {
            return seaheight;
        }
    }
}
