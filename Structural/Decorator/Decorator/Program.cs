using Decorator.Decorator.Toppings;
using Decorator.Pizza;

Console.WriteLine("Welcome to Decorator Pattern");

BasePizza orderdPizza = new ExtraCheeze(new FarmHouse());
Console.WriteLine(orderdPizza.Cost());

BasePizza orderedPizza1 = new Mushroom(orderdPizza);
Console.WriteLine(orderedPizza1.Cost());

Console.Read();
