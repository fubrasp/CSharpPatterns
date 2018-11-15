using System;
namespace patterns.Behavioral.Template
{
    public static class TemplatePatternDemo
    {
        public static void Start(){
            Game game = new Cricket();
            game.Play();
            Console.WriteLine("");
            game = new Football();
            game.Play();
        }
    }
}
