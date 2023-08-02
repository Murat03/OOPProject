using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AddAClass
{
    internal class Employee
    {

        private string _firstName;
        private string _lastName;
        private List<Employee> _list;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { 
            //Expression-bodied property accessors
            get => _lastName; set => _lastName = value; }
        //Auto implemented property
        public int Age { get; set; }

        public List<Employee> Employees => _list;
        public Employee()
        {
            _list = new List<Employee>();
        }
        // Overloading
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string? ToString()
        {
            return $"{FirstName, -20} {LastName, -15} {Age, 5}";
        }
        public void Add(Employee employee)
        {
            _list.Add(employee);
        }
        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }
        public List<Employee> GetList() => _list;
    }
}
