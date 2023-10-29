using Prototype;
Driver.DeepCopy();
Console.ReadLine();



static class Driver
{
    public static void ShallowCopy()
    {
        Employee empJohn = new Employee() { Id = Guid.NewGuid(), Name = "john", DepartmentId = 150 };
        Console.WriteLine(empJohn.ToString());

        Employee empSam = (Employee)empJohn.Clone();
        empSam.Name = "Sam";
        Console.WriteLine(empSam.ToString());

        Console.WriteLine("Changing department ID of John to 161");
        empJohn.DepartmentId = 161;

        Console.WriteLine(empJohn.ToString());
        Console.WriteLine(empSam.ToString());
    }

    public static void ShallowCopyRef()
    {
        Employee empJohn = new Employee() { Id = Guid.NewGuid(), Name = "John", DepartmentId = 150, Address = new Address() { Country = "US", ZipCode = 1452, DoorNumber = 41, StreetNumber = 3 } };
        Console.WriteLine(empJohn.ToString());

        Employee empSame = (Employee)empJohn.Clone();
        empSame.Name = "Sam";
        empSame.DepartmentId = 141;
        empSame.Address.Country = "India";

        Console.WriteLine(empJohn.ToString());
        Console.WriteLine(empSame.ToString());
    }

    public static void DeepCopy()
    {
        Employee empJohn = new Employee() { Id = Guid.NewGuid(), Name = "John", DepartmentId = 150, Address = new Address() { Country = "US", ZipCode = 1452, DoorNumber = 41, StreetNumber = 3 } };
        Console.WriteLine(empJohn.ToString());

        Employee empSame = empJohn.DeepClone();
        empSame.Name = "Sam";
        empSame.DepartmentId = 141;
        empSame.Address.Country = "India";

        Console.WriteLine(empJohn.ToString());
        Console.WriteLine(empSame.ToString());
    }
}
