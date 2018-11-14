using System;
using System.Collections.Generic;

namespace patterns.Behavioral.Observer
{
    public class Subject
    {
         private List<Observer> _observers = new List<Observer>();
         public int State {
             get { return State; }
             set{
                 State = value;
                 NotifyAllObservers();
             }
         }

         public void Attach(Observer observer)
         {
             _observers.Add(observer);
         }

         public void NotifyAllObservers()
         {
             _observers.ForEach(o => o.Update());
         }
    }
}
