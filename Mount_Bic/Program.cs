using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mount_Bic
{
    class Program
    {
        static void Main(string[] args)
        {
         MountainBike b= new MountainBike(23,34,45,4);
         Console.WriteLine("The sea height is "+b.getseaheight()+" ft and speed is "+b.getspeed()+" mps and cadence is "+b.getcadence());
         Console.ReadKey();
         b.setseaheight(344);
         b.speedUp(20);
         b.setcadence(5);
         b.applybrakes(1);
         b.setGear(5);
         Console.WriteLine("The sea height is " + b.getseaheight() + " ft and speed is " + b.getspeed() + " mps and cadence is " + b.getcadence());
         Console.ReadKey();
        }
    }
}
