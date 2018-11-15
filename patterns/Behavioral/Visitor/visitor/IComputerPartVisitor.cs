using System;
using patterns.Behavioral.Visitor.visited;

namespace patterns.Behavioral.Visitor.visitor
{
    public interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}
