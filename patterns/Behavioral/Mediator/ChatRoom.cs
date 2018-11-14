using System;
namespace patterns.Behavioral.Mediator
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, String message)
        {
            Console.WriteLine($"{DateTime.Now.ToString()} [{user.Name}] : {message}");
        }
    }
}
