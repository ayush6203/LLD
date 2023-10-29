// See https://aka.ms/new-console-template for more information
using Factory.Classes;

Console.WriteLine("Hello, World!");

VehicleFactory factory = new VehicleFactory();
var obj1 = VehicleFactory.GetVehicle("bike");
Console.WriteLine(obj1.VehicleType());

var obj2 = VehicleFactory.GetVehicle("rikshaw");
Console.WriteLine(obj2.VehicleType());


Console.ReadKey();
