using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class ManagementSystem
    {
        private List<Employee> employees;

        public ManagementSystem()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddEmployee(int _Id, String _Name, String _Department, double _Salary)
        {
            employees.Add(new Employee(_Id, _Name, _Department, _Salary));
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Employee List::");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public void UpdateEmployee(int _Id, String _Name, String _Department, double _Salary)
        {
            foreach (var employee in employees)
            {
                if (employee.Id == _Id)
                {
                    employee.Name = _Name;
                    employee.Department = _Department;
                    employee.Salary = _Salary;
                    Console.WriteLine($"Employee with ID {_Id} updated succeefully.");
                    return;
                }
            }
            Console.WriteLine($"Employee with ID {_Id} not found.");
        }

        public void RemoveEmployee(int _Id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == _Id)
                {
                    employees.RemoveAt(i);
                    Console.WriteLine($"Employee with ID {_Id} deleted.");
                    return;
                }
            }
            Console.WriteLine($"Employee with ID {_Id} id not found");
        }

    }
}
