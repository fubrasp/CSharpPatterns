using System;
namespace patterns.Behavioral.Observer
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            Subject = subject;
            Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Binary String: {ConvertIntegerToBinaryString(base.Subject.State)}");
        }

        private string ConvertIntegerToBinaryString(int inputInteger){
            return Convert.ToString(inputInteger, 2);
        }
    }
}
