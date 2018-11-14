﻿using System;
namespace patterns.Behavioral.Memento
{
    public class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
