using System;
namespace patterns.Behavioral.Observer
{
    public class OctalObserver : Observer
    {

        public OctalObserver(Subject subject)
         {
             this.Subject = subject;
             this.Subject.Attach(this);
         }
        
        public override void Update()
         {
              Console.WriteLine($"Octal String: {ConvertIntegerToOctalString(Subject.State)}");
         }
        
         private string ConvertIntegerToOctalString(int inputInteger)
         {
             return Convert.ToString(inputInteger, 8);
         }
    }
}
