using System;
using patterns.Behavioral.Visitor.visitor;

namespace patterns.Behavioral.Visitor.visited
{
    public class Computer : IComputerPart
    {
        public IComputerPart[] Parts { get; set; }

        public Computer()
        {
            Parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach(IComputerPart part in Parts){
                part.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}
