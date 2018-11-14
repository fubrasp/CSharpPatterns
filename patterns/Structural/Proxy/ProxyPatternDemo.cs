using System;
namespace patterns.Structural.Proxy
{
    public class ProxyPatternDemo
    {
        public static void Start(){
            Image image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.Display();
            Console.WriteLine("");

            //image will not be loaded from disk
            image.Display();
        }
    }
}
