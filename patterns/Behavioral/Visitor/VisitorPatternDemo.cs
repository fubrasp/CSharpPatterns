using System;
using patterns.Behavioral.Visitor.visitor;
using patterns.Behavioral.Visitor.visited;

namespace patterns.Behavioral.Visitor
{
    public static class VisitorPatternDemo
    {
        public static void Start()
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
