using System;
namespace patterns.Behavioral.State
{
    public static class StatePatternDemo
    {
        public static void Start()
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.State);

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.State);
        }
    }
}
