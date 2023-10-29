// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Iterator Pattern Demo");

NameRepository nameRepository = new NameRepository();
var iterator = nameRepository.GetIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}

Console.ReadKey();