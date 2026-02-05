using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList.Data
{
    public class Student
    {
        public IEnumerable<string?> Students { get; set; }

        public Student()
        {
            Students = new List<string?>()
            {
                "Thomas",
                "Joe",
                "Bob",
                " "
            };
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? YearOfBirth { get; set; }
    }
}
