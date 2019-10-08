using System;
using System.Runtime.InteropServices;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            MaintenancePerformer mp = new MaintenancePerformer();

            mp.visit(bike);

            Console.Read();
        }
    }
}
