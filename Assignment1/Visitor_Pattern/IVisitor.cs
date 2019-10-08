using System.Security.Cryptography;

namespace Visitor_Pattern
{
    public interface IVisitor
    {
        void visit(Bike bk);
        void visit(FrontWheel fw);
        void visit(RearWheel rw);
        void visit(Brakes brk);
        void visit(Bell bl);
    }
}