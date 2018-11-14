using System;
namespace patterns.Behavioral.ChainOfResponsability
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine($"Standard Console::Logger: {message}");
        }
    }
}
