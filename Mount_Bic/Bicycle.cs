using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mount_Bic
{
    class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;
        public Bicycle(int cadence,int speed,int gear)
        {
            this.cadence = cadence;
            this.speed = speed;
            this.gear = gear;
        }
        public void setcadence(int c)
        {
            cadence = c;
        }
        public void setGear(int g)
        {
            gear = g;
        }
        public void applybrakes(int dec)
        {
            speed=speed-dec;
        }
        public void speedUp(int inc)
        {
            speed=speed+inc;
        }
        public int getspeed()
        {
            return speed;
        }
        public int getgear()
        {
            return gear;
        }
        public int getcadence()
        {
            return cadence;
        }

    }
}
