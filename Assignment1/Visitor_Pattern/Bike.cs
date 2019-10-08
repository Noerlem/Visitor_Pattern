using System;
using System.Collections.Generic;

namespace Visitor_Pattern
{
    public class Bike : IElement
    {
        public Bike(FrontWheel fw, RearWheel rw, Brakes brk, Bell bl)
        {
            parts.Add(fw);
            parts.Add(rw);
            parts.Add(brk);
            parts.Add(bl);
        }

        public void accept(IVisitor visitor)
        {
            foreach (var part in parts)
            {
                part.accept(visitor);
            }
            visitor.visit(this);
        }

        private List<IElement> parts = new List<IElement>();
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