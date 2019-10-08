using System;
using System.Runtime.InteropServices;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontWheel fw = new FrontWheel();
            RearWheel rw = new RearWheel();
            Brakes brk = new Brakes();
            Bell bl = new Bell();
            Bike bike = new Bike(fw, rw, brk, bl);

            MaintenancePerformer mp = new MaintenancePerformer();

            bike.accept(mp);
        }
    }
}
