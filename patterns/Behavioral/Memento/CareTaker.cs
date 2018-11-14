using System;
using System.Collections.Generic;

namespace patterns.Behavioral.Memento
{
    public class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void Add(Memento state){
            mementos.Add(state);
        }

        public Memento Get(int index){
            return mementos[index];
        }
    }
}
