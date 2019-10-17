using System;

namespace Visitor_Pattern
{
    public class MaintenancePerformer : IVisitor
    {
        public void visit(Bike bk)
        {
            if (bk._isRusty)
            {
                Console.WriteLine("Bike derusted\n");
                bk._isRusty = false;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with bike\n");
            }
        }

        public void visit(FrontWheel fw)
        {
            if (fw._tireFlat)
            {
                Console.WriteLine("Front tire fixed and pumped\n");
                fw._tireFlat = false;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with front wheel\n");
            }
        }

        public void visit(RearWheel rw)
        {
            if (rw._tireFlat)
            {
                Console.WriteLine("Rear tire fixed and pumped\n");
                rw._tireFlat = false;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with rear wheel\n");
            }
        }

        public void visit(Brakes brk)
        {
            if (!brk._isAdjusted)
            {
                Console.WriteLine("Brakes fixed\n");
                brk._isAdjusted = true;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with brakes\n");
            }
        }

        public void visit(Bell bl)
        {
            if (!bl._soundsAnnoying)
            {
                Console.WriteLine("Bell is fixed and annoying\n");
                bl._soundsAnnoying = true;
            }
            else
            {
                Console.WriteLine($"Nothing is wrong with bell\n");
            }
        }
    }
}