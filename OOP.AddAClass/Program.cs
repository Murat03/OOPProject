// See https://aka.ms/new-console-template for more information
using OOP.AddAClass;

var employee = new Employee();
employee.AddRange(new Employee() { FirstName = "Murat", LastName = "İpek", Age = 25 },
    new Employee("Murat2", "İpek2", 252),
    new Employee("Melih", "İpek", 252),
    new Employee("Melih2", "İpek2", 252)
    );
employee.Add(new Employee("Murat3", "İpek3", 253));

var list = employee.GetList();

foreach (var item in list)
{
    Console.WriteLine(item);
}
//Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {employee2.Age}");
Console.ReadLine();