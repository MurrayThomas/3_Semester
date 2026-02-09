using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitialization.Model
{

    public class Person
    {
        private string? name;
        private DateTime? birthdate;

        public Person()
        {
        }

        public Person(string inName)
        {
            name = inName;
        }

        public Person(string inName, DateTime? birthdate) : this(inName)
        {
            this.birthdate = birthdate;
        }

        public string? Name { get { return name; } set { name = value; } }

        public DateTime? Birthdate { get { return birthdate; } set { birthdate = value; } }

        public override string ToString()
        {
            if (Birthdate == null)
            {
                return $"Name: {Name}";
            }

            return $"Name: {name}, Birthdate: {birthdate:dd-MM-yyyy}";
        }
    }
}
