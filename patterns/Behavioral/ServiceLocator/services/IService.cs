using System;
namespace patterns.Behavioral.ServiceLocator.services
{
    public interface IService
    {
        String GetName();
        void Execute();
    }
}
