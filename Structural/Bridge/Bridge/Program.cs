using Bridge;
using Bridge.ConcreteLivingThings;
using Bridge.Implementation;

Dog dog = new Dog();
Fish fish = new Fish();
OakTree tree = new OakTree();

dog.Breathe();
fish.Breathe();
tree.Breathe();

Console.ReadKey();
