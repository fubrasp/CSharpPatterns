using System;
namespace patterns.Singleton
{
    public class SingletonPatternDemo
    {
        public static void Start(){
            SingleObject singleObject = SingleObject.Instance;
            singleObject.ShowMessage();
        }
    }
}
