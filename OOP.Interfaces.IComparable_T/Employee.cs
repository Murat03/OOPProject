using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IComparable_T
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.FullName.CompareTo(other.FullName);
        }

        public override string ToString()
        {
            return $"{Id,-5} {FullName, -25} {Salary, -7}";
        }
    }
}
