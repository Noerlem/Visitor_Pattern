namespace Visitor_Pattern
{
    public interface IElement
    {
        void accept(IVisitor visitor);
    }
}