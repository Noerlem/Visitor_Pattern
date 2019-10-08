namespace Visitor_Pattern
{
    public class Bike : IElement
    {
        IElement[] parts = {new FrontWheel(), new RearWheel(), new Brakes(), new Bell()};

        public void accept(IVisitor visitor)
        {
            foreach (var part in parts)
            {
                part.accept(visitor);
            }
        }

        public bool _isRusty { get; set; } = true;
    }
    public class FrontWheel : IElement
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public bool _tireFlat { get; set; } = true;
    }

    public class RearWheel : IElement
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public bool _tireFlat { get; set; } = false;
    }

    public class Brakes : IElement
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public bool _isAdjusted { get; set; } = false;
    }

    public class Bell : IElement
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public bool _soundsAnnoying { get; set; } = false;
    }
}