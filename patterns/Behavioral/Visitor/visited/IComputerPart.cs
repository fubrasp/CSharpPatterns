using System;
using patterns.Behavioral.Visitor.visitor;

namespace patterns.Behavioral.Visitor.visited
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
