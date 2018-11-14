using System;
namespace patterns.Behavioral.Observer
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Hex String: {base.Subject.State}");
        }

        private string ConvertIntegerToHexString(int inputInteger)
        {
            return inputInteger.ToString("X");
        }
    }
}
