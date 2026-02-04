// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Helloproject.Data
{
    public class Student
    {
        public Student(string? firstName, string lastName, int? yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public Student() { }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int? YearOfBirth { get; set; }

        public string HelloName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
