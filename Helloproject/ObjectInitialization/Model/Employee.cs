using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitialization.Model
{
    public class Employee : Person
    {
        public Employee(string name, DateTime? birthdate, double salary, int employeeID) : base(name, birthdate)
        {
            Salary = salary;
            EmployeeID = employeeID;
        }

        public int EmployeeID { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nEmployeeID: {EmployeeID}" + $"\nSalary: {Salary}";
        }
    }

}
