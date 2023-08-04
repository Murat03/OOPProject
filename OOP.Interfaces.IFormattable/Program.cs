// See https://aka.ms/new-console-template for more information

using OOP.Interfaces.IFormattable;

Console.WriteLine(DateTime.Now.ToString("d"));
var list = new List<Employee>() 
{
    new Employee()
    {
        Id = 1,
        Title = "Prof. Dr.",
        FirstName = "Ahmet",
        LastName = "Yazır"
    },
    new Employee()
    {
        Id = 2,
        Title = "Doç. Dr.",
        FirstName = "Kaan",
        LastName = "Dal"
    },
    new Employee()
    {
        Id = 3,
        Title = "Dr.",
        FirstName = "Mehmet",
        LastName = "Diken"
    }
};
foreach (var item in list)
{
    Console.WriteLine(item.ToString("F"));
}
Console.ReadKey();