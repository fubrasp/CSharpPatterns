using System;
namespace patterns.Behavioral.Template
{
    public class Cricket : Game
    {
        protected override void EndPlay()
        {
            Console.WriteLine("Criket Game Finished!");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Criket Game Initialized! Start playing.");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Criket Game Started. Enjoy the game!");
        }
    }
}
