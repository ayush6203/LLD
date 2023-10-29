// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, Mediator Design Pattern!");

User robert = new User("Robert");
User john = new User("John");

robert.SendMessage("Hi! John how are you doing");
john.SendMessage("Hey Robert, I am good you tell!");

Console.Read();
