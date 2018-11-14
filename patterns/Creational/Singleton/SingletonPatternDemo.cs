using System;
namespace patterns.Singleton
{
    public static class SingletonPatternDemo
    {
        public static void Start()
        {
            SingleObject singleObject = SingleObject.Instance;
            singleObject.ShowMessage();
        }
    }
}
