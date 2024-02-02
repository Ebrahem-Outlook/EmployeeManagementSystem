using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Department { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee(int _Id, String _Name, String _Department, double _Salary)
        {
            this.Id = _Id; 
            this.Name = _Name; 
            this.Department = _Department; 
            this.Salary = _Salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}";
        }
    }
}
