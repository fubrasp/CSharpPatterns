using System;
namespace patterns.Behavioral.Mediator
{
    public class User
    {
        public String Name { get; set; }

        public User(String name)
        {
            Name = name;
        }

        public void SendMessage(String message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
