using System;
namespace patterns.Behavioral.State
{
    public class StopState : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.State=this;
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
