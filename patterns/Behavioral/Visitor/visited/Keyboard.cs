using System;
using patterns.Behavioral.Visitor.visitor;

namespace patterns.Behavioral.Visitor.visited
{
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
