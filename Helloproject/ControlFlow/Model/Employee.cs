using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow.Model
{

    public class Employee
    {
        //Constructor
        public Employee(string inName, DateTime inStartDate, JobTitle inJobTitle)
        {
            Name = inName;
            StartDate = inStartDate;
            JobTitle = inJobTitle;
        }
        public DateTime StartDate { get; set; }
        public JobTitle JobTitle { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Start Date: {StartDate.ToShortDateString()}, Job Title: {JobTitle}";
        }

    }
}
