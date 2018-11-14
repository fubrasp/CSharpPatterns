using System;
namespace patterns.Behavioral.ChainOfResponsability
{
    public class ErrorLogger : AbstractLogger {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine($"Error Console::Logger: {message}");
        }
    }
}
