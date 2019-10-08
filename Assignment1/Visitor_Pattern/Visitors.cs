using System;

namespace Visitor_Pattern
{
    public class MaintenancePerformer : IVisitor
    {
        public void visit(Bike bk)
        {
            if (bk._isRusty)
            {
                Console.WriteLine("Bike derusted");
                bk._isRusty = false;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with {bk.ToString()}");
            }
        }

        public void visit(FrontWheel fw)
        {
            if (fw._tireFlat)
            {
                Console.WriteLine("Tire fixed and pumped");
                fw._tireFlat = false;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with {fw.ToString()}");
            }
        }

        public void visit(RearWheel rw)
        {
            if (rw._tireFlat)
            {
                Console.WriteLine("Tire fixed and pumped");
                rw._tireFlat = false;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with {rw.ToString()}");
            }
        }

        public void visit(Brakes brk)
        {
            if (!brk._isAdjusted)
            {
                Console.WriteLine("Brakes fixed");
                brk._isAdjusted = true;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with {brk.ToString()}");
            }
        }

        public void visit(Bell bl)
        {
            if (!bl._soundsAnnoying)
            {
                Console.WriteLine("Bell is fixed and annoying");
                bl._soundsAnnoying = true;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with {bl.ToString()}");
            }
        }
    }
}