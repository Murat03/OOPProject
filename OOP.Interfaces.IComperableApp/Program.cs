// See https://aka.ms/new-console-template for more information

using OOP.Interfaces.IComperableApp;

var employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FullName = "Mehmet Yılmaz",
        Salary = 9500
    },
    new Employee()
    {
        Id=2,
        FullName = "Ali Sunal",
        Salary = 15000
    },
    new Employee()
    {
        Id = 3,
        FullName = "Mustafa Kılıçdar",
        Salary = 20000
    },
    new Employee()
    {
        Id = 4,
        FullName = "Mahmut Erdoğan",
        Salary = 2000
    },
    new Employee()
    {
        Id = 5,
        FullName = "Merve Haznedar",
        Salary = 30000
    }

};
employees.Sort();
foreach(var employee in employees)
{
    Console.WriteLine(employee);
}

Console.ReadKey();