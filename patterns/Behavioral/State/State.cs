using System;
namespace patterns.Behavioral.State
{
    public interface State
    {
        void DoAction(Context context);
    }
}
