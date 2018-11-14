using System;
namespace patterns.Behavioral.State
{
    public class Context
    {
        public State State { get; set; }

        public Context()
        {
            State = null;
        }
    }
}
