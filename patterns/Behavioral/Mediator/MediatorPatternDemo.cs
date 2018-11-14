using System;
namespace patterns.Behavioral.Mediator
{
    public static class MediatorPatternDemo
    {
        public static void Start()
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");
        }
    }
}
