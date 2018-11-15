using System;
using patterns.Behavioral.Strategy.strategies;

namespace patterns.Behavioral.Strategy
{
    public static class StrategyPatternDemo
    {
        public static void Start()
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
        }
    }
}
