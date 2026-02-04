using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList.Data
{
    public class Student
    {
        public List<string?> Students { get; set; }

        public Student()
        {
            Students = new List<string?>()
            {
                "Thomas",
                "Kristian",
                "Jens"
            };
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? YearOfBirth { get; set; }
    }
}
