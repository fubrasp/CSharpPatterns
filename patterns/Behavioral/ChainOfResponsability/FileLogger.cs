using System;
namespace patterns.Behavioral.ChainOfResponsability
{
    public class FileLogger : AbstractLogger {

       public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
