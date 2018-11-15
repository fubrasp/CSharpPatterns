using System;
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
