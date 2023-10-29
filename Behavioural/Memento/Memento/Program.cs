// See https://aka.ms/new-console-template for more information
using Memento.ActorClasses;

Console.WriteLine("Hello, Memento World!");


Originator originatior = new Originator();
CareTaker careTaker = new CareTaker();
originatior.SetState = "State #1";
originatior.SetState = "State #2";
careTaker.Add(originatior.SaveStateToMemento());
originatior.SetState = "State #3";
careTaker.Add(originatior.SaveStateToMemento());
originatior.SetState = "State #4";

Console.WriteLine("Current State : " + originatior.GetState);
originatior.GetStateFromMemento(careTaker.Get(0));

Console.WriteLine("First Saved State : " + originatior.GetState);
originatior.GetStateFromMemento(careTaker.Get(1));
Console.WriteLine("Second Saved State : " + originatior.GetState);

Console.ReadKey();