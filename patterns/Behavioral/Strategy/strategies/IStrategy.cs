using System;
namespace patterns.Behavioral.Strategy.strategies
{
    public interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}
