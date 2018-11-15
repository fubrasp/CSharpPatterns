using System;
namespace patterns.Behavioral.Strategy.strategies
{
    public class OperationSubstract : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
