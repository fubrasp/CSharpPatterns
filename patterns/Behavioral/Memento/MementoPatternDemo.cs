using System;
namespace patterns.Behavioral.Memento
{
    public class MementoPatternDemo
    {
        public static void Start(){
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.State="State #1";
            originator.State="State #2";
            careTaker.Add(originator.SaveStateToMemento());

            originator.State="State #3";
            careTaker.Add(originator.SaveStateToMemento());

            originator.State="State #4";
            Console.WriteLine($"Current State: {originator.State}");

            originator.GetStateFromMemento(careTaker.Get(0));
            Console.WriteLine($"First saved State: {originator.State}");
            originator.GetStateFromMemento(careTaker.Get(1));
            Console.WriteLine($"Second saved State: {originator.State}");
        }
    }
}
