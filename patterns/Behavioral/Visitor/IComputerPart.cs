using System;
namespace patterns.Behavioral.Visitor
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
